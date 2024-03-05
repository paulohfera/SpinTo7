using Assets.Scripts.Core;
using Assets.Scripts.Core.Interfaces;
using Assets.Scripts.Data;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Main
{
	public class ModalRate : ModalHelper, IModal
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

		public void Close()
		{
			StartCoroutine(DoClose());
			var user = HudManager.Instance.UserData;
			user.LastTimeAskToRate = DateTime.Now;
			Database.Save(user);
		}

		public IEnumerator DoClose()
		{
			yield return StartCoroutine(HideModal(Panel));
			Modal.gameObject.SetActive(false);
		}

		public void Yes()
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
		}
	}
}
