using Assets.Scripts.Core;
using Assets.Scripts.Core.Interfaces;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Main
{
	public class ModalSound : ModalHelper, IModal
	{
		private Transform Modal;
		private Transform Panel;

		private void Start()
		{
			Modal = gameObject.transform.Find("ModalContent");
			Panel = gameObject.transform.Find("ModalContent/Panel");
		}

		public void Show()
		{
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

		public void Close()
		{
			StartCoroutine(DoClose());
		}

		public IEnumerator DoClose()
		{
			yield return StartCoroutine(HideModal(Panel));
			Modal.gameObject.SetActive(false);
		}
	}
}
