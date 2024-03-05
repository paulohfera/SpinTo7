using Assets.Scripts.Core;
using Assets.Scripts.Core.Interfaces;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Tutorial
{
	public class SceneController : MonoBehaviour
	{
		private static SceneController _instance;
		public static SceneController Instance { get { return _instance; } }

		public ModalTutorial ModalTutorial;

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

		void Update()
		{
			if (Input.GetKeyDown(KeyCode.Escape))
			{
				if (ActiveModal == null)
					SceneManager.LoadScene("Main");
				else
					Close();
			}
		}

		public void ShowTutorial1()
		{
			ActiveModal = ModalTutorial;
			ModalTutorial.Level = 1;

			if (HudManager.Instance.UserData.Language == SystemLanguage.Portuguese)
				ModalTutorial.Show("Excelente!\nVeja que a soma dos dois blocos é 7 (5 + 2).\nVamos tentar algo diferente.");
			else
				ModalTutorial.Show("Excelente!\nNote that the sum of the two tiles is 7 (5 + 2).\nLet's try something different.");
		}

		public void ShowTutorial2_1()
		{
			ActiveModal = ModalTutorial;
			ModalTutorial.Level = 2;

			if (HudManager.Instance.UserData.Language == SystemLanguage.Portuguese)
				ModalTutorial.Show("Hummm... ainda não!\nOs blocos da esquerda e do meio estão certos mas você precisa somar 7 com o bloco da direita também.\nNão se preocupe, gire o bloco do meio novamente.");
			else
				ModalTutorial.Show("Hummm... not yet!\nThe tiles on left and middle are ok but you need to sum 7 with the right tile too.\nDon't wory, spin the middle tile again.");
		}

		public void ShowTutorial2_2()
		{
			ActiveModal = ModalTutorial;
			ModalTutorial.Level = 3;

			if (HudManager.Instance.UserData.Language == SystemLanguage.Portuguese)
				ModalTutorial.Show("Impressionante!!!\nVamos para mais uma!");
			else
				ModalTutorial.Show("Awesome!!!\nLet's go to another one!");
		}

		public void ShowTutorial3()
		{
			ActiveModal = ModalTutorial;
			ModalTutorial.Level = 4;

			if (HudManager.Instance.UserData.Language == SystemLanguage.Portuguese)
				ModalTutorial.Show("Não é fantástico?\nQuero que você sempre vença.\n\nAcredito que você está preparado para jogar por conta própria!");
			else
				ModalTutorial.Show("Is it not fantastic?\nI want you always win.\n\nI think you are prepared to play by your own!");
		}

		private void Close()
		{
			ActiveModal.Close();
			ActiveModal = null;
		}

		public void CloseModalTutorial()
		{
			ActiveModal = null;
			ModalTutorial.Close();
		}
	}
}