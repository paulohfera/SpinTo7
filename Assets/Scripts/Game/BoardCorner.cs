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
	public class BoardCorner : MonoBehaviour, IBoard
	{
		private static BoardCorner _instance;
		public static BoardCorner Instance { get { return _instance; } }

		private Color Color1 = new Color32(0, 0, 0, 255);
		private Color ColorMatch1 = new Color32(0, 0, 0, 254);
		private Color ColorMatch2 = new Color32(255, 255, 255, 255);
		private int movementCount;
		private int LevelNumber;
		private List<TileCorner> TileList;
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
			TileList = new List<TileCorner>();

			var number = "000" + LevelNumber;
			var level = number.Substring(number.Length - 3);
			var type = Type.GetType(HudManager.Instance.Namespace + ".Level" + level);
			var levelConfig = (LevelCorner)type.InvokeMember("GetLevel", BindingFlags.InvokeMethod | BindingFlags.Public | BindingFlags.Static, null, null, null);

			MatchsToWin = levelConfig.MatchsToWin;
			ThreeStarsLimit = levelConfig.ThreeStarsLimit;
			TwoStarsLimit = levelConfig.TwoStarsLimit;

			var canvas = FindObjectOfType<Canvas>();
			for (int i = 0; i < levelConfig.Blocks.Count; i++)
			{
				var block = levelConfig.Blocks[i];
				var tileName = "TileCorner_X_Y";
				var obj = Instantiate(Resources.Load(tileName), canvas.transform) as GameObject;
				obj.transform.localPosition = new Vector3(block.PosX, block.PosY);

				var rect = obj.GetComponent<RectTransform>();
				rect.sizeDelta = new Vector2(levelConfig.BlockSizes, levelConfig.BlockSizes);

				var tile = obj.GetComponent<TileCorner>();
				tile.x = block.X;
				tile.y = block.Y;
				tile.CorrectRotate = block.CorrectRotate;
				tile.Corner1 = block.Corner1;
				tile.Corner2 = block.Corner2;
				tile.Corner3 = block.Corner3;
				tile.Corner4 = block.Corner4;
				tile.Init();

				TileList.Add(tile);
			}

			levelConfig = null;
			type = null;
		}

		public void CheckInitialMatchs()
		{
			foreach (var item in TileList)
			{
				CheckMatchs(item, true, true);
			}
		}

		public void CheckMatchs(TileCorner tile, bool initCheck, bool checkSides)
		{
			if (!initCheck) IncreaseMovements();

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
				if (above != null) CheckMatchs(above, true, false);
				if (right != null) CheckMatchs(right, true, false);
				if (below != null) CheckMatchs(below, true, false);
				if (left != null) CheckMatchs(left, true, false);
			}

			CheckScore();
		}

		private void SetTextColor(Text text)
		{
			if (text.color == ColorMatch1) text.color = ColorMatch2;
			if (text.color == Color1) text.color = ColorMatch1;
		}

		private void CheckScore()
		{
			var score = (from x in TileList from y in x.Numbers where y.color == ColorMatch2 select y).ToList().Count();
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

			for (int i = 0; i < TileList.Count; i++)
			{
				if (TileList[i].IsCorrect()) continue;

				while (!TileList[i].IsCorrect())
				{
#if UNITY_EDITOR
					StartCoroutine(TileList[i].Rotate(90, 0));
					yield return new WaitForSeconds(0.05f);
#else
					StartCoroutine(TileList[i].Rotate(90, 0.2f));
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