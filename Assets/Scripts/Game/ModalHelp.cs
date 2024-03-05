using Assets.Scripts.Core;
using Assets.Scripts.Core.Interfaces;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Game
{
	public class ModalHelp : ModalHelper, IModal
	{
		private Transform Modal;
		private Transform Panel;

		public IBoard Board;

		private void Start()
		{
			Modal = gameObject.transform.Find("ModalContent");
			Panel = gameObject.transform.Find("ModalContent/Panel");
		}

		public void Show()
		{
			if (BackgroundMusic.Instance != null)
				BackgroundMusic.Instance.Pause();
			gameObject.transform.SetAsLastSibling();
			Panel.localPosition = new Vector3(0, 860, 0);
			Modal.gameObject.SetActive(true);
			StartCoroutine(DoShow());
		}

		IEnumerator DoShow()
		{
			yield return StartCoroutine(ShowModal(Panel));
		}

		public void Yes()
		{
			AdManager.Instance.ShowRewardedVideo(Board);
#if UNITY_EDITOR
			AdManager.Instance.onRewardedVideoFinished(0, "");
#endif
			SceneController.Instance.CloseModalHelp();
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
	}
}