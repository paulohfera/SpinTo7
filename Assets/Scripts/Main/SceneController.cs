using Assets.Scripts.Core;
using Assets.Scripts.Core.Interfaces;
using Assets.Scripts.Data;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.Scripts.Main
{
	public class SceneController : MonoBehaviour
	{
		public ModalAbout ModalAbout;
		public ModalDonate ModalDonate;
		public ModalIdiom ModalIdiom;
		public ModalSound ModalSound;
		public ModalRate ModalRate;
		public Text Version;

		// PurchaseManager purchase;
		private IModal ActiveModal;
		private bool HasRate;
		private DateTime LastTimeAskToRate;

		private void Start()
		{
			Version.text = Application.version;
		}

		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.Escape))
			{
				if (ActiveModal == null)
					Application.Quit();
				else
					Close();
			}
		}

		public void GetLastTimeAskToRate()
		{
			var user = HudManager.Instance.UserData;
			HasRate = user.HasRate;
			if (HasRate) return;

			if (user.LastTimeAskToRate == DateTime.MinValue)
			{
				user.LastTimeAskToRate = DateTime.Now;
				Database.Save(user);
			}
			LastTimeAskToRate = user.LastTimeAskToRate;
		}

		public void Play()
		{
			GetLastTimeAskToRate();
			if (!HasRate && DateTime.Now.Subtract(LastTimeAskToRate).TotalDays > 5)
			{
				Rate();
				return;
			}

			AdManager.Instance.ShowAdIfShould();
			SceneManager.LoadScene("Levels");
		}

		public void HowTo()
		{
			PlayerPrefs.SetInt("tutorialLevel", 1);
			SceneManager.LoadScene("Tutorial01");
		}

		public void OpenModalAbout()
		{
			ActiveModal = ModalAbout;
			ModalAbout.Show();
		}

		public void CloseModalAbout()
		{
			ActiveModal = null;
			ModalAbout.Close();
		}

		public void OpenModalDonate()
		{
			ActiveModal = ModalDonate;
			ModalDonate.Show();
		}

		public void CloseModalDonate()
		{
			ActiveModal = null;
			ModalDonate.Close();
		}

		public void OpenModalIdiom()
		{
			ActiveModal = ModalIdiom;
			ModalIdiom.Show();
		}

		public void OpenModalSound()
		{
			ActiveModal = ModalSound;
			ModalSound.Show();
		}

		private void Close()
		{
			ActiveModal.Close();
			ActiveModal = null;
		}

		public void Rate()
		{
			ActiveModal = ModalRate;
			ModalRate.Show();
		}
	}
}