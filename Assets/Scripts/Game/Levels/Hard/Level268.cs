using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hard
{
	public abstract class Level268
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 268,
				MatchsToWin = 24,
				ThreeStarsLimit = 47,
				TwoStarsLimit = 57,
				BlockSizes = 100,
				Blocks = new List<Block>
				{
					new Block { PosX = 0, PosY = 100, X = 0, Y = 0, Top = 2, Right = 9, Bottom = -1, Left = -1, CorrectRotate = 180 },
					new Block { PosX = -100, PosY = 100, X = -1, Y = 0, Top = -2, Right = 7, Bottom = 8, Left = 9, CorrectRotate = 270 },
					new Block { PosX = -100, PosY = 200, X = -1, Y = 1, Top = 7, Right = -2, Bottom = 8, Left = -2, CorrectRotate = 90 },
					new Block { PosX = -100, PosY = 0, X = -1, Y = -1, Top = 7, Right = 5, Bottom = 1, Left = 0, CorrectRotate = 270 },
					new Block { PosX = -200, PosY = 100, X = -2, Y = 0, Top = -1, Right = 4, Bottom = 1, Left = 3, CorrectRotate = 270 },
					new Block { PosX = -200, PosY = 200, X = -2, Y = 1, Top = 6, Right = 8, Bottom = 0, Left = 4, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = 0, X = 0, Y = -1, Top = 1, Right = 3, Bottom = 0, Left = 5, CorrectRotate = 270 },
					new Block { PosX = -200, PosY = 0, X = -2, Y = -1, Top = 6, Right = 9, Bottom = 9, Left = 3, CorrectRotate = 270 },
					new Block { PosX = -300, PosY = 100, X = -3, Y = 0, Top = -2, Right = -2, Bottom = 8, Left = 6, CorrectRotate = 180 },
					new Block { PosX = -200, PosY = 300, X = -2, Y = 2, Top = 9, Right = 3, Bottom = 7, Left = -1, CorrectRotate = 90 },
					new Block { PosX = -300, PosY = 200, X = -3, Y = 1, Top = 1, Right = -1, Bottom = 5, Left = -1, CorrectRotate = 270 },
					new Block { PosX = 100, PosY = 0, X = 1, Y = -1, Top = 1, Right = 6, Bottom = -2, Left = 7, CorrectRotate = 180 },
					new Block { PosX = 100, PosY = -100, X = 1, Y = -2, Top = 9, Right = 6, Bottom = -1, Left = 9, CorrectRotate = 90 },
					new Block { PosX = 200, PosY = -100, X = 2, Y = -2, Top = 8, Right = 7, Bottom = -1, Left = 1, CorrectRotate = 90 },
					new Block { PosX = 100, PosY = -200, X = 1, Y = -3, Top = 7, Right = -2, Bottom = 2, Left = 4, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = -100, X = 0, Y = -2, Top = 9, Right = 7, Bottom = 4, Left = -2, CorrectRotate = 180 },
					new Block { PosX = 300, PosY = -100, X = 3, Y = -2, Top = 1, Right = 3, Bottom = 8, Left = 0, CorrectRotate = 270 },
					new Block { PosX = 200, PosY = -200, X = 2, Y = -3, Top = 0, Right = 5, Bottom = 6, Left = 4, CorrectRotate = 180 },
					new Block { PosX = 100, PosY = -300, X = 1, Y = -4, Top = 2, Right = -2, Bottom = 3, Left = 6, CorrectRotate = 180 },
				}
			};
		}
	}
}