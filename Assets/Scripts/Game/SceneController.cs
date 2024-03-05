using Assets.Scripts.Core.Interfaces;
using System;
using UnityEngine;

namespace Assets.Scripts.Game
{
	public class SceneController : MonoBehaviour
	{
		private static SceneController _instance;
		public static SceneController Instance { get { return _instance; } }
		
		public ModalLevel ModalLevel;
		public ModalPause ModalPause;
		public ModalReset ModalReset;
		public ModalHelp ModalHelp;

		private IModal ActiveModal;

		void Awake()
		{
			if (_instance != null && _instance != this)
			{
				Destroy(gameObject);
			}
			else
			{
				_instance = this;
			}
		}

		private void Start()
		{
			if (BackgroundMusic.Instance)
				BackgroundMusic.Instance.Play();
		}

		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.Escape))
			{
				if (ActiveModal == null)
					OpenModalPause();
				else
					Close();
			}
		}

		public void OpenModalLevel(int movements, int stars, DateTime beginTime)
		{
			ActiveModal = ModalLevel;
			ModalLevel.Show(movements, stars, beginTime);
		}

		public void OpenModalPause()
		{
			ActiveModal = ModalPause;
			ModalPause.Show();
		}

		public void CloseModalPause()
		{
			ActiveModal = null;
			ModalPause.Close();
		}

		public void OpenModalReset()
		{
			ActiveModal = ModalReset;
			ModalReset.Show();
		}

		public void CloseModalReset()
		{
			ActiveModal = null;
			ModalReset.Close();
		}

		public void OpenModalHelp(IBoard board)
		{
			ActiveModal = ModalHelp;
			ModalHelp.Board = board;
			ModalHelp.Show();
		}

		public void OpenVideoReward(IBoard board)
		{
			ActiveModal = ModalHelp;
			ModalHelp.Board = board;
			ModalHelp.Yes();
		}

		public void CloseModalHelp()
		{
			ActiveModal = null;
			ModalHelp.Close();
		}

		private void Close()
		{
			ActiveModal.Close();
			ActiveModal = null;
		}
	}
}