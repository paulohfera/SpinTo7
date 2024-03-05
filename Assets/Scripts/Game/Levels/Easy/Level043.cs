using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Easy
{
	public abstract class Level043
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 43,
				MatchsToWin = 26,
				ThreeStarsLimit = 58,
				TwoStarsLimit = 69,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 260, PosY = 260, X = 0, Y = 0, Top = 5, Right = 2, Bottom = 5, Left = 2, CorrectRotate = 90 },
					new Block { PosX = 260, PosY = 130, X = 0, Y = -1, Top = 1, Right = 5, Bottom = 7, Left = 2, CorrectRotate = 90 },
					new Block { PosX = 130, PosY = 260, X = -1, Y = 0, Top = 2, Right = 0, Bottom = 7, Left = 4, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = 260, X = -2, Y = 0, Top = 0, Right = 5, Bottom = 1, Left = 3, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = 390, X = -2, Y = 1, Top = 4, Right = 4, Bottom = 1, Left = 7, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = 130, X = -2, Y = -1, Top = 5, Right = 7, Bottom = 1, Left = 2, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = 0, X = -2, Y = -2, Top = 2, Right = 0, Bottom = 1, Left = 0, CorrectRotate = 270 },
					new Block { PosX = -130, PosY = 130, X = -3, Y = -1, Top = 4, Right = 7, Bottom = 6, Left = 6, CorrectRotate = 90 },
					new Block { PosX = 130, PosY = 0, X = -1, Y = -2, Top = 3, Right = 5, Bottom = 7, Left = 2, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = -130, X = -2, Y = -3, Top = 6, Right = 5, Bottom = 2, Left = 7, CorrectRotate = 270 },
					new Block { PosX = -130, PosY = 0, X = -3, Y = -2, Top = 2, Right = 6, Bottom = 1, Left = 6, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = 260, X = -3, Y = 0, Top = 0, Right = 2, Bottom = 6, Left = 6, CorrectRotate = 180 },
					new Block { PosX = 130, PosY = 130, X = -1, Y = -1, Top = 6, Right = 0, Bottom = 2, Left = 7, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = -260, X = -2, Y = -4, Top = 6, Right = 6, Bottom = 0, Left = 2, CorrectRotate = 270 },
					new Block { PosX = -130, PosY = -130, X = -3, Y = -3, Top = 3, Right = 5, Bottom = 5, Left = 2, CorrectRotate = 90 },
					new Block { PosX = -260, PosY = 0, X = -4, Y = -2, Top = 5, Right = 2, Bottom = 6, Left = 1, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = 390, X = -3, Y = 1, Top = 1, Right = 6, Bottom = 4, Left = 6, CorrectRotate = 180 },
					new Block { PosX = 130, PosY = -260, X = -1, Y = -4, Top = 2, Right = 1, Bottom = 2, Left = 7, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = -390, X = -2, Y = -5, Top = 4, Right = 1, Bottom = 1, Left = 3, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = -390, X = -3, Y = -5, Top = 4, Right = 7, Bottom = 7, Left = 6, CorrectRotate = 180 },
				}
			};
		}
	}
}