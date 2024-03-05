using Assets.Scripts.Core;
using Assets.Scripts.Core.Interfaces;
using Assets.Scripts.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Game
{
	public class Board : MonoBehaviour, IBoard
	{
		private static Board _instance;
		public static Board Instance { get { return _instance; } }

		private Color Color1 = new Color32(0, 0, 0, 255);
		private Color ColorMatch = new Color32(255, 255, 255, 255);
		private int movementCount;
		private int LevelNumber;
		private List<Tile> Tiles;
		private int MatchsToWin;
		private int ThreeStarsLimit;
		private int TwoStarsLimit;
		private bool isRotating;
		private DateTime BeginTime;

		public Text LevelText;
		public Text Movements;
		public Text Help;
		public Text Score;
		public int LevelToDebug;
		public bool SuppressModalLevl;
		public GameObject EarnIcon;

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

			InitScene();
			if (HudManager.Instance.Difficulty == Difficulty.Hard) ColorMatch = new Color32(0, 0, 0, 254); ;
			CheckInitialMatchs();
			BeginTime = DateTime.Now;
		}

		private void InitScene()
		{
			if (HudManager.Instance != null)
				LevelNumber = HudManager.Instance.GameLevel;

#if UNITY_EDITOR
			if (LevelToDebug > 0 && HudManager.Instance.GameLevel == 0)
			{
				LevelNumber = LevelToDebug;
				HudManager.Instance.GameLevel = LevelToDebug;
			}
#endif

			LevelText.text = "Level " + LevelNumber;

			var user = HudManager.Instance.UserData;
			Help.text = user.HasDonated ? "∞" : user.HelpLeft.ToString();
			if (user.HasDonated) EarnIcon.SetActive(false);

			InitTiles();
		}

		private void InitTiles()
		{
			Tiles = new List<Tile>();

			var number = "000" + LevelNumber;
			var level = number.Substring(number.Length - 3);
			var type = Type.GetType(HudManager.Instance.Namespace + ".Level" + level);
			var levelConfig = (Core.Level)type.InvokeMember("GetLevel", BindingFlags.InvokeMethod | BindingFlags.Public | BindingFlags.Static, null, null, null);

			MatchsToWin = levelConfig.MatchsToWin;
			ThreeStarsLimit = levelConfig.ThreeStarsLimit;
			TwoStarsLimit = levelConfig.TwoStarsLimit;

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
				tile.Init();

				Tiles.Add(tile);
			}

			levelConfig = null;
			type = null;
		}

		public void CheckInitialMatchs()
		{
			foreach (var item in Tiles)
			{
				CheckMatchs(item, true);
			}
		}

		public void CheckMatchs(Tile tile)
		{
			CheckMatchs(tile, false);
		}
		public void CheckMatchs(Tile tile, bool initCheck)
		{
			if (!initCheck) IncreaseMovements();

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

			if (score >= MatchsToWin)
			{
				var stars = 1;
				if (movementCount <= TwoStarsLimit) stars = 2;
				if (movementCount <= ThreeStarsLimit) stars = 3;

#if UNITY_EDITOR
				if (SuppressModalLevl) return;
#endif

				if (SoundController.Instance)
					SoundController.Instance.PlayAudio(Const.Music.Win);
				SceneController.Instance.OpenModalLevel(movementCount, stars, BeginTime);
				HudManager.Instance.UserData.SaveLevel(LevelNumber, stars);
				Database.Save(HudManager.Instance.UserData);
			}
		}

		public void IncreaseMovements()
		{
			movementCount++;
			Movements.text = movementCount.ToString();
		}

		public void OnHelpClik()
		{
			if (isRotating) return;

			var user = HudManager.Instance.UserData;
			if (!user.HasDonated)
			{
				if (user.HelpLeft <= 0)
				{
					SceneController.Instance.OpenModalHelp(this);
					return;
				}

				user.HelpLeft--;
				Help.text = user.HelpLeft.ToString();
				Database.Save(user);
			}

			StartCoroutine(SolveBlock());
		}

		public void OpenVideoReward()
		{
			SceneController.Instance.OpenVideoReward(this);
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
#if UNITY_EDITOR
					StartCoroutine(Tiles[i].Rotate(90, 0));
					yield return new WaitForSeconds(0.05f);
#else
					StartCoroutine(Tiles[i].Rotate(90, 0.2f));
					yield return new WaitForSeconds(0.6f);
#endif
				}

				break;
			}

			var score = Convert.ToInt32(Score.text);
			if (score < MatchsToWin)
			{
				StartCoroutine(SolveBlock());
			}

			isRotating = false;
			yield return 0;
		}

		public void SetHelp(int h)
		{
			Help.text = h.ToString();
		}
	}
}