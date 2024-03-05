using Assets.Scripts.Game;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Tutorial
{
	public class BoardTutorial : MonoBehaviour
	{
		private static BoardTutorial _instance;
		public static BoardTutorial Instance { get { return _instance; } }

		private Color Color1 = new Color32(0, 0, 0, 255);
		private Color ColorMatch = new Color32(255, 255, 255, 255);
		private int movementCount;
		private List<Tile> Tiles;

		public int Level;
		public int MatchsToWin;
		public Text Movements;
		public Text Help;
		public Text Score;
		private bool isRotating;

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

			InitScene();
		}

		private void InitScene()
		{
			Level = PlayerPrefs.GetInt("tutorialLevel");
			InitTiles();
		}

		private void InitTiles()
		{
			Tiles = new List<Tile>();

			var levelConfig = new LevelConfigurationTutorial().Levels.FirstOrDefault(x => x.Number == Level);
			MatchsToWin = levelConfig.MatchsToWin;

			var canvas = FindObjectOfType<Canvas>();
			for (int i = 0; i < levelConfig.Blocks.Count; i++)
			{
				var block = levelConfig.Blocks[i];
				var tileName = block.Fixed ? "Tile_Fixed_X_Y" : "Tile_X_Y";
				var obj = Instantiate(Resources.Load(tileName), canvas.transform) as GameObject;
				obj.transform.localPosition = new Vector3(block.PosX, block.PosY);

				var rect = obj.GetComponent<RectTransform>();
				rect.sizeDelta = new Vector2(levelConfig.BlockSizes, levelConfig.BlockSizes);

				var tile = obj.GetComponent<Tile>();
				tile.x = block.X;
				tile.y = block.Y;
				tile.CorrectRotate = block.CorrectRotate;
				tile.Top = block.Top;
				tile.Right = block.Right;
				tile.Bottom = block.Bottom;
				tile.Left = block.Left;
				tile.Fixed = block.Fixed;
				tile.Init();

				Tiles.Add(tile);
			}
		}

		public void CheckMatchs(Tile tile)
		{
			IncreaseMovements();

			var above = Tiles.FirstOrDefault(t => t.x == tile.x && t.y == tile.y + 1);
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

			var right = Tiles.FirstOrDefault(t => t.x == tile.x + 1 && t.y == tile.y);
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

			var below = Tiles.FirstOrDefault(t => t.x == tile.x && t.y == tile.y - 1);
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

			var left = Tiles.FirstOrDefault(t => t.x == tile.x - 1 && t.y == tile.y);
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

			CheckScore();
		}

		private void CheckScore()
		{
			var matchs = (from x in Tiles from y in x.Numbers where y.color == ColorMatch select y).ToList().Count();
			var score = matchs / 2;
			Score.text = score.ToString();

			if (score >= MatchsToWin && Level == 1)
				SceneController.Instance.ShowTutorial1();

			if (score == 1 && Level == 2)
				SceneController.Instance.ShowTutorial2_1();

			if (score >= MatchsToWin && Level == 2)
				SceneController.Instance.ShowTutorial2_2();

			if (score >= MatchsToWin && Level == 3)
				SceneController.Instance.ShowTutorial3();
		}

		public void IncreaseMovements()
		{
			movementCount++;
			Movements.text = movementCount.ToString();
		}

		public void OnHelpClik()
		{
			if (isRotating) return;

			Help.text = "0";
			StartCoroutine(SolveBlock());
		}

		private IEnumerator SolveBlock()
		{
			isRotating = true;

			yield return new WaitForSeconds(0.2f);

			for (int i = 0; i < Tiles.Count; i++)
			{
				if (Tiles[i].IsCorrect()) continue;

				while (!Tiles[i].IsCorrect())
				{
					StartCoroutine(Tiles[i].Rotate(90, 0.2f));
					yield return new WaitForSeconds(0.6f);
				}

				break;
			}

			isRotating = false;
			yield return 0;
		}
	}
}