using Assets.Scripts.Core;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Game
{
	public class Localize : MonoBehaviour
	{
		public Text ModalLevelCaption;
		public Image ModalLevelEarn;

		public Text ModalFinishText;
		public Image ModalFinishRate;

		public Text ModalPauseBackground;
		public Text ModalPauseSounds;

		public Text ModalResetTitle;
		public Text ModalResetText;
		public Image ModalResetYes;
		public Image ModalResetNo;

		public Text ModalHelpText;
		public Image ModalHelpYes;
		public Image ModalHelpNo;

		void Awake()
		{
			if (HudManager.Instance.UserData.Language != SystemLanguage.Portuguese) return;
			LocalizeLevel();
		}

		public void LocalizeLevel()
		{
			var sprites = Resources.LoadAll<Sprite>("Sprite");
			var sprites2 = Resources.LoadAll<Sprite>("Sprite2");

			ModalLevelCaption.text = "Level completo";
			ModalLevelEarn.sprite = sprites2.Single(x => x.name == "GanheIcon");

			ModalFinishText.text = "Parabéns (ou desculpe), você terminou esse nível. Em breve vou atualizar o jogo com mais fases.\n\n";
			ModalFinishText.text += "Você gostou do jogo? Se gostou, por favor, me dê uma boa avaliação. Agora, se você realmente amou faça uma doação para o jogo (você pode fazer isso no menu).\n\n";
			ModalFinishText.text += "Espero ver você novamente quando o jogo tiver mais fases. Te vejo em breve.";

			ModalFinishRate.sprite = sprites.Single(x => x.name == "AvalieButton");

			ModalPauseBackground.text = "Tocar música de fundo";
			ModalPauseSounds.text = "Tocar sons";

			ModalResetTitle.text = "Reiniciar fase?";
			ModalResetText.text = "Todo o progresso será perdido";

			ModalHelpText.text = "Desculpa mas você não tem mais nenhuma ajuda sobrando.\n";
			ModalHelpText.text += "Você aceita assistir a um vídeo?\n";
			ModalHelpText.text += "A recompensa é mais duas ajudas.";

			ModalHelpYes.sprite = sprites.Single(x => x.name == "SimButton"); ;
			ModalHelpNo.sprite = sprites.Single(x => x.name == "NaoButton");

			ModalResetYes.sprite = sprites.Single(x => x.name == "SimButton"); ;
			ModalResetNo.sprite = sprites.Single(x => x.name == "NaoButton");
		}
	}
}
