using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hard
{
	public abstract class Level296
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 296,
				MatchsToWin = 34,
				ThreeStarsLimit = 63,
				TwoStarsLimit = 76,
				BlockSizes = 100,
				Blocks = new List<Block>
				{
					new Block { PosX = 300, PosY = 0, X = 0, Y = 0, Top = 1, Right = 5, Bottom = 4, Left = 5, CorrectRotate = 180 },
					new Block { PosX = 200, PosY = 0, X = -1, Y = 0, Top = 2, Right = 0, Bottom = 2, Left = 4, CorrectRotate = 90 },
					new Block { PosX = 200, PosY = 100, X = -1, Y = 1, Top = 2, Right = 7, Bottom = 7, Left = 0, CorrectRotate = 270 },
					new Block { PosX = 100, PosY = 0, X = -2, Y = 0, Top = 5, Right = 1, Bottom = 7, Left = -2, CorrectRotate = 270 },
					new Block { PosX = 200, PosY = 200, X = -1, Y = 2, Top = 7, Right = -2, Bottom = -1, Left = 2, CorrectRotate = 180 },
					new Block { PosX = 300, PosY = 100, X = 0, Y = 1, Top = 4, Right = 3, Bottom = 5, Left = 0, CorrectRotate = 270 },
					new Block { PosX = 100, PosY = 100, X = -2, Y = 1, Top = 0, Right = 9, Bottom = 8, Left = 9, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = 0, X = -3, Y = 0, Top = 0, Right = 6, Bottom = 0, Left = 5, CorrectRotate = 90 },
					new Block { PosX = -100, PosY = 0, X = -4, Y = 0, Top = 7, Right = 5, Bottom = 9, Left = 4, CorrectRotate = 270 },
					new Block { PosX = -100, PosY = 100, X = -4, Y = 1, Top = 3, Right = 4, Bottom = -1, Left = 8, CorrectRotate = 180 },
					new Block { PosX = -100, PosY = -100, X = -4, Y = -1, Top = -2, Right = 7, Bottom = 2, Left = 2, CorrectRotate = 180 },
					new Block { PosX = -200, PosY = 0, X = -5, Y = 0, Top = 5, Right = 1, Bottom = -2, Left = -2, CorrectRotate = 180 },
					new Block { PosX = -100, PosY = 200, X = -4, Y = 2, Top = 1, Right = 8, Bottom = 5, Left = 6, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = 100, X = -3, Y = 1, Top = -1, Right = 6, Bottom = -1, Left = 1, CorrectRotate = 90 },
					new Block { PosX = -100, PosY = -200, X = -4, Y = -2, Top = 5, Right = 2, Bottom = 9, Left = 5, CorrectRotate = 180 },
					new Block { PosX = -200, PosY = -100, X = -5, Y = -1, Top = 0, Right = 8, Bottom = 2, Left = 2, CorrectRotate = 270 },
					new Block { PosX = -200, PosY = 100, X = -5, Y = 1, Top = 3, Right = 9, Bottom = 1, Left = 9, CorrectRotate = 270 },
					new Block { PosX = -200, PosY = -200, X = -5, Y = -2, Top = -1, Right = -1, Bottom = 5, Left = 5, CorrectRotate = 90 },
					new Block { PosX = -200, PosY = 200, X = -5, Y = 2, Top = -2, Right = 7, Bottom = 4, Left = 2, CorrectRotate = 180 },
					new Block { PosX = -200, PosY = -300, X = -5, Y = -3, Top = 9, Right = 2, Bottom = 4, Left = 3, CorrectRotate = 90 },
					new Block { PosX = -300, PosY = -200, X = -6, Y = -2, Top = 8, Right = 4, Bottom = 7, Left = 8, CorrectRotate = 180 },
					new Block { PosX = -200, PosY = 300, X = -5, Y = 3, Top = 3, Right = 0, Bottom = -2, Left = 1, CorrectRotate = 180 },
					new Block { PosX = -300, PosY = 200, X = -6, Y = 2, Top = 6, Right = 9, Bottom = 9, Left = 0, CorrectRotate = 180 },
					new Block { PosX = -100, PosY = -300, X = -4, Y = -3, Top = 6, Right = 3, Bottom = 2, Left = 8, CorrectRotate = 180 },
					new Block { PosX = -300, PosY = -300, X = -6, Y = -3, Top = 1, Right = -1, Bottom = -2, Left = 7, CorrectRotate = 90 },
				}
			};
		}
	}
}