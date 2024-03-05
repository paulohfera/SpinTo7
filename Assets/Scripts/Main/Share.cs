using Assets.Scripts.Core;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Assets.Scripts.Main
{
	public class Share : MonoBehaviour, IPointerDownHandler
	{
		public void OnPointerDown(PointerEventData eventData)
		{
			var url = "https://play.google.com/store/apps/details?id=com.forfunstudios.spinto7";

#if UNITY_IOS || UNITY_IPAD
			url = "https://play.google.com/store/apps/details?id=com.forfunstudios.spinto7";
#endif

			var extraSubject = "Would you like to try out a cool game?";
			var extraText = "I'm playing \"Spin to 7\" and I think you'll like it a lot: " + url;
			if (HudManager.Instance.UserData.Language == SystemLanguage.Portuguese)
			{
				extraSubject = "Você gostaria de experimentar um jogo legal?";
				extraText = "Estou jogando \"Spin to 7\" eu acho que você vai gostar muito: " + url;
			}

#if UNITY_ANDROID
			// Get the required Intent and UnityPlayer classes.
			AndroidJavaClass intentClass = new AndroidJavaClass("android.content.Intent");
			AndroidJavaClass unityPlayerClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer");

			// Construct the intent.
			AndroidJavaObject intent = new AndroidJavaObject("android.content.Intent");
			intent.Call<AndroidJavaObject>("setAction", intentClass.GetStatic<string>("ACTION_SEND"));
			intent.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>("EXTRA_SUBJECT"), extraSubject);
			intent.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>("EXTRA_TEXT"), extraText);
			intent.Call<AndroidJavaObject>("setType", "text/plain");

			// Display the chooser.
			AndroidJavaObject currentActivity = unityPlayerClass.GetStatic<AndroidJavaObject>("currentActivity");
			AndroidJavaObject chooser = intentClass.CallStatic<AndroidJavaObject>("createChooser", intent, "Share");
			currentActivity.Call("startActivity", chooser);
#elif UNITY_IOS || UNITY_IPAD
			ShareSimpleText(extraSubject + " " + extraText);
#endif
		}

#if UNITY_IOS || UNITY_IPAD

		[DllImport("__Internal")]
		private static extern void _TAG_ShareTextWithImage(string iosPath, string message);

		[DllImport("__Internal")]
		private static extern void _TAG_ShareSimpleText(string message);

		public static void ShareSimpleText(string message)
		{
			_TAG_ShareSimpleText(message);
		}

		public static void ShareTextWithImage(string imagePath, string message)
		{
			_TAG_ShareTextWithImage(imagePath, message);
		}
#endif

	}
}