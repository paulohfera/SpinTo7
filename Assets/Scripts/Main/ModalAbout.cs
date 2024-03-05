using Assets.Scripts.Core;
using Assets.Scripts.Core.Interfaces;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Main
{
	public class ModalAbout : ModalHelper, IModal
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
			Panel.localPosition = new Vector3(0, 1075, 0);
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
		}

		public IEnumerator DoClose()
		{
			yield return StartCoroutine(HideModal(Panel));
			Modal.gameObject.SetActive(false);
		}

		public void Facebook()
		{
			Application.OpenURL("https://www.facebook.com/forfunstudios/");
		}

		public void Instagram()
		{
			Application.OpenURL("https://www.instagram.com/forfunstudios/");
		}

		public void Twitter()
		{
			Application.OpenURL("https://twitter.com/forfunstudios/");
		}

		public void Reddit()
		{
			Application.OpenURL("https://www.reddit.com/user/forfunstudios/");
		}

		public void Youtube()
		{
			Application.OpenURL("https://www.youtube.com/channel/UCb7QHyDMX2f7XXUCY9xcvvg/");
		}
	}
}