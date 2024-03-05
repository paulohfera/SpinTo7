using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Easy
{
	public abstract class Level036
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 36,
				MatchsToWin = 23,
				ThreeStarsLimit = 52,
				TwoStarsLimit = 62,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 130, PosY = 0, X = 0, Y = 0, Top = 2, Right = 2, Bottom = 3, Left = 1, CorrectRotate = 90 },
					new Block { PosX = 130, PosY = -130, X = 0, Y = -1, Top = 7, Right = 4, Bottom = 2, Left = 6, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = 0, X = -1, Y = 0, Top = 5, Right = 0, Bottom = 5, Left = 1, CorrectRotate = 270 },
					new Block { PosX = 260, PosY = -130, X = 1, Y = -1, Top = 6, Right = 0, Bottom = 3, Left = 7, CorrectRotate = 180 },
					new Block { PosX = 130, PosY = -260, X = 0, Y = -2, Top = 0, Right = 3, Bottom = 4, Left = 5, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = -130, X = -1, Y = -1, Top = 5, Right = 3, Bottom = 1, Left = 7, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = 130, X = -1, Y = 1, Top = 7, Right = 6, Bottom = 4, Left = 6, CorrectRotate = 270 },
					new Block { PosX = -130, PosY = 130, X = -2, Y = 1, Top = 3, Right = 4, Bottom = 3, Left = 3, CorrectRotate = 270 },
					new Block { PosX = -130, PosY = 260, X = -2, Y = 2, Top = 4, Right = 5, Bottom = 0, Left = 4, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = 0, X = -2, Y = 0, Top = 2, Right = 1, Bottom = 0, Left = 3, CorrectRotate = 270 },
					new Block { PosX = -130, PosY = 390, X = -2, Y = 3, Top = 7, Right = 7, Bottom = 2, Left = 1, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = 260, X = -1, Y = 2, Top = 5, Right = 1, Bottom = 3, Left = 5, CorrectRotate = 270 },
					new Block { PosX = -130, PosY = -130, X = -2, Y = -1, Top = 6, Right = 6, Bottom = 6, Left = 5, CorrectRotate = 90 },
					new Block { PosX = 130, PosY = -390, X = 0, Y = -3, Top = 5, Right = 4, Bottom = 2, Left = 2, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = -260, X = -1, Y = -2, Top = 5, Right = 4, Bottom = 7, Left = 5, CorrectRotate = 90 },
					new Block { PosX = 130, PosY = 130, X = 0, Y = 1, Top = 7, Right = 5, Bottom = 0, Left = 0, CorrectRotate = 270 },
					new Block { PosX = -260, PosY = 260, X = -3, Y = 2, Top = 3, Right = 7, Bottom = 2, Left = 3, CorrectRotate = 90 },
					new Block { PosX = -260, PosY = 0, X = -3, Y = 0, Top = 4, Right = 6, Bottom = 0, Left = 7, CorrectRotate = 180 },
				}
			};
		}
	}
}
