using System;

namespace Assets.Scripts.Data
{
	[Serializable]
	public class Level
	{
		public Level(int number, int star)
		{
			Number = number;
			Star = star;
		}

		public int Number;
		public int Star;
	}
}