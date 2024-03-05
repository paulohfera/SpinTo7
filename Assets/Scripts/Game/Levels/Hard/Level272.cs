using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hard
{
	public abstract class Level272
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 272,
				MatchsToWin = 28,
				ThreeStarsLimit = 46,
				TwoStarsLimit = 56,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = -260, PosY = 325, X = 0, Y = 0, Top = 4, Right = 8, Bottom = 5, Left = 9, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = 325, X = 1, Y = 0, Top = 2, Right = 2, Bottom = 4, Left = 2, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = 195, X = 1, Y = -1, Top = 1, Right = 5, Bottom = 3, Left = 6, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = 195, X = 2, Y = -1, Top = 2, Right = 3, Bottom = 4, Left = 7, CorrectRotate = 270 },
					new Block { PosX = 130, PosY = 195, X = 3, Y = -1, Top = 5, Right = 5, Bottom = 4, Left = 1, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = 65, X = 2, Y = -2, Top = 6, Right = 4, Bottom = -1, Left = -2, CorrectRotate = 90 },
					new Block { PosX = 130, PosY = 325, X = 3, Y = 0, Top = 3, Right = 8, Bottom = 5, Left = 9, CorrectRotate = 180 },
					new Block { PosX = 260, PosY = 195, X = 4, Y = -1, Top = 8, Right = 9, Bottom = 6, Left = 3, CorrectRotate = 270 },
					new Block { PosX = 130, PosY = 65, X = 3, Y = -2, Top = 5, Right = 0, Bottom = 8, Left = 2, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = -65, X = 2, Y = -3, Top = 1, Right = 5, Bottom = 9, Left = -1, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = -195, X = 2, Y = -4, Top = -2, Right = 6, Bottom = 4, Left = 6, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = -65, X = 1, Y = -3, Top = 2, Right = -1, Bottom = 7, Left = 9, CorrectRotate = 270 },
					new Block { PosX = 130, PosY = -195, X = 3, Y = -4, Top = 3, Right = 7, Bottom = 9, Left = 2, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = -325, X = 2, Y = -5, Top = 9, Right = 4, Bottom = 1, Left = -1, CorrectRotate = 180 },
					new Block { PosX = 260, PosY = 325, X = 4, Y = 0, Top = 4, Right = -2, Bottom = 0, Left = -1, CorrectRotate = 180 },
					new Block { PosX = 260, PosY = 65, X = 4, Y = -2, Top = 5, Right = 4, Bottom = 2, Left = -2, CorrectRotate = 270 },
					new Block { PosX = 130, PosY = -65, X = 3, Y = -3, Top = 8, Right = 7, Bottom = 7, Left = 0, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = -195, X = 1, Y = -4, Top = -1, Right = 8, Bottom = 9, Left = 2, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = 65, X = 1, Y = -2, Top = 6, Right = 1, Bottom = 1, Left = -2, CorrectRotate = 90 },
					new Block { PosX = 130, PosY = -325, X = 3, Y = -5, Top = 1, Right = 1, Bottom = 8, Left = 5, CorrectRotate = 270 },
				}
			};
		}
	}
}