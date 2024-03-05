using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Moderate
{
	public abstract class Level110
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 110,
				MatchsToWin = 10,
				ThreeStarsLimit = 22,
				TwoStarsLimit = 26,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 65, PosY = 65, X = 0, Y = 0, Top = 0, Right = 7, Bottom = 6, Left = 5, CorrectRotate = 90 },
					new Block { PosX = 65, PosY = -65, X = 0, Y = -1, Top = 6, Right = 3, Bottom = 6, Left = 2, CorrectRotate = 270 },
					new Block { PosX = -65, PosY = 65, X = -1, Y = 0, Top = -1, Right = 0, Bottom = 0, Left = 7, CorrectRotate = 180 },
					new Block { PosX = 195, PosY = -65, X = 1, Y = -1, Top = 4, Right = 1, Bottom = 1, Left = 2, CorrectRotate = 270 },
					new Block { PosX = 65, PosY = -195, X = 0, Y = -2, Top = 3, Right = -2, Bottom = 4, Left = 6, CorrectRotate = 180 },
					new Block { PosX = -65, PosY = -65, X = -1, Y = -1, Top = 1, Right = 2, Bottom = 4, Left = 8, CorrectRotate = 270 },
					new Block { PosX = -65, PosY = 195, X = -1, Y = 1, Top = 9, Right = 5, Bottom = 4, Left = 7, CorrectRotate = 90 },
					new Block { PosX = -195, PosY = 65, X = -2, Y = 0, Top = 4, Right = 6, Bottom = 7, Left = 8, CorrectRotate = 90 },
					new Block { PosX = 195, PosY = 65, X = 1, Y = 0, Top = 1, Right = 4, Bottom = 7, Left = 5, CorrectRotate = 90 },
				}
			};
		}
	}
}