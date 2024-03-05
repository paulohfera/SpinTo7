using Assets.Scripts.Core;
using Assets.Scripts.Game;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Generator
{
	public class BoardGeneratorHexagon : MonoBehaviour
	{
		private static BoardGeneratorHexagon _instance;
		public static BoardGeneratorHexagon Instance { get { return _instance; } }

		private Color Color1 = new Color32(0, 0, 0, 255);
		private Color ColorMatch = new Color32(255, 255, 255, 255);
		private List<Hexagon> TileList;
		private List<Axis> Axes;
		private Canvas canvas;
		private int Tiles = 0;
		private int MatchsToWin = 0;
		private float ThreeStarsLimit = 0;
		private float TwoStarsLimit = 0;
		private string folder = "Hexagon";
		private int Rotate = 60;

		public int Quantity;
		public int BlockWidth = 150;
		public int BlockHeight = 172;
		public RectTransform CodeContent;
		public InputField Code;
		public InputField LevelNumber;
		public Difficulty Difficulty;

		void Awake()
		{
			if (_instance != null && _instance != this)
			{
				Destroy(gameObject);
			}
			else
			{
				_instance = this;
			}
		}

		private void Start()
		{
			CreateBoard();
		}

		public void CreateBoard()
		{
			HudManager.Instance.Difficulty = Difficulty;

			TileList = new List<Hexagon>();
			BlockWidth = 150;
			BlockHeight = 172;

			canvas = FindObjectOfType<Canvas>();
			var obj0 = Instantiate(Resources.Load("Hexagon_X_Y"), canvas.transform) as GameObject;
			AddTile(obj0, 0, 0);
			GetPossibleAxes();

			while (Tiles < Quantity)
			{
				var rnd = new System.Random();
				var next = Axes.OrderBy(o => rnd.Next()).First();

				var obj = Instantiate(Resources.Load("Hexagon_X_Y"), canvas.transform) as GameObject;
				AddTile(obj, next.X, next.Y);
				GetPossibleAxes();
			}

			DistributeTiles();
			FillTileNumbers();
			//RotateTiles();
		}

		private void DistributeTiles()
		{
			var maxX = TileList.Max(t => t.x);
			var minX = TileList.Min(t => t.x);
			var x = maxX - minX + 1;
			if (x > 8)
			{
				var per = (x - 8) * 6;
				BlockWidth = 150 - (150 * per / 100);
				BlockHeight = 172 - (172 * per / 100);
			}
			float posX = BlockWidth / 2;

			var maxY = TileList.Max(t => t.y);
			var minY = TileList.Min(t => t.y);
			var y = maxY - minY + 1;
			if (y > 7)
			{
				var per = (y - 8) * 6;
				var width = 150 - (150 * per / 100);
				var height = 172 - (172 * per / 100);

				if (width < BlockWidth && height < BlockHeight)
				{
					BlockWidth = width;
					BlockHeight = height;
				}
			}
			float posY = (BlockHeight / 2) + (BlockHeight / 4) + 1f;

			var halfX = Mathf.Floor(x / 2);
			var diffX = (halfX - maxX) * BlockWidth / 2;
			if (x % 2 == 0) diffX = diffX - BlockWidth / 4;

			var halfY = Mathf.Floor(y / 2);
			var diffY = (halfY - maxY) * posY;
			if (y % 2 == 0) diffY = diffY - posY / 2;
			//diffY = 0;

			foreach (var item in TileList)
			{
				var rect = item.GetComponent<RectTransform>();
				rect.sizeDelta = new Vector2(BlockWidth, BlockHeight);

				item.transform.localPosition = new Vector3(diffX + (item.x * posX), diffY + (item.y * posY));
				item.Init();
			}
		}

		public void RecreateBoard()
		{
			if (TileList != null)
			{
				foreach (var item in TileList)
				{
					Destroy(item.transform.gameObject);
				}
			}

			Tiles = 0;
			CreateBoard();
		}

		private void AddTile(GameObject obj, int x, int y)
		{
			var tile = obj.GetComponent<Hexagon>();
			tile.x = x;
			tile.y = y;
			tile.Top1 = Tiles;
			TileList.Add(tile);

			Tiles++;
		}

		private void GetPossibleAxes()
		{
			Axes = new List<Axis>();

			foreach (var item in TileList)
			{
				var above1 = TileList.FirstOrDefault(t => t.x == item.x - 1 && t.y == item.y + 1);
				if (above1 == null) Axes.Add(new Axis { X = item.x - 1, Y = item.y + 1 });

				var above2 = TileList.FirstOrDefault(t => t.x == item.x + 1 && t.y == item.y + 1);
				if (above2 == null) Axes.Add(new Axis { X = item.x + 1, Y = item.y + 1 });

				var right = TileList.FirstOrDefault(t => t.x == item.x + 2 && t.y == item.y);
				if (right == null) Axes.Add(new Axis { X = item.x + 2, Y = item.y });

				var below1 = TileList.FirstOrDefault(t => t.x == item.x + 1 && t.y == item.y - 1);
				if (below1 == null) Axes.Add(new Axis { X = item.x + 1, Y = item.y - 1 });

				var below2 = TileList.FirstOrDefault(t => t.x == item.x - 1 && t.y == item.y - 1);
				if (below2 == null) Axes.Add(new Axis { X = item.x - 1, Y = item.y - 1 });

				var left = TileList.FirstOrDefault(t => t.x == item.x - 2 && t.y == item.y);
				if (left == null) Axes.Add(new Axis { X = item.x - 2, Y = item.y });
			}
		}

		public void FillTileNumbers()
		{
			MatchsToWin = 0;
			ResetRotate();

			foreach (var item in TileList)
			{
				item.HasNumbers = false;
			}

			foreach (var item in TileList)
			{
				var above1 = TileList.FirstOrDefault(t => t.x == item.x - 1 && t.y == item.y + 1 && t.HasNumbers);
				if (above1 == null)
					item.Top1 = GetRandomNumber();
				else
				{
					item.Top1 = 7 - above1.Bottom1;
					MatchsToWin++;
				}


				var above2 = TileList.FirstOrDefault(t => t.x == item.x + 1 && t.y == item.y + 1 && t.HasNumbers);
				if (above2 == null)
					item.Top2 = GetRandomNumber();
				else
				{
					item.Top2 = 7 - above2.Bottom2;
					MatchsToWin++;
				}


				var right = TileList.FirstOrDefault(t => t.x == item.x + 2 && t.y == item.y && t.HasNumbers);
				if (right == null)
					item.Right = GetRandomNumber();
				else
				{
					item.Right = 7 - right.Left;
					MatchsToWin++;
				}


				var below1 = TileList.FirstOrDefault(t => t.x == item.x + 1 && t.y == item.y - 1 && t.HasNumbers);
				if (below1 == null)
					item.Bottom1 = GetRandomNumber();
				else
				{
					item.Bottom1 = 7 - below1.Top1;
					MatchsToWin++;
				}


				var below2 = TileList.FirstOrDefault(t => t.x == item.x - 1 && t.y == item.y - 1 && t.HasNumbers);
				if (below2 == null)
					item.Bottom2 = GetRandomNumber();
				else
				{
					item.Bottom2 = 7 - below2.Top2;
					MatchsToWin++;
				}


				var left = TileList.FirstOrDefault(t => t.x == item.x - 2 && t.y == item.y && t.HasNumbers);
				if (left == null)
					item.Left = GetRandomNumber();
				else
				{
					item.Left = 7 - left.Right;
					MatchsToWin++;
				}

				item.HasNumbers = true;
				item.Init();
			}
		}

		private int GetRandomNumber()
		{
			var number = UnityEngine.Random.Range(0, 80000);
			if (number >= 0 && number <= 10000) return 0;
			if (number >= 10001 && number <= 20000) return 1;
			if (number >= 20001 && number <= 30000) return 2;
			if (number >= 30001 && number <= 40000) return 3;
			if (number >= 40001 && number <= 50000) return 4;
			if (number >= 50001 && number <= 60000) return 5;
			if (number >= 60001 && number <= 70000) return 6;
			return 7;
		}

		public void RotateTiles()
		{
			ThreeStarsLimit = 0;
			TwoStarsLimit = 0;
			ResetRotate();

			foreach (var item in TileList)
			{
				var timesToReset = item.CorrectRotate / Rotate;
				if (timesToReset > 0)
				{
					RotateTile(item, timesToReset);
					item.CorrectRotate = 0;
				}

				var times = GetRandomRotate();
				if (times == 0) continue;

				RotateTile(item, times);

				item.CorrectRotate = 360 - (times * Rotate);

				ThreeStarsLimit = ThreeStarsLimit + (item.CorrectRotate / Rotate);
			}

			CheckInitialMatchs();
		}

		private void RotateTile(Hexagon item, int times)
		{
			var rotate = times * Rotate;

			iTween.RotateTo(item.transform.gameObject, new Vector3(0, 0, rotate), 0);

			item.Top1Text.transform.Rotate(new Vector3(0, 0, -rotate));
			item.Top1Text.color = Color1;

			item.Top2Text.transform.Rotate(new Vector3(0, 0, -rotate));
			item.Top2Text.color = Color1;

			item.RightText.transform.Rotate(new Vector3(0, 0, -rotate));
			item.RightText.color = Color1;

			item.Bottom1Text.transform.Rotate(new Vector3(0, 0, -rotate));
			item.Bottom1Text.color = Color1;

			item.Bottom2Text.transform.Rotate(new Vector3(0, 0, -rotate));
			item.Bottom2Text.color = Color1;

			item.LeftText.transform.Rotate(new Vector3(0, 0, -rotate));
			item.LeftText.color = Color1;

			for (int i = 0; i < times; i++)
			{
				item.SetNumbers();
				item.SetTexts();
			}
		}

		public void ResetRotate()
		{
			foreach (var item in TileList)
			{
				if (item.CorrectRotate == 0) continue;

				item.transform.rotation = new Quaternion(0, 0, 0, 0);

				item.Top1Text.transform.rotation = new Quaternion(0, 0, 0, 0);
				item.Top1Text.color = Color1;

				item.Top2Text.transform.rotation = new Quaternion(0, 0, 0, 0);
				item.Top2Text.color = Color1;

				item.RightText.transform.rotation = new Quaternion(0, 0, 0, 0);
				item.RightText.color = Color1;

				item.Bottom1Text.transform.rotation = new Quaternion(0, 0, 0, 0);
				item.Bottom1Text.color = Color1;

				item.Bottom2Text.transform.rotation = new Quaternion(0, 0, 0, 0);
				item.Bottom2Text.color = Color1;

				item.LeftText.transform.rotation = new Quaternion(0, 0, 0, 0);
				item.LeftText.color = Color1;

				var times = item.CorrectRotate / Rotate;
				for (int i = 0; i < times; i++)
				{
					item.SetNumbers();
					item.SetTexts();
				}

				item.CorrectRotate = 0;
			}
		}

		public void CheckInitialMatchs()
		{
			foreach (var item in TileList)
			{
				CheckMatchs(item);
			}
		}

		private int GetRandomRotate()
		{
			var number = UnityEngine.Random.Range(0, 60000);
			if (number >= 0 && number <= 10000) return 1;
			if (number >= 10001 && number <= 20000) return 2;
			if (number >= 20001 && number <= 30000) return 3;
			if (number >= 30001 && number <= 40000) return 4;
			if (number >= 40001 && number <= 50000) return 5;
			return 6;
		}

		public void CheckMatchs(Hexagon tile)
		{
			//IncreaseMovements();

			var above1 = TileList.FirstOrDefault(t => t.x == tile.x - 1 && t.y == tile.y + 1);
			if (above1 == null)
			{
				tile.Top1Text.color = Color1;
			}
			else
			{
				var aboveMatch = Color1;
				if (tile.Top1 + above1.Bottom1 == 7) aboveMatch = ColorMatch;
				tile.Top1Text.color = aboveMatch;
				above1.Bottom1Text.color = aboveMatch;
			}

			var above2 = TileList.FirstOrDefault(t => t.x == tile.x + 1 && t.y == tile.y + 1);
			if (above2 == null)
			{
				tile.Top2Text.color = Color1;
			}
			else
			{
				var aboveMatch = Color1;
				if (tile.Top2 + above2.Bottom2 == 7) aboveMatch = ColorMatch;
				tile.Top2Text.color = aboveMatch;
				above2.Bottom2Text.color = aboveMatch;
			}

			var right = TileList.FirstOrDefault(t => t.x == tile.x + 2 && t.y == tile.y);
			if (right == null)
			{
				tile.RightText.color = Color1;
			}
			else
			{
				var rigthMatch = Color1;
				if (tile.Right + right.Left == 7) rigthMatch = ColorMatch;
				tile.RightText.color = rigthMatch;
				right.LeftText.color = rigthMatch;
			}

			var below1 = TileList.FirstOrDefault(t => t.x == tile.x + 1 && t.y == tile.y - 1);
			if (below1 == null)
			{
				tile.Bottom1Text.color = Color1;
			}
			else
			{
				var belowMatch = Color1;
				if (tile.Bottom1 + below1.Top1 == 7) belowMatch = ColorMatch;
				tile.Bottom1Text.color = belowMatch;
				below1.Top1Text.color = belowMatch;
			}

			var below2 = TileList.FirstOrDefault(t => t.x == tile.x - 1 && t.y == tile.y - 1);
			if (below2 == null)
			{
				tile.Bottom2Text.color = Color1;
			}
			else
			{
				var belowMatch = Color1;
				if (tile.Bottom2 + below2.Top2 == 7) belowMatch = ColorMatch;
				tile.Bottom2Text.color = belowMatch;
				below2.Top2Text.color = belowMatch;
			}

			var left = TileList.FirstOrDefault(t => t.x == tile.x - 2 && t.y == tile.y);
			if (left == null)
			{
				tile.LeftText.color = Color1;
			}
			else
			{
				var leftMatch = Color1;
				if (tile.Left + left.Right == 7) leftMatch = ColorMatch;
				tile.LeftText.color = leftMatch;
				left.RightText.color = leftMatch;
			}

			//CheckScore();
		}

		public void GetCode()
		{
			var levels = Directory.GetFiles(Application.dataPath + "/Scripts/Game/Levels/" + folder, "*.cs");
			var number = "000" + (levels.Length + HudManager.Instance.Minlevel);
			LevelNumber.text = number.Substring(number.Length - 3);

			CodeContent.transform.SetAsLastSibling();
			CodeContent.gameObject.SetActive(true);
			Code.text = "";

			var ThreePorcentage = 20;
			var TwoPorcentage = 45;

			var total = ThreeStarsLimit;
			ThreeStarsLimit = Mathf.Ceil(total + (total * ThreePorcentage / 100));
			TwoStarsLimit = Mathf.Ceil(total + (total * TwoPorcentage / 100));

			var text = new StringBuilder();
			text.AppendLine("using Assets.Scripts.Core;");
			text.AppendLine("using System.Collections.Generic;");
			text.AppendLine("");
			text.AppendLine("namespace Assets.Scripts.Game.Levels." + folder);
			text.AppendLine("{");
			text.AppendLine("	public abstract class Level" + LevelNumber.text);
			text.AppendLine("	{");
			text.AppendLine("		public static LevelHexagon GetLevel()");
			text.AppendLine("		{");
			text.AppendLine("			return new LevelHexagon");
			text.AppendLine("			{");
			text.AppendLine("				Number = "+ Convert.ToInt32(LevelNumber.text) + ",");
			text.AppendLine("				MatchsToWin = " + MatchsToWin + ",");
			text.AppendLine("				ThreeStarsLimit = " + ThreeStarsLimit + ",");
			text.AppendLine("				TwoStarsLimit = " + TwoStarsLimit + ",");
			text.AppendLine("				BlockWidth = " + BlockWidth + ",");
			text.AppendLine("				BlockHeight = " + BlockHeight + ",");
			text.AppendLine("				Blocks = new List<BlockHexagon>");
			text.AppendLine("				{");

			foreach (var item in TileList)
			{
				var posx = item.transform.localPosition.x;
				var fx = posx % 2 == 0 ? "" : "f";
				var posy = item.transform.localPosition.y;
				var fy = posy % 2 == 0 ? "" : "f";

				text.AppendLine("					new BlockHexagon { PosX = " + posx + fx + ", PosY = " + posy + fy + ", X = " + item.x + ", Y = " + item.y + ", Top1 = " + item.Top1 + ", Top2 = " + item.Top2 + ", Right = " + item.Right + ", Bottom1 = " + item.Bottom1 + ", Bottom2 = " + item.Bottom2 + ", Left = " + item.Left + ", CorrectRotate = " + item.CorrectRotate + " },");
			}

			text.AppendLine("				}");
			text.AppendLine("			};");
			text.AppendLine("		}");
			text.AppendLine("	}");
			text.Append("}");

			Code.text = text.ToString();
		}

		public void CloseCode()
		{
			CodeContent.gameObject.SetActive(false);
		}

		public void SaveCode()
		{
			var DataFile = string.Format(@"D:\desenv\games\SpinTo7\Assets\Scripts\Game\Levels\" + folder + @"\Level" + LevelNumber.text + ".cs");
			File.WriteAllText(DataFile, Code.text);
			CloseCode();
		}
	}
}