using Assets.Scripts.Core;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Tutorial
{
	public class Localize : MonoBehaviour
	{
		public Text Title;

		void Awake()
		{
			if (HudManager.Instance.UserData.Language != SystemLanguage.Portuguese) return;
			LocalizeLevel();
		}

		public void LocalizeLevel()
		{
			Title.text = "Para ganhar você precisa girar os blocos para somar 7 com todos os blocos vizinhos.\n\n";
			Title.text += "Por exemplo, gire o bloco de baixo.";
		}
	}
}