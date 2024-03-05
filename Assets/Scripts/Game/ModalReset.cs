using Assets.Scripts.Core;
using Assets.Scripts.Core.Interfaces;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Game
{
	public class ModalReset : ModalHelper, IModal
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
			AdManager.Instance.ShowAdIfShould();
			StartCoroutine(CloseAndReset());
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

		public IEnumerator CloseAndReset()
		{
			yield return DoClose();

			var scene = SceneManager.GetActiveScene();
			SceneManager.LoadScene(scene.name, LoadSceneMode.Single);
		}
	}
}