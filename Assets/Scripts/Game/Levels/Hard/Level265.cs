using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hard
{
	public abstract class Level265
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 265,
				MatchsToWin = 22,
				ThreeStarsLimit = 44,
				TwoStarsLimit = 53,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = -130, PosY = 260, X = 0, Y = 0, Top = 3, Right = 3, Bottom = 5, Left = 7, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = 390, X = 0, Y = 1, Top = 3, Right = 2, Bottom = 7, Left = 6, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = 260, X = 1, Y = 0, Top = 7, Right = -2, Bottom = 0, Left = 4, CorrectRotate = 270 },
					new Block { PosX = 130, PosY = 260, X = 2, Y = 0, Top = 0, Right = 5, Bottom = 3, Left = 5, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = 130, X = 1, Y = -1, Top = 7, Right = -2, Bottom = 9, Left = 8, CorrectRotate = 180 },
					new Block { PosX = 130, PosY = 130, X = 2, Y = -1, Top = 5, Right = -1, Bottom = 2, Left = 5, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = 0, X = 1, Y = -2, Top = 8, Right = 0, Bottom = 0, Left = 2, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = 130, X = 0, Y = -1, Top = 9, Right = -2, Bottom = 7, Left = 4, CorrectRotate = 270 },
					new Block { PosX = 130, PosY = 0, X = 2, Y = -2, Top = 7, Right = 2, Bottom = 8, Left = 3, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = -130, X = 1, Y = -3, Top = 1, Right = 6, Bottom = 4, Left = 5, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = -260, X = 1, Y = -4, Top = 1, Right = 5, Bottom = 1, Left = 5, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = -130, X = 0, Y = -3, Top = 0, Right = 7, Bottom = 3, Left = 2, CorrectRotate = 90 },
					new Block { PosX = 130, PosY = -260, X = 2, Y = -4, Top = 2, Right = 7, Bottom = 2, Left = 2, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = -390, X = 1, Y = -5, Top = 8, Right = -1, Bottom = 7, Left = 6, CorrectRotate = 270 },
					new Block { PosX = -260, PosY = 390, X = -1, Y = 1, Top = 6, Right = 1, Bottom = 0, Left = -1, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = 390, X = 1, Y = 1, Top = 3, Right = 4, Bottom = 4, Left = 3, CorrectRotate = 180 },
					new Block { PosX = 260, PosY = 260, X = 3, Y = 0, Top = 9, Right = 4, Bottom = 4, Left = 6, CorrectRotate = 270 },
					new Block { PosX = 260, PosY = 130, X = 3, Y = -1, Top = -1, Right = 2, Bottom = 3, Left = 3, CorrectRotate = 180 },
				}
			};
		}
	}
}