using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Easy
{
	public class Level001
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 1,
				MatchsToWin = 1,
				ThreeStarsLimit = 4,
				TwoStarsLimit = 5,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 0, PosY = -65, X = 0, Y = 0, Top = 5, Right = 2, Bottom = 1, Left = 7, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = 65, X = 0, Y = 1, Top = 2, Right = 4, Bottom = 6, Left = 3, CorrectRotate = 0 }
				}
			};
		}
	}
}