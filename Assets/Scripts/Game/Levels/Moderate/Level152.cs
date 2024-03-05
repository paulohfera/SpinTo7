using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Moderate
{
	public abstract class Level152
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 152,
				MatchsToWin = 35,
				ThreeStarsLimit = 68,
				TwoStarsLimit = 81,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 130, PosY = -260, X = 0, Y = 0, Top = 8, Right = -1, Bottom = -1, Left = 6, CorrectRotate = 270 },
					new Block { PosX = 130, PosY = -130, X = 0, Y = 1, Top = 6, Right = 1, Bottom = 6, Left = 8, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = -130, X = -1, Y = 1, Top = 1, Right = -1, Bottom = 9, Left = 4, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = 0, X = -1, Y = 2, Top = 7, Right = 5, Bottom = 5, Left = 3, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = -260, X = -1, Y = 0, Top = 6, Right = 6, Bottom = 8, Left = 8, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = 130, X = -1, Y = 3, Top = 2, Right = 0, Bottom = -1, Left = 8, CorrectRotate = 180 },
					new Block { PosX = 130, PosY = 0, X = 0, Y = 2, Top = -1, Right = 2, Bottom = 0, Left = 7, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = -390, X = -1, Y = -1, Top = 4, Right = 1, Bottom = 4, Left = 1, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = -260, X = -2, Y = 0, Top = 1, Right = 5, Bottom = 9, Left = 3, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = 260, X = -1, Y = 4, Top = 8, Right = 7, Bottom = 9, Left = 5, CorrectRotate = 180 },
					new Block { PosX = 130, PosY = 260, X = 0, Y = 4, Top = -1, Right = 2, Bottom = 1, Left = 0, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = 260, X = -2, Y = 4, Top = 0, Right = 1, Bottom = 4, Left = 2, CorrectRotate = 270 },
					new Block { PosX = -130, PosY = 130, X = -2, Y = 3, Top = 9, Right = 2, Bottom = 6, Left = 7, CorrectRotate = 180 },
					new Block { PosX = 130, PosY = 130, X = 0, Y = 3, Top = 9, Right = 7, Bottom = -1, Left = 8, CorrectRotate = 270 },
					new Block { PosX = 260, PosY = 0, X = 1, Y = 2, Top = 3, Right = 0, Bottom = 6, Left = 0, CorrectRotate = 180 },
					new Block { PosX = 130, PosY = -390, X = 0, Y = -1, Top = 3, Right = 0, Bottom = 3, Left = 8, CorrectRotate = 270 },
					new Block { PosX = -130, PosY = -390, X = -2, Y = -1, Top = 3, Right = 0, Bottom = 1, Left = 2, CorrectRotate = 270 },
					new Block { PosX = -130, PosY = -130, X = -2, Y = 1, Top = 4, Right = 7, Bottom = 1, Left = -2, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = 390, X = -1, Y = 5, Top = 4, Right = 2, Bottom = 8, Left = -2, CorrectRotate = 90 },
					new Block { PosX = 130, PosY = 390, X = 0, Y = 5, Top = 6, Right = -1, Bottom = 3, Left = -1, CorrectRotate = 180 },
					new Block { PosX = 260, PosY = 260, X = 1, Y = 4, Top = 8, Right = 7, Bottom = 9, Left = 2, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = 390, X = -2, Y = 5, Top = 5, Right = 6, Bottom = 3, Left = 3, CorrectRotate = 180 },
					new Block { PosX = -260, PosY = 260, X = -3, Y = 4, Top = 7, Right = 7, Bottom = 6, Left = 3, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = 0, X = -2, Y = 2, Top = 0, Right = 6, Bottom = 0, Left = -2, CorrectRotate = 270 },
				}
			};
		}
	}
}