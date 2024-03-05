using Assets.Scripts.Core;
using Assets.Scripts.Core.Interfaces;
using Assets.Scripts.Data;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Main
{
	public class ModalIdiom : ModalHelper, IModal
	{
		private Transform Modal;
		private Transform Panel;

		public Localize Localize;

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

		public void SetLanguagePortuguese()
		{
			var user = HudManager.Instance.UserData;
			user.Language = SystemLanguage.Portuguese;
			Database.Save(user);
			Close();
		}

		public void SetLanguageEnglish()
		{
			var user = HudManager.Instance.UserData;
			user.Language = SystemLanguage.English;
			Database.Save(user);
			Close();
		}

		public void Close()
		{
			Localize.LocalizeLevel();
			StartCoroutine(DoClose());
		}

		public IEnumerator DoClose()
		{
			yield return StartCoroutine(HideModal(Panel));
			Modal.gameObject.SetActive(false);
		}
	}
}