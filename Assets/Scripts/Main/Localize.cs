using Assets.Scripts.Core;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Main
{
    public class Localize : MonoBehaviour
	{
		public Image HowTo;
		public Image Rate;
		public Text ModalAboutText;
		public Text ModalDonateText1;
		public Text ModalDonateText2;
		public Text ModalIdiomTitle;
		public Text ModalSoundBackground;
		public Text ModalSoundSounds;
		public Text ModalRateText;
		public Image ModalRateYes;
		public Image ModalRateNo;


		void Awake()
		{
			LocalizeLevel();
		}

		public void LocalizeLevel()
		{
			if (HudManager.Instance.UserData.Language == SystemLanguage.Portuguese)
				LocalizePortuguese();
			else
				LocalizeEnglish();
		}

		private void LocalizePortuguese()
		{
			var sprites = Resources.LoadAll<Sprite>("Sprite");

			HowTo.sprite = sprites.Single(x => x.name == "ComoJogarButton");
			HowTo.GetComponent<RectTransform>().sizeDelta = new Vector2(306, 82);

			Rate.sprite = sprites.Single(x => x.name == "AvalieButton");

			ModalAboutText.text = "Oi, como vai?\n\n";
			ModalAboutText.text += "Estou tão feliz com o seu interesse nesse jogo. Esse é um jogo independente feito enquanto eu aprendia Unity 3D.\n\n";
			ModalAboutText.text += "Espero que você goste de jogar tanto quanto eu gostei de fazer.\n\n";
			ModalAboutText.text += "Eu quero fazer um agradecimento especial para a minha esposa Mayara por sua paciência pelas horas que eu gastei em frente ao computador programando e ao meu sobrinho Gabriel por todas as ideias e sugestões que ele me deu. Eles foram assenciais para eu fazer esse jogo.\n\n";
			ModalAboutText.text += "Da uma olhada em nossas redes sociais para conhecer um pouco mais sobre a For Fun Studios";

			ModalDonateText1.text = "E aí?\n\n";
			ModalDonateText1.text += "Você está amando esse jogo e gostaria de suportar meu trabalho? Bom, nesse caso eu te amo também :)\n\n";
			ModalDonateText1.text += "Tá bom, sério, se você me ajudar e me encorajar a continuar atualizando esse jogo e produzir novo jogos essas são as opções:";

			ModalDonateText2.text = "O que você ganha fazendo uma doação:\n\n";
			ModalDonateText2.text += "- Nada de anúncios\n";
			ModalDonateText2.text += "- Ajudas infinitas\n";
			ModalDonateText2.text += "- Obtenha acesso a todas as fases\n";
			ModalDonateText2.text += "- Ajuda um desenvolvedor independente muito legal\n\n";
			ModalDonateText2.text += "Muito obrigado por acreditar em meu trabalho. Estou muito agradecido.";

			ModalIdiomTitle.text = "Escolha o idioma";

			ModalSoundBackground.text = "Tocar música de fundo";
			ModalSoundSounds.text = "Tocar sons";

			ModalRateText.text = "E aí! Você sabia que nós te amamos?\n\n";
			ModalRateText.text += "Mas me diga, você está gostando de jogar esse jogo?\n\n";
			ModalRateText.text += "Se está, por favor, nos faça uma boa avaliação.\n\n";
			ModalRateText.text += "Se não, finja que você está gostando e nos faça uma boa avaliação. Prometemos que podemos fazer melhor da próxima.\n\n";
			ModalRateText.text += "Você gostaria de nos avaliar?";

			ModalRateYes.sprite = sprites.Single(x => x.name == "SimButton");
			ModalRateNo.sprite = sprites.Single(x => x.name == "NaoButton");
		}

		private void LocalizeEnglish()
		{
			var sprites = Resources.LoadAll<Sprite>("Sprite");

			HowTo.sprite = sprites.Single(x => x.name == "HowToButton");
			HowTo.GetComponent<RectTransform>().sizeDelta = new Vector2(231, 82);

			Rate.sprite = sprites.Single(x => x.name == "RateButton");

			ModalAboutText.text = "Hi, how is it going?\n\n";
			ModalAboutText.text += "I'm so happy with you interesting in this game. This is an indie game made while I was learning Unity 3D.\n\n";
			ModalAboutText.text += "I hope you enjoy playing as much as I enjoyed doing.\n\n";
			ModalAboutText.text += "I want to give a special thank to my wife Mayara for her patience for the hours I spent in front of computer programming and my nephew Gabriel for all ideas and suggestions he gave me. They were essential for me to made this game.\n\n";
			ModalAboutText.text += "Check out our social networks to know more about For Fun Studios";

			ModalDonateText1.text = "Hey there?\n\n";
			ModalDonateText1.text += "Are you in love with this game and would you like to support my work? Well, in this case I love you too :)\n\n";
			ModalDonateText1.text += "Okay, seriously, if you want to help me and encourage me to continue updating this game and producing new games these are the options:";

			ModalDonateText2.text = "What you get when you donate:\n\n";
			ModalDonateText2.text += "- No more Ads\n";
			ModalDonateText2.text += "- Infinite helps\n";
			ModalDonateText2.text += "- Get access to all levels\n";
			ModalDonateText2.text += "- Suport a very nice indie developer\n\n";
			ModalDonateText2.text += "Thank you so much for believing in my work. I'm so very grateful.";

			ModalIdiomTitle.text = "Choose the idiom";

			ModalSoundBackground.text = "Play background music";
			ModalSoundSounds.text = "Play sounds";

			ModalRateText.text = "Hey there! Do you know that we love you?\n\n";
			ModalRateText.text += "But tell me, are you loving playing this game?\n\n";
			ModalRateText.text += "If yes, please, give us a good rate.\n\n";
			ModalRateText.text += "If no, pretend that you love and give us a good rate. We promisse that we can do better next time.\n\n";
			ModalRateText.text += "Would you like to rate us?";

			ModalRateYes.sprite = sprites.Single(x => x.name == "YesButton");
			ModalRateNo.sprite = sprites.Single(x => x.name == "NoButton");
		}
	}
}