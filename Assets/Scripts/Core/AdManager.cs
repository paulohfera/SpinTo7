// using AppodealAds.Unity.Api;
// using AppodealAds.Unity.Common;
using Assets.Scripts.Core.Interfaces;
using Assets.Scripts.Data;
using Assets.Scripts.Game;
using UnityEngine;

namespace Assets.Scripts.Core
{
	public class AdManager : MonoBehaviour//, IRewardedVideoAdListener
	{
		private static AdManager _instance;
		public static AdManager Instance { get { return _instance; } }

		private static bool HasDonated;
		private System.DateTime LastInterestitialTime;
		private IBoard Board;

		void Awake()
		{
			if (_instance != null && _instance != this)
			{
				Destroy(gameObject);
			}
			else
			{
				_instance = this;
				DontDestroyOnLoad(gameObject);
			}
		}

		private void Start()
		{
			// string appKey = "71aa8c4dc81ba1565713352d94424b764b456da8c07678b3";
			// Appodeal.disableNetwork("inmobi");
			// Appodeal.disableNetwork("adcolony");
			// Appodeal.disableNetwork("facebook");
			// Appodeal.disableNetwork("yandex");
			// Appodeal.disableLocationPermissionCheck();
			// Appodeal.setTesting(false);
			// Appodeal.initialize(appKey, Appodeal.INTERSTITIAL | Appodeal.REWARDED_VIDEO);
			// Appodeal.setRewardedVideoCallbacks(this);
			// HasDonated = HudManager.Instance.UserData.HasDonated;
			// LastInterestitialTime = System.DateTime.Now.AddHours(-1);
		}

		public void ShowAdIfShould()
		{
			// var timeElapsed = System.DateTime.Now.Subtract(LastInterestitialTime).TotalMinutes;
			// if (timeElapsed < 2) return;

			// var number = Random.Range(1, 100);
			// if (number < 40 || number > 60) return;

			// if (HasDonated) return;

			// if (Appodeal.isLoaded(Appodeal.INTERSTITIAL))
			// {
			// 	Appodeal.show(Appodeal.INTERSTITIAL);
			// 	LastInterestitialTime = System.DateTime.Now;
			// }
		}

		public void ShowRewardedVideo(IBoard board)
		{
			// Board = board;
			// if (Appodeal.isLoaded(Appodeal.REWARDED_VIDEO))
			// {
			// 	Appodeal.show(Appodeal.REWARDED_VIDEO);
			// }
		}

		public void ShowBannerTop()
		{
			// Appodeal.show(Appodeal.BANNER_TOP);
		}

		public static void DonatedComplete()
		{
			HasDonated = true;
		}

		public void onRewardedVideoLoaded()
		{
		}

		public void onRewardedVideoFailedToLoad()
		{
		}

		public void onRewardedVideoShown()
		{
		}

		public void onRewardedVideoFinished(int amount, string name)
		{
			var user = HudManager.Instance.UserData;
			user.HelpLeft = user.HelpLeft + 2;

			Database.Save(user);
			Board.SetHelp(user.HelpLeft);
		}

		public void onRewardedVideoClosed(bool finished)
		{
		}
	}
}