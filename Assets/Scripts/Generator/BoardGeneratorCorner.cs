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
	public class BoardGeneratorCorner : MonoBehaviour
	{
		private static BoardGeneratorCorner _instance;
		public static BoardGeneratorCorner Instance { get { return _instance; } }

		private Color Color1 = new Color32(0, 0, 0, 255);
		private Color ColorMatch1 = new Color32(0, 0, 0, 254);
		private Color ColorMatch2 = new Color32(255, 255, 255, 255);
		private List<TileCorner> TileList;
		private List<Axis> Axes;
		private Canvas canvas;
		private int Tiles = 0;
		private int MatchsToWin = 0;
		private float ThreeStarsLimit = 0;
		private float TwoStarsLimit = 0;
		private string folder = "Corner";

		public int Quantity;
		public int BlockSize = 130;
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

			TileList = new List<TileCorner>();
			BlockSize = 130;

			canvas = FindObjectOfType<Canvas>();
			var obj0 = Instantiate(Resources.Load("TileCorner_X_Y"), canvas.transform) as GameObject;
			AddTile(obj0, 0, 0);
			GetPossibleAxes();

			while (Tiles < Quantity)
			{
				var rnd = new System.Random();
				var next = Axes.OrderBy(o => rnd.Next()).First();

				var obj = Instantiate(Resources.Load("TileCorner_X_Y"), canvas.transform) as GameObject;
				AddTile(obj, next.X, next.Y);
				GetPossibleAxes();
			}

			DistributeTiles();
			FillTileNumbers();
			CheckInitialMatchs();
			MatchsToWin = (from x in TileList from y in x.Numbers where y.color == ColorMatch2 select y).ToList().Count();
		}

		private void DistributeTiles()
		{
			var maxX = TileList.Max(t => t.x);
			var minX = TileList.Min(t => t.x);
			var x = maxX - minX + 1;
			if (x > 5) BlockSize = 130 - ((x - 5) * 15);

			var maxY = TileList.Max(t => t.y);
			var minY = TileList.Min(t => t.y);
			var y = maxY - minY + 1;
			if (y > 8) BlockSize = 130 - ((y - 8) * 20);

			var halfX = Mathf.Floor(x / 2);
			var diffX = (halfX - maxX) * BlockSize;
			if (x % 2 == 0) diffX = diffX - BlockSize / 2;

			var halfY = Mathf.Floor(y / 2);
			var diffY = (halfY - maxY) * BlockSize;
			if (y % 2 == 0) diffY = diffY - BlockSize / 2;

			foreach (var item in TileList)
			{
				var rect = item.GetComponent<RectTransform>();
				rect.sizeDelta = new Vector2(BlockSize, BlockSize);

				item.transform.localPosition = new Vector3(diffX + (item.x * BlockSize), diffY + (item.y * BlockSize));
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
			var tile = obj.GetComponent<TileCorner>();
			tile.x = x;
			tile.y = y;
			//tile.Corner1 = Tiles;
			TileList.Add(tile);

			Tiles++;
		}

		private void GetPossibleAxes()
		{
			Axes = new List<Axis>();

			foreach (var item in TileList)
			{
				var above = TileList.FirstOrDefault(t => t.x == item.x && t.y == item.y + 1);
				if (above == null) Axes.Add(new Axis { X = item.x, Y = item.y + 1 });

				var right = TileList.FirstOrDefault(t => t.x == item.x + 1 && t.y == item.y);
				if (right == null) Axes.Add(new Axis { X = item.x + 1, Y = item.y });

				var below = TileList.FirstOrDefault(t => t.x == item.x && t.y == item.y - 1);
				if (below == null) Axes.Add(new Axis { X = item.x, Y = item.y - 1 });

				var left = TileList.FirstOrDefault(t => t.x == item.x - 1 && t.y == item.y);
				if (left == null) Axes.Add(new Axis { X = item.x - 1, Y = item.y });
			}
		}

		public void FillTileNumbers()
		{
			//MatchsToWin = 0;
			ResetRotate();

			foreach (var item in TileList)
			{
				item.HasNumbers = false;
			}

			foreach (var item in TileList)
			{
				var above = TileList.FirstOrDefault(t => t.x == item.x && t.y == item.y + 1 && t.HasNumbers);
				var right = TileList.FirstOrDefault(t => t.x == item.x + 1 && t.y == item.y && t.HasNumbers);
				var below = TileList.FirstOrDefault(t => t.x == item.x && t.y == item.y - 1 && t.HasNumbers);
				var left = TileList.FirstOrDefault(t => t.x == item.x - 1 && t.y == item.y && t.HasNumbers);


				if (above == null && left == null)
				{
					item.Corner1 = GetRandomNumber();
				}
				else
				{
					if (above == null)
						item.Corner1 = 7 - left.Corner2;
					else
						item.Corner1 = 7 - above.Corner4;
				}


				if (above == null && right == null)
				{
					item.Corner2 = GetRandomNumber();
				}
				else
				{
					if (above == null)
						item.Corner2 = 7 - right.Corner1;
					else
						item.Corner2 = 7 - above.Corner3;
				}


				if (right == null && below == null)
				{
					item.Corner3 = GetRandomNumber();
				}
				else
				{
					if (right == null)
						item.Corner3 = 7 - below.Corner2;
					else
						item.Corner3 = 7 - right.Corner4;
				}


				if (below == null && left == null)
				{
					item.Corner4 = GetRandomNumber();
				}
				else
				{
					if (below == null)
						item.Corner4 = 7 - left.Corner3;
					else
						item.Corner4 = 7 - below.Corner1;
				}

				item.HasNumbers = true;
				item.Init();
			}
		}

		private int GetRandomNumber()
		{
			var number = UnityEngine.Random.Range(0, 120000);
			if (number >= 0 && number <= 10000) return -2;
			if (number >= 10001 && number <= 20000) return -1;
			if (number >= 20001 && number <= 30000) return 0;
			if (number >= 30001 && number <= 40000) return 1;
			if (number >= 40001 && number <= 50000) return 2;
			if (number >= 50001 && number <= 60000) return 3;
			if (number >= 60001 && number <= 70000) return 4;
			if (number >= 60001 && number <= 80000) return 5;
			if (number >= 60001 && number <= 90000) return 6;
			if (number >= 60001 && number <= 100000) return 7;
			if (number >= 60001 && number <= 110000) return 8;
			return 9;
		}

		public void RotateTiles()
		{
			ThreeStarsLimit = 0;
			TwoStarsLimit = 0;
			ResetRotate();

			foreach (var item in TileList)
			{
				var timesToReset = item.CorrectRotate / 90;
				if (timesToReset > 0)
				{
					RotateTile(item, timesToReset);
					item.CorrectRotate = 0;
				}

				var times = GetRandomRotate();
				if (times == 0) continue;

				RotateTile(item, times);

				item.CorrectRotate = 360 - (times * 90);

				ThreeStarsLimit = ThreeStarsLimit + (item.CorrectRotate / 90);
			}

			CheckInitialMatchs();
		}

		private void RotateTile(TileCorner item, int times)
		{
			var rotate = times * 90;

			iTween.RotateTo(item.transform.gameObject, new Vector3(0, 0, rotate), 0);

			item.Corner1Text.transform.Rotate(new Vector3(0, 0, -rotate));
			item.Corner1Text.color = Color1;

			item.Corner2Text.transform.Rotate(new Vector3(0, 0, -rotate));
			item.Corner2Text.color = Color1;

			item.Corner3Text.transform.Rotate(new Vector3(0, 0, -rotate));
			item.Corner3Text.color = Color1;

			item.Corner4Text.transform.Rotate(new Vector3(0, 0, -rotate));
			item.Corner4Text.color = Color1;

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

				item.Corner1Text.transform.rotation = new Quaternion(0, 0, 0, 0);
				item.Corner1Text.color = Color1;

				item.Corner2Text.transform.rotation = new Quaternion(0, 0, 0, 0);
				item.Corner2Text.color = Color1;

				item.Corner3Text.transform.rotation = new Quaternion(0, 0, 0, 0);
				item.Corner3Text.color = Color1;

				item.Corner4Text.transform.rotation = new Quaternion(0, 0, 0, 0);
				item.Corner4Text.color = Color1;

				var times = item.CorrectRotate / 90;
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
				CheckMatchs(item, true);
			}
		}

		private int GetRandomRotate()
		{
			var number = UnityEngine.Random.Range(0, 30000);
			if (number >= 0 && number <= 10000) return 1;
			if (number >= 10001 && number <= 20000) return 2;
			return 3;
		}

		public void CheckMatchs(TileCorner tile, bool checkSides)
		{
			var above = TileList.FirstOrDefault(t => t.x == tile.x && t.y == tile.y + 1);
			var right = TileList.FirstOrDefault(t => t.x == tile.x + 1 && t.y == tile.y);
			var below = TileList.FirstOrDefault(t => t.x == tile.x && t.y == tile.y - 1);
			var left = TileList.FirstOrDefault(t => t.x == tile.x - 1 && t.y == tile.y);

			tile.Corner1Text.color = Color1;
			if (above == null || left == null)
				tile.Corner1Text.color = ColorMatch1;

			if (above != null && tile.Corner1 + above.Corner4 == 7)
				SetTextColor(tile.Corner1Text);

			if (left != null && tile.Corner1 + left.Corner2 == 7)
				SetTextColor(tile.Corner1Text);


			tile.Corner2Text.color = Color1;
			if (above == null || right == null)
				tile.Corner2Text.color = ColorMatch1;

			if (above != null && tile.Corner2 + above.Corner3 == 7)
				SetTextColor(tile.Corner2Text);

			if (right != null && tile.Corner2 + right.Corner1 == 7)
				SetTextColor(tile.Corner2Text);


			tile.Corner3Text.color = Color1;
			if (right == null || below == null)
				tile.Corner3Text.color = ColorMatch1;

			if (right != null && tile.Corner3 + right.Corner4 == 7)
				SetTextColor(tile.Corner3Text);

			if (below != null && tile.Corner3 + below.Corner2 == 7)
				SetTextColor(tile.Corner3Text);


			tile.Corner4Text.color = Color1;
			if (below == null || left == null)
				tile.Corner4Text.color = ColorMatch1;

			if (below != null && tile.Corner4 + below.Corner1 == 7)
				SetTextColor(tile.Corner4Text);

			if (left != null && tile.Corner4 + left.Corner3 == 7)
				SetTextColor(tile.Corner4Text);

			if (checkSides)
			{
				if (above != null) CheckMatchs(above, false);
				if (right != null) CheckMatchs(right, false);
				if (below != null) CheckMatchs(below, false);
				if (left != null) CheckMatchs(left, false);
			}
		}

		private void SetTextColor(Text text)
		{
			if (text.color == Color1)
				text.color = ColorMatch1;
			else
				text.color = ColorMatch2;
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
			text.AppendLine("		public static LevelCorner GetLevel()");
			text.AppendLine("		{");
			text.AppendLine("			return new LevelCorner");
			text.AppendLine("			{");
			text.AppendLine("				Number = "+ Convert.ToInt32(LevelNumber.text) + ",");
			text.AppendLine("				MatchsToWin = " + MatchsToWin + ",");
			text.AppendLine("				ThreeStarsLimit = " + ThreeStarsLimit + ",");
			text.AppendLine("				TwoStarsLimit = " + TwoStarsLimit + ",");
			text.AppendLine("				BlockSizes = " + BlockSize + ",");
			text.AppendLine("				Blocks = new List<BlockCorner>");
			text.AppendLine("				{");

			foreach (var item in TileList)
			{
				var posx = item.transform.localPosition.x;
				var posy = item.transform.localPosition.y;

				text.AppendLine("					new BlockCorner { PosX = " + posx + ", PosY = " + posy + ", X = "+ item.x + ", Y = " + item.y + ", Corner1 = " + item.Corner1 + ", Corner2 = " + item.Corner2 + ", Corner3 = " + item.Corner3 + ", Corner4 = " + item.Corner4 + ", CorrectRotate = " + item.CorrectRotate + " },");
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