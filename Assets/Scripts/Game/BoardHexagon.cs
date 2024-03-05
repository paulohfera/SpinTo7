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
	public class BoardHexagon : MonoBehaviour, IBoard
	{
		private static BoardHexagon _instance;
		public static BoardHexagon Instance { get { return _instance; } }

		private Color Color1 = new Color32(0, 0, 0, 255);
		private Color ColorMatch = new Color32(255, 255, 255, 255);
		private int movementCount;
		private int LevelNumber;
		private List<Hexagon> Hexagons;
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

			Inithexagons();
		}

		private void Inithexagons()
		{
			Hexagons = new List<Hexagon>();

			var number = "000" + LevelNumber;
			var level = number.Substring(number.Length - 3);
			var type = Type.GetType(HudManager.Instance.Namespace + ".Level" + level);
			var levelConfig = (Core.LevelHexagon)type.InvokeMember("GetLevel", BindingFlags.InvokeMethod | BindingFlags.Public | BindingFlags.Static, null, null, null);

			MatchsToWin = levelConfig.MatchsToWin;
			ThreeStarsLimit = levelConfig.ThreeStarsLimit;
			TwoStarsLimit = levelConfig.TwoStarsLimit;

			var canvas = FindObjectOfType<Canvas>();
			for (int i = 0; i < levelConfig.Blocks.Count; i++)
			{
				var block = levelConfig.Blocks[i];
				var obj = Instantiate(Resources.Load("Hexagon_X_Y"), canvas.transform) as GameObject;
				obj.transform.localPosition = new Vector3(block.PosX, block.PosY);

				var rect = obj.GetComponent<RectTransform>();
				rect.sizeDelta = new Vector2(levelConfig.BlockWidth, levelConfig.BlockHeight);

				var hexagon = obj.GetComponent<Hexagon>();
				hexagon.x = block.X;
				hexagon.y = block.Y;
				hexagon.CorrectRotate = block.CorrectRotate;
				hexagon.Top1 = block.Top1;
				hexagon.Top2 = block.Top2;
				hexagon.Right = block.Right;
				hexagon.Bottom1 = block.Bottom1;
				hexagon.Bottom2 = block.Bottom2;
				hexagon.Left = block.Left;
				hexagon.Init();

				Hexagons.Add(hexagon);
			}

			levelConfig = null;
			type = null;
		}

		public void CheckInitialMatchs()
		{
			foreach (var item in Hexagons)
			{
				CheckMatchs(item, true);
			}
		}

		public void CheckMatchs(Hexagon hexagon)
		{
			CheckMatchs(hexagon, false);
		}
		public void CheckMatchs(Hexagon hexagon, bool initCheck)
		{
			if (!initCheck) IncreaseMovements();

			var above1 = Hexagons.FirstOrDefault(t => t.x == hexagon.x - 1 && t.y == hexagon.y + 1);
			if (above1 == null)
			{
				hexagon.Top1Text.color = Color1;
			}
			else
			{
				var aboveMatch = Color1;
				if (hexagon.Top1 + above1.Bottom1 == 7) aboveMatch = ColorMatch;
				hexagon.Top1Text.color = aboveMatch;
				above1.Bottom1Text.color = aboveMatch;
			}

			var above2 = Hexagons.FirstOrDefault(t => t.x == hexagon.x + 1 && t.y == hexagon.y + 1);
			if (above2 == null)
			{
				hexagon.Top2Text.color = Color1;
			}
			else
			{
				var aboveMatch = Color1;
				if (hexagon.Top2 + above2.Bottom2 == 7) aboveMatch = ColorMatch;
				hexagon.Top2Text.color = aboveMatch;
				above2.Bottom2Text.color = aboveMatch;
			}

			var right = Hexagons.FirstOrDefault(t => t.x == hexagon.x + 2 && t.y == hexagon.y);
			if (right == null)
			{
				hexagon.RightText.color = Color1;
			}
			else
			{
				var rigthMatch = Color1;
				if (hexagon.Right + right.Left == 7) rigthMatch = ColorMatch;
				hexagon.RightText.color = rigthMatch;
				right.LeftText.color = rigthMatch;
			}

			var below1 = Hexagons.FirstOrDefault(t => t.x == hexagon.x + 1 && t.y == hexagon.y - 1);
			if (below1 == null)
			{
				hexagon.Bottom1Text.color = Color1;
			}
			else
			{
				var belowMatch = Color1;
				if (hexagon.Bottom1 + below1.Top1 == 7) belowMatch = ColorMatch;
				hexagon.Bottom1Text.color = belowMatch;
				below1.Top1Text.color = belowMatch;
			}

			var below2 = Hexagons.FirstOrDefault(t => t.x == hexagon.x - 1 && t.y == hexagon.y - 1);
			if (below2 == null)
			{
				hexagon.Bottom2Text.color = Color1;
			}
			else
			{
				var belowMatch = Color1;
				if (hexagon.Bottom2 + below2.Top2 == 7) belowMatch = ColorMatch;
				hexagon.Bottom2Text.color = belowMatch;
				below2.Top2Text.color = belowMatch;
			}

			var left = Hexagons.FirstOrDefault(t => t.x == hexagon.x - 2 && t.y == hexagon.y);
			if (left == null)
			{
				hexagon.LeftText.color = Color1;
			}
			else
			{
				var leftMatch = Color1;
				if (hexagon.Left + left.Right == 7) leftMatch = ColorMatch;
				hexagon.LeftText.color = leftMatch;
				left.RightText.color = leftMatch;
			}

			CheckScore();
		}

		private void CheckScore()
		{
			var matchs = (from x in Hexagons from y in x.Numbers where y.color == ColorMatch select y).ToList().Count();
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

		public void OpenVideoReward()
		{
			SceneController.Instance.OpenVideoReward(this);
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

		private IEnumerator SolveBlock()
		{
			isRotating = true;

			yield return new WaitForSeconds(0.2f);

			for (int i = 0; i < Hexagons.Count; i++)
			{
				if (Hexagons[i].IsCorrect()) continue;

				while (!Hexagons[i].IsCorrect())
				{
#if UNITY_EDITOR
					StartCoroutine(Hexagons[i].Rotate(60, 0));
					yield return new WaitForSeconds(0.05f);
#else
					StartCoroutine(Hexagons[i].Rotate(60, 0.2f));
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