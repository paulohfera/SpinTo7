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
	public class BoardGenerator : MonoBehaviour
	{
		private static BoardGenerator _instance;
		public static BoardGenerator Instance { get { return _instance; } }

		private Color Color1 = new Color32(0, 0, 0, 255);
		private Color ColorMatch = new Color32(255, 255, 255, 255);
		private List<Tile> TileList;
		private List<Axis> Axes;
		private Canvas canvas;
		private int Tiles = 0;
		private int MatchsToWin = 0;
		private float ThreeStarsLimit = 0;
		private float TwoStarsLimit = 0;
		private string folder = "Easy";

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
			if (Difficulty == Difficulty.Moderate) folder = "Moderate";
			if (Difficulty == Difficulty.Hard) folder = "Hard";

			TileList = new List<Tile>();
			BlockSize = 130;

			canvas = FindObjectOfType<Canvas>();
			var obj0 = Instantiate(Resources.Load("Tile_X_Y"), canvas.transform) as GameObject;
			AddTile(obj0, 0, 0);
			GetPossibleAxes();

			while (Tiles < Quantity)
			{
				var rnd = new System.Random();
				var next = Axes.OrderBy(o => rnd.Next()).First();

				var obj = Instantiate(Resources.Load("Tile_X_Y"), canvas.transform) as GameObject;
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
			var tile = obj.GetComponent<Tile>();
			tile.x = x;
			tile.y = y;
			tile.Top = Tiles;
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
			MatchsToWin = 0;
			ResetRotate();

			foreach (var item in TileList)
			{
				item.HasNumbers = false;
			}

			foreach (var item in TileList)
			{
				var above = TileList.FirstOrDefault(t => t.x == item.x && t.y == item.y + 1 && t.HasNumbers);
				if (above == null)
					item.Top = GetRandomNumber();
				else
				{
					item.Top = 7 - above.Bottom;
					MatchsToWin++;
				}


				var right = TileList.FirstOrDefault(t => t.x == item.x + 1 && t.y == item.y && t.HasNumbers);
				if (right == null)
					item.Right = GetRandomNumber();
				else
				{
					item.Right = 7 - right.Left;
					MatchsToWin++;
				}


				var below = TileList.FirstOrDefault(t => t.x == item.x && t.y == item.y - 1 && t.HasNumbers);
				if (below == null)
					item.Bottom = GetRandomNumber();
				else
				{
					item.Bottom = 7 - below.Top;
					MatchsToWin++;
				}


				var left = TileList.FirstOrDefault(t => t.x == item.x - 1 && t.y == item.y && t.HasNumbers);
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
			if (Difficulty == Difficulty.Easy)
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
			else
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

		private void RotateTile(Tile item, int times)
		{
			var rotate = times * 90;

			iTween.RotateTo(item.transform.gameObject, new Vector3(0, 0, rotate), 0);

			item.TopText.transform.Rotate(new Vector3(0, 0, -rotate));
			item.TopText.color = Color1;

			item.RightText.transform.Rotate(new Vector3(0, 0, -rotate));
			item.RightText.color = Color1;

			item.BottomText.transform.Rotate(new Vector3(0, 0, -rotate));
			item.BottomText.color = Color1;

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

				item.TopText.transform.rotation = new Quaternion(0, 0, 0, 0);
				item.TopText.color = Color1;

				item.RightText.transform.rotation = new Quaternion(0, 0, 0, 0);
				item.RightText.color = Color1;

				item.BottomText.transform.rotation = new Quaternion(0, 0, 0, 0);
				item.BottomText.color = Color1;

				item.LeftText.transform.rotation = new Quaternion(0, 0, 0, 0);
				item.LeftText.color = Color1;

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
				CheckMatchs(item);
			}
		}

		private int GetRandomRotate()
		{
			var number = UnityEngine.Random.Range(0, 30000);
			if (number >= 0 && number <= 10000) return 1;
			if (number >= 10001 && number <= 20000) return 2;
			return 3;
		}

		public void CheckMatchs(Tile tile)
		{
			//IncreaseMovements();

			var above = TileList.FirstOrDefault(t => t.x == tile.x && t.y == tile.y + 1);
			if (above == null)
			{
				tile.TopText.color = Color1;
			}
			else
			{
				var aboveMatch = Color1;
				if (tile.Top + above.Bottom == 7) aboveMatch = ColorMatch;
				tile.TopText.color = aboveMatch;
				above.BottomText.color = aboveMatch;
			}

			var right = TileList.FirstOrDefault(t => t.x == tile.x + 1 && t.y == tile.y);
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

			var below = TileList.FirstOrDefault(t => t.x == tile.x && t.y == tile.y - 1);
			if (below == null)
			{
				tile.BottomText.color = Color1;
			}
			else
			{
				var belowMatch = Color1;
				if (tile.Bottom + below.Top == 7) belowMatch = ColorMatch;
				tile.BottomText.color = belowMatch;
				below.TopText.color = belowMatch;
			}

			var left = TileList.FirstOrDefault(t => t.x == tile.x - 1 && t.y == tile.y);
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

			if (Difficulty == Difficulty.Easy)
			{
				ThreePorcentage = ThreePorcentage + 10;
				TwoPorcentage = TwoPorcentage + 10;
			}

			if (Difficulty == Difficulty.Moderate)
			{
				ThreePorcentage = ThreePorcentage + 5;
				TwoPorcentage = TwoPorcentage + 5;
			}

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
			text.AppendLine("		public static Level GetLevel()");
			text.AppendLine("		{");
			text.AppendLine("			return new Level");
			text.AppendLine("			{");
			text.AppendLine("				Number = "+ Convert.ToInt32(LevelNumber.text) + ",");
			text.AppendLine("				MatchsToWin = " + MatchsToWin + ",");
			text.AppendLine("				ThreeStarsLimit = " + ThreeStarsLimit + ",");
			text.AppendLine("				TwoStarsLimit = " + TwoStarsLimit + ",");
			text.AppendLine("				BlockSizes = " + BlockSize + ",");
			text.AppendLine("				Blocks = new List<Block>");
			text.AppendLine("				{");

			foreach (var item in TileList)
			{
				var posx = item.transform.localPosition.x;
				var posy = item.transform.localPosition.y;

				text.AppendLine("					new Block { PosX = " + posx + ", PosY = " + posy + ", X = "+ item.x + ", Y = " + item.y + ", Top = " + item.Top + ", Right = " + item.Right + ", Bottom = " + item.Bottom + ", Left = " + item.Left + ", CorrectRotate = " + item.CorrectRotate + " },");
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