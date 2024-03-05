using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hard
{
	public abstract class Level275
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 275,
				MatchsToWin = 26,
				ThreeStarsLimit = 48,
				TwoStarsLimit = 58,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 0, PosY = 260, X = 0, Y = 0, Top = 4, Right = 3, Bottom = 7, Left = -1, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = 130, X = 0, Y = -1, Top = 1, Right = 8, Bottom = 2, Left = 9, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = 260, X = -1, Y = 0, Top = 1, Right = 5, Bottom = 2, Left = 3, CorrectRotate = 180 },
					new Block { PosX = 130, PosY = 130, X = 1, Y = -1, Top = -2, Right = 5, Bottom = 4, Left = 6, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = 0, X = 0, Y = -2, Top = 8, Right = 4, Bottom = -2, Left = -2, CorrectRotate = 270 },
					new Block { PosX = -130, PosY = 130, X = -1, Y = -1, Top = 6, Right = 7, Bottom = -2, Left = 6, CorrectRotate = 270 },
					new Block { PosX = 130, PosY = 260, X = 1, Y = 0, Top = -1, Right = 3, Bottom = 0, Left = 0, CorrectRotate = 270 },
					new Block { PosX = 130, PosY = 0, X = 1, Y = -2, Top = -2, Right = -1, Bottom = 9, Left = 6, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = -130, X = 0, Y = -3, Top = 7, Right = 3, Bottom = 4, Left = 6, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = 0, X = -1, Y = -2, Top = 9, Right = 0, Bottom = 9, Left = -1, CorrectRotate = 90 },
					new Block { PosX = -260, PosY = 130, X = -2, Y = -1, Top = 9, Right = 6, Bottom = 9, Left = 5, CorrectRotate = 90 },
					new Block { PosX = 130, PosY = 390, X = 1, Y = 1, Top = -2, Right = 7, Bottom = 1, Left = 8, CorrectRotate = 270 },
					new Block { PosX = 260, PosY = 260, X = 2, Y = 0, Top = 9, Right = 8, Bottom = 7, Left = -2, CorrectRotate = 180 },
					new Block { PosX = 260, PosY = 0, X = 2, Y = -2, Top = 8, Right = 1, Bottom = 7, Left = 6, CorrectRotate = 180 },
					new Block { PosX = 130, PosY = -130, X = 1, Y = -3, Top = 6, Right = 7, Bottom = 3, Left = 9, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = -260, X = 0, Y = -4, Top = 0, Right = 7, Bottom = 1, Left = 9, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = -130, X = -1, Y = -3, Top = 7, Right = 1, Bottom = 8, Left = 0, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = -260, X = -1, Y = -4, Top = 5, Right = 0, Bottom = 0, Left = 0, CorrectRotate = 180 },
					new Block { PosX = -260, PosY = -130, X = -2, Y = -3, Top = 6, Right = 7, Bottom = 7, Left = 2, CorrectRotate = 270 },
					new Block { PosX = -130, PosY = -390, X = -1, Y = -5, Top = 8, Right = 2, Bottom = 1, Left = 9, CorrectRotate = 90 },
				}
			};
		}
	}
}