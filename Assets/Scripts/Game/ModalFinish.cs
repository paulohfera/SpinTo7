using Assets.Scripts.Core;
using Assets.Scripts.Core.Interfaces;
using Assets.Scripts.Data;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.Scripts.Game
{
	public class ModalFinish : ModalHelper, IModal
	{
		private Transform Modal;
		private Transform Panel;
		private Text Message;

		public void Start()
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

		IEnumerator DoShow()
		{
			yield return StartCoroutine(ShowModal(Panel));
		}

		public void Close() { }

		public void Menu()
		{
			if (BackgroundMusic.Instance)
				BackgroundMusic.Instance.Play();
			SceneManager.LoadScene("Main");
		}

		public void Rate()
		{
			var url = "https://play.google.com/store/apps/details?id=com.forfunstudios.spinto7";

#if UNITY_IOS || UNITY_IPAD
			url = "https://play.google.com/store/apps/details?id=com.forfunstudios.spinto7";
#endif
			Application.OpenURL(url);

			var user = HudManager.Instance.UserData;
			user.HasRate = true;
			Database.Save(user);
			Close();
			Menu();
		}

	}
}