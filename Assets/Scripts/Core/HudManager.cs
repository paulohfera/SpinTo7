using Assets.Scripts.Data;
using UnityEngine;

namespace Assets.Scripts.Core
{
	public class HudManager : MonoBehaviour
	{
		private static HudManager _instance;
		public static HudManager Instance { get { return _instance; } }

		public UserData UserData;
		public int GameLevel;
		public Difficulty Difficulty;

		private void Awake()
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

			UserData = Database.GetData();
			//Difficulty = Difficulty.Easy;
		}

		public string Namespace
		{
			get
			{
				switch (Difficulty)
				{
					case Difficulty.Moderate:
						return "Assets.Scripts.Game.Levels.Moderate";
					case Difficulty.Hard:
						return "Assets.Scripts.Game.Levels.Hard";
					case Difficulty.Hexagon:
						return "Assets.Scripts.Game.Levels.Hexagon";
					case Difficulty.Corner:
						return "Assets.Scripts.Game.Levels.Corner";
					default:
						return "Assets.Scripts.Game.Levels.Easy";
				}
			}
		}

		public int Minlevel
		{
			get
			{
				switch (Difficulty)
				{
					case Difficulty.Moderate:
						return 101;
					case Difficulty.Hard:
						return 201;
					case Difficulty.Hexagon:
						return 301;
					case Difficulty.Corner:
						return 401;
					default:
						return 1;
				}
			}
		}

		public int Maxlevel
		{
			get
			{
				switch (Difficulty)
				{
					case Difficulty.Moderate:
						return 200;
					case Difficulty.Hard:
						return 300;
					case Difficulty.Hexagon:
						return 400;
					case Difficulty.Corner:
						return 500;
					default:
						return 100;
				}
			}
		}
	}
}