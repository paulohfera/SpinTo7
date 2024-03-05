using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Moderate
{
	public abstract class Level117
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 117,
				MatchsToWin = 14,
				ThreeStarsLimit = 37,
				TwoStarsLimit = 44,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = -195, PosY = 260, X = 0, Y = 0, Top = -2, Right = 1, Bottom = 4, Left = 8, CorrectRotate = 270 },
					new Block { PosX = -65, PosY = 260, X = 1, Y = 0, Top = 4, Right = 9, Bottom = 6, Left = 5, CorrectRotate = 180 },
					new Block { PosX = -65, PosY = 130, X = 1, Y = -1, Top = 3, Right = 6, Bottom = 2, Left = 3, CorrectRotate = 270 },
					new Block { PosX = 65, PosY = 130, X = 2, Y = -1, Top = 8, Right = 4, Bottom = 1, Left = 2, CorrectRotate = 180 },
					new Block { PosX = -65, PosY = 0, X = 1, Y = -2, Top = 7, Right = 0, Bottom = 1, Left = 5, CorrectRotate = 180 },
					new Block { PosX = -65, PosY = -130, X = 1, Y = -3, Top = -2, Right = 6, Bottom = 0, Left = 0, CorrectRotate = 270 },
					new Block { PosX = -195, PosY = 0, X = 0, Y = -2, Top = 7, Right = 0, Bottom = 1, Left = 6, CorrectRotate = 270 },
					new Block { PosX = 65, PosY = -130, X = 2, Y = -3, Top = 4, Right = 5, Bottom = 9, Left = 3, CorrectRotate = 270 },
					new Block { PosX = -65, PosY = -260, X = 1, Y = -4, Top = 6, Right = 9, Bottom = 5, Left = 1, CorrectRotate = 270 },
					new Block { PosX = -195, PosY = -130, X = 0, Y = -3, Top = 1, Right = 2, Bottom = 7, Left = 7, CorrectRotate = 180 },
					new Block { PosX = -195, PosY = 130, X = 0, Y = -1, Top = 1, Right = 7, Bottom = 6, Left = 5, CorrectRotate = 180 },
					new Block { PosX = 195, PosY = -130, X = 3, Y = -3, Top = 3, Right = 3, Bottom = 3, Left = 5, CorrectRotate = 90 },
				}
			};
		}
	}
}