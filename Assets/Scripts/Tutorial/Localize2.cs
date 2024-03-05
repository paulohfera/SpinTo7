using Assets.Scripts.Core;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Tutorial
{
	public class Localize2 : MonoBehaviour
	{
		public Text Title;

		void Awake()
		{
			if (HudManager.Instance.UserData.Language != SystemLanguage.Portuguese) return;
			LocalizeLevel();
		}

		public void LocalizeLevel()
		{
			Title.text = "Beleza! Esse é um pouco diferente.\n";
			Title.text += "Tente girar o bloco do meio.";
		}
	}
}