using Assets.Scripts.Core;
using Assets.Scripts.Core.Interfaces;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.Scripts.Game
{
	public class ModalLevel : ModalHelper, IModal
	{
		public ModalFinish ModalFinish;
		private Transform Modal;
		private Transform Panel;
		private Text Movements;
		private Text Time;

		public void Start()
		{
			Modal = gameObject.transform.Find("ModalContent");
			Panel = gameObject.transform.Find("ModalContent/Panel");
			Movements = Modal.FindText("Movements");
			Time = Modal.FindText("Time");
		}

		public void Show(int movements, int stars, DateTime beginTime)
		{
			var elapsed = DateTime.Now.Subtract(beginTime);
			var elapsedText = string.Format("{0:00}:{1:00}:{2:00}", elapsed.Hours, elapsed.Minutes, elapsed.Seconds);

			if (HudManager.Instance.UserData.Language == SystemLanguage.Portuguese)
			{
				Movements.text = string.Format("Movimentos {0}", movements);
				Time.text = string.Format("Tempo: {0}", elapsedText);
			}
			else
			{
				Movements.text = string.Format("Movements {0}", movements);
				Time.text = string.Format("Time: {0}", elapsedText);
			}

			if (BackgroundMusic.Instance)
				BackgroundMusic.Instance.Pause();
			gameObject.transform.SetAsLastSibling();
			Panel.localPosition = new Vector3(0, 860, 0);
			Modal.gameObject.SetActive(true);
			StartCoroutine(DoShow(stars));
		}

		IEnumerator DoShow(int stars)
		{
			yield return StartCoroutine(ShowModal(Panel));
			StartCoroutine(ShowStars(stars));
		}

		public void Close() { }

		private IEnumerator ShowStars(int stars)
		{
			var star1 = Panel.FindImage("Star1");
			StartCoroutine(ShowStar(star1));

			if (stars >= 2)
			{
				yield return new WaitForSeconds(0.4f);
				var star2 = Panel.FindImage("Star2");
				StartCoroutine(ShowStar(star2));
			}

			if (stars >= 3)
			{
				yield return new WaitForSeconds(0.4f);
				var star3 = Panel.FindImage("Star3");
				StartCoroutine(ShowStar(star3));
			}
		}

		public void NextScene()
		{
			var actuallevel = HudManager.Instance.GameLevel;
			if (actuallevel == 100)
			{
				HudManager.Instance.Difficulty = Difficulty.Moderate;
			}

			if (actuallevel == 200)
			{
				HudManager.Instance.Difficulty = Difficulty.Hard;
			}

			if (actuallevel == 300)
			{
				StartCoroutine(CloseAndOpenHexagon());
				return;
			}

			if (actuallevel == 400)
			{
				StartCoroutine(CloseAndOpenFinish());
				return;
			}

			AdManager.Instance.ShowAdIfShould();
			StartCoroutine(CloseAndOpenNextLevel());
		}

		public IEnumerator CloseAndOpenNextLevel()
		{
			yield return StartCoroutine(HideModal(Panel));

			HudManager.Instance.GameLevel++;

			var scene = SceneManager.GetActiveScene();
			SceneManager.LoadScene(scene.name);
		}

		public IEnumerator CloseAndOpenFinish()
		{
			yield return StartCoroutine(HideModal(Panel));
			ModalFinish.Show();
		}

		public IEnumerator CloseAndOpenHexagon()
		{
			HudManager.Instance.Difficulty = Difficulty.Hard;
			HudManager.Instance.GameLevel++;

			yield return StartCoroutine(HideModal(Panel));
			SceneManager.LoadScene("GameHexagon");
		}

		public void Map()
		{
			AdManager.Instance.ShowAdIfShould();
			StartCoroutine(CloseAndOpenMap());
		}

		public IEnumerator CloseAndOpenMap()
		{
			yield return StartCoroutine(HideModal(Panel));
			SceneManager.LoadScene("Map");
		}
	}
}