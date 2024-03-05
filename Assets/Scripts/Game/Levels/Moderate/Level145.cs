using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Moderate
{
	public abstract class Level145
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 145,
				MatchsToWin = 29,
				ThreeStarsLimit = 55,
				TwoStarsLimit = 66,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 260, PosY = -130, X = 0, Y = 0, Top = 5, Right = -1, Bottom = -2, Left = 4, CorrectRotate = 180 },
					new Block { PosX = 130, PosY = -130, X = -1, Y = 0, Top = 4, Right = 0, Bottom = 9, Left = 8, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = -130, X = -2, Y = 0, Top = 8, Right = 0, Bottom = 5, Left = 7, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = 0, X = -2, Y = 1, Top = 8, Right = 5, Bottom = 0, Left = 2, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = -260, X = -2, Y = -1, Top = 8, Right = 7, Bottom = 5, Left = -1, CorrectRotate = 270 },
					new Block { PosX = -130, PosY = -130, X = -3, Y = 0, Top = 7, Right = 1, Bottom = 4, Left = 1, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = 130, X = -2, Y = 2, Top = 1, Right = -1, Bottom = 4, Left = 2, CorrectRotate = 90 },
					new Block { PosX = 130, PosY = 0, X = -1, Y = 1, Top = -2, Right = 7, Bottom = 3, Left = 4, CorrectRotate = 180 },
					new Block { PosX = 130, PosY = -260, X = -1, Y = -1, Top = 1, Right = 4, Bottom = -1, Left = 3, CorrectRotate = 270 },
					new Block { PosX = -130, PosY = -260, X = -3, Y = -1, Top = 2, Right = 0, Bottom = 0, Left = 6, CorrectRotate = 270 },
					new Block { PosX = -130, PosY = 0, X = -3, Y = 1, Top = -1, Right = 6, Bottom = 2, Left = 1, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = 260, X = -2, Y = 3, Top = 8, Right = 4, Bottom = 1, Left = 7, CorrectRotate = 180 },
					new Block { PosX = 130, PosY = 130, X = -1, Y = 2, Top = 4, Right = 3, Bottom = -2, Left = -1, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = 130, X = -3, Y = 2, Top = 6, Right = -1, Bottom = 0, Left = 6, CorrectRotate = 180 },
					new Block { PosX = -260, PosY = -130, X = -4, Y = 0, Top = 2, Right = -2, Bottom = 9, Left = 3, CorrectRotate = 180 },
					new Block { PosX = 260, PosY = 0, X = 0, Y = 1, Top = 9, Right = 3, Bottom = 3, Left = -2, CorrectRotate = 180 },
					new Block { PosX = 130, PosY = -390, X = -1, Y = -2, Top = 3, Right = -1, Bottom = 3, Left = 1, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = -390, X = -3, Y = -2, Top = -2, Right = 7, Bottom = 4, Left = 8, CorrectRotate = 90 },
					new Block { PosX = -260, PosY = -260, X = -4, Y = -1, Top = 5, Right = 7, Bottom = 5, Left = 7, CorrectRotate = 180 },
					new Block { PosX = -260, PosY = 0, X = -4, Y = 1, Top = -2, Right = 5, Bottom = -2, Left = 5, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = 390, X = -2, Y = 4, Top = 6, Right = 5, Bottom = 3, Left = 3, CorrectRotate = 180 },
				}
			};
		}
	}
}