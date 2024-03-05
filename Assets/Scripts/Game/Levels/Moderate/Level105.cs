using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Moderate
{
	public abstract class Level105
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 105,
				MatchsToWin = 5,
				ThreeStarsLimit = 15,
				TwoStarsLimit = 18,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 130, PosY = -65, X = 0, Y = 0, Top = 9, Right = 7, Bottom = -1, Left = 4, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = -65, X = -1, Y = 0, Top = 8, Right = 2, Bottom = 8, Left = 5, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = 65, X = -1, Y = 1, Top = 5, Right = -1, Bottom = -2, Left = 3, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = -195, X = -1, Y = -1, Top = 8, Right = -1, Bottom = 2, Left = 4, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = -65, X = -2, Y = 0, Top = 2, Right = 3, Bottom = -1, Left = 7, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = 195, X = -1, Y = 2, Top = 8, Right = 9, Bottom = 5, Left = -2, CorrectRotate = 270 },
				}
			};
		}
	}
}