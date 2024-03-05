using Assets.Scripts.Core;
using Assets.Scripts.Core.Interfaces;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.Scripts.Tutorial
{
	public class ModalTutorial : ModalHelper, IModal
	{
		private Transform Modal;
		private Transform Panel;
		private Text Message;
		public int Level;

		private void Start()
		{
			Modal = gameObject.transform.Find("ModalContent");
			Panel = gameObject.transform.Find("ModalContent/Panel");
			Message = Modal.FindText("Message");
		}

		public void Show() { }

		public void Show(string message)
		{
			gameObject.transform.SetAsLastSibling();
			Panel.localPosition = new Vector3(0, 860, 0);
			Modal.gameObject.SetActive(true);
			Message.text = message;
			StartCoroutine(DoShow());
		}

		IEnumerator DoShow()
		{
			yield return StartCoroutine(ShowModal(Panel, 326f));
		}

		public void Close()
		{
			StartCoroutine(DoClose());
		}

		public IEnumerator DoClose()
		{
			yield return StartCoroutine(HideModal(Panel));
			Modal.gameObject.SetActive(false);

			if (Level == 1)
			{
				PlayerPrefs.SetInt("tutorialLevel", 2);
				SceneManager.LoadScene("Tutorial02");
			}

			if (Level == 3)
			{
				PlayerPrefs.SetInt("tutorialLevel", 3);
				SceneManager.LoadScene("Tutorial03");
			}

			if (Level == 4)
				SceneManager.LoadScene("Map", LoadSceneMode.Single);
		}
	}
}