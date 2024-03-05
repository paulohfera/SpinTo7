using Assets.Scripts.Core;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Tutorial
{
	public class Localize3 : MonoBehaviour
	{
		public Text Title;

		void Awake()
		{
			if (HudManager.Instance.UserData.Language != SystemLanguage.Portuguese) return;
			LocalizeLevel();
		}

		public void LocalizeLevel()
		{
			Title.text = "Agora, imagine que essa fase é muito dificil.\n";
			Title.text += "Se você estiver travado clique no ícone da lâmpada lá embaixo.";
		}
	}
}