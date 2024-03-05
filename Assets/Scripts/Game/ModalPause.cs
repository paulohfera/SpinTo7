using Assets.Scripts.Core;
using Assets.Scripts.Core.Interfaces;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.Scripts.Game
{
	public class ModalPause : ModalHelper, IModal
	{
		private Transform Modal;
		private Transform Panel;

		public Toggle Music;
		public Toggle Effects;

		private void Start()
		{
			Modal = gameObject.transform.Find("ModalContent");
			Panel = gameObject.transform.Find("ModalContent/Panel");
		}

		public void Show()
		{
			if (BackgroundMusic.Instance != null)
			{
				BackgroundMusic.Instance.Pause();
				Music.isOn = !BackgroundMusic.Instance.IsPaused || !BackgroundMusic.Instance.StopAtAll;
			}

			if (SoundController.Instance != null)
				Effects.isOn = !SoundController.Instance.StopAtAll;

			gameObject.transform.SetAsLastSibling();
			Panel.localPosition = new Vector3(0, 860, 0);
			Modal.gameObject.SetActive(true);
			StartCoroutine(DoShow());
		}

		private IEnumerator DoShow()
		{
			yield return StartCoroutine(ShowModal(Panel));
		}

		public void ToggleMusic(bool isOn)
		{
			if (isOn && BackgroundMusic.Instance != null)
				BackgroundMusic.Instance.UnStopAndPlay();

			if (!isOn && BackgroundMusic.Instance != null)
				BackgroundMusic.Instance.Stop();
		}

		public void ToggleEffects(bool isOn)
		{
			if (isOn) SoundController.Instance.UnStop();
			if (!isOn) SoundController.Instance.Stop();
		}

		public void Menu()
		{
			AdManager.Instance.ShowAdIfShould();
			StartCoroutine(CloseAndMenu());
		}

		public void Close()
		{
			StartCoroutine(DoClose());
		}

		public IEnumerator DoClose()
		{
			yield return StartCoroutine(HideModal(Panel));
			Modal.gameObject.SetActive(false);
			if (BackgroundMusic.Instance != null)
				BackgroundMusic.Instance.Play();
		}

		public IEnumerator CloseAndMenu()
		{
			yield return DoClose();
			SceneManager.LoadScene("Main", LoadSceneMode.Single);
		}
	}
}