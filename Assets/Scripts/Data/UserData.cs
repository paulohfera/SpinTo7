using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Scripts.Data
{
	[Serializable]
	public class UserData
	{
		public UserData()
		{
			Levels = new List<Level>();
			HelpLeft = 5;
			//LastTimeAskToRateString = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
		}

		public List<Level> Levels;
		public bool HasDonated;
		public int HelpLeft;
		public SystemLanguage Language;
		public bool HasRate;
		public string _LastTimeAskToRate;

		public DateTime LastTimeAskToRate
		{
			get
			{
				if (string.IsNullOrEmpty(_LastTimeAskToRate))
					_LastTimeAskToRate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); ;

				return Convert.ToDateTime(_LastTimeAskToRate);
			}

			set
			{
				_LastTimeAskToRate = value.ToString("yyyy-MM-dd HH:mm:ss");
			}
		}


		public UserData SaveLevel(int number, int stars)
		{
			var level = Levels.FirstOrDefault(x => x.Number == number);
			if (level == null)
			{
				Levels.Add(new Level(number, stars));
				return this;
			}

			Levels.FirstOrDefault(x => x.Number == number).Star = stars;
			return this;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}