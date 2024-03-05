using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Moderate
{
	public abstract class Level121
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 121,
				MatchsToWin = 14,
				ThreeStarsLimit = 37,
				TwoStarsLimit = 44,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 0, PosY = -260, X = 0, Y = 0, Top = 0, Right = 3, Bottom = 3, Left = 5, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = -130, X = 0, Y = 1, Top = 2, Right = 9, Bottom = 6, Left = -2, CorrectRotate = 180 },
					new Block { PosX = 130, PosY = -260, X = 1, Y = 0, Top = 1, Right = 4, Bottom = 7, Left = 3, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = -390, X = 0, Y = -1, Top = 9, Right = 5, Bottom = 4, Left = 5, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = -260, X = -1, Y = 0, Top = -2, Right = 1, Bottom = 4, Left = 9, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = 0, X = 0, Y = 2, Top = 1, Right = 5, Bottom = 3, Left = 2, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = 0, X = -1, Y = 2, Top = 2, Right = 8, Bottom = 6, Left = 0, CorrectRotate = 270 },
					new Block { PosX = -130, PosY = 130, X = -1, Y = 3, Top = 5, Right = -2, Bottom = 2, Left = 7, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = 130, X = 0, Y = 3, Top = 2, Right = 4, Bottom = 5, Left = 4, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = 260, X = 0, Y = 4, Top = 3, Right = -1, Bottom = 6, Left = 3, CorrectRotate = 180 },
					new Block { PosX = 130, PosY = 130, X = 1, Y = 3, Top = 9, Right = 7, Bottom = 5, Left = 2, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = 390, X = 0, Y = 5, Top = 1, Right = 6, Bottom = 9, Left = 1, CorrectRotate = 90 },
					new Block { PosX = 130, PosY = 260, X = 1, Y = 4, Top = 0, Right = 5, Bottom = 4, Left = 1, CorrectRotate = 270 },
				}
			};
		}
	}
}