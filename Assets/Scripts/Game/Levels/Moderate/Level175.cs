using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Moderate
{
	public abstract class Level175
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 175,
				MatchsToWin = 40,
				ThreeStarsLimit = 63,
				TwoStarsLimit = 75,
				BlockSizes = 100,
				Blocks = new List<Block>
				{
					new Block { PosX = -100, PosY = -150, X = 0, Y = 0, Top = 6, Right = 6, Bottom = 2, Left = 7, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = -150, X = 1, Y = 0, Top = -1, Right = 5, Bottom = 1, Left = -1, CorrectRotate = 180 },
					new Block { PosX = -100, PosY = -250, X = 0, Y = -1, Top = 3, Right = 8, Bottom = 0, Left = 4, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = -50, X = 1, Y = 1, Top = -2, Right = 1, Bottom = 2, Left = 6, CorrectRotate = 90 },
					new Block { PosX = 100, PosY = -150, X = 2, Y = 0, Top = -2, Right = 8, Bottom = 9, Left = 3, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = -250, X = 1, Y = -1, Top = 2, Right = 3, Bottom = 8, Left = 4, CorrectRotate = 180 },
					new Block { PosX = -100, PosY = -350, X = 0, Y = -2, Top = 9, Right = 7, Bottom = -1, Left = 4, CorrectRotate = 270 },
					new Block { PosX = -200, PosY = -250, X = -1, Y = -1, Top = -1, Right = 1, Bottom = 5, Left = 2, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = 50, X = 1, Y = 2, Top = -1, Right = 9, Bottom = 1, Left = 6, CorrectRotate = 90 },
					new Block { PosX = 100, PosY = -50, X = 2, Y = 1, Top = 5, Right = -2, Bottom = 5, Left = 7, CorrectRotate = 270 },
					new Block { PosX = -100, PosY = -50, X = 0, Y = 1, Top = 5, Right = -1, Bottom = 9, Left = 1, CorrectRotate = 90 },
					new Block { PosX = 100, PosY = -250, X = 2, Y = -1, Top = 4, Right = 3, Bottom = 9, Left = 7, CorrectRotate = 180 },
					new Block { PosX = -200, PosY = -350, X = -1, Y = -2, Top = 4, Right = 6, Bottom = 8, Left = 8, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = 150, X = 1, Y = 3, Top = 4, Right = 9, Bottom = 1, Left = -2, CorrectRotate = 90 },
					new Block { PosX = 100, PosY = 50, X = 2, Y = 2, Top = 6, Right = 9, Bottom = 9, Left = 0, CorrectRotate = 90 },
					new Block { PosX = -100, PosY = 50, X = 0, Y = 2, Top = 8, Right = -1, Bottom = -1, Left = 8, CorrectRotate = 180 },
					new Block { PosX = 200, PosY = -50, X = 3, Y = 1, Top = 2, Right = 5, Bottom = -2, Left = 3, CorrectRotate = 90 },
					new Block { PosX = -200, PosY = -50, X = -1, Y = 1, Top = 3, Right = -1, Bottom = 2, Left = 7, CorrectRotate = 90 },
					new Block { PosX = 200, PosY = -250, X = 3, Y = -1, Top = 0, Right = 0, Bottom = -1, Left = 3, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = 250, X = 1, Y = 4, Top = -2, Right = -2, Bottom = 9, Left = 9, CorrectRotate = 270 },
					new Block { PosX = 100, PosY = 150, X = 2, Y = 3, Top = 6, Right = 7, Bottom = 8, Left = -2, CorrectRotate = 90 },
					new Block { PosX = -100, PosY = 150, X = 0, Y = 3, Top = 3, Right = 8, Bottom = 0, Left = 9, CorrectRotate = 270 },
					new Block { PosX = 200, PosY = 50, X = 3, Y = 2, Top = 2, Right = 2, Bottom = -2, Left = 4, CorrectRotate = 270 },
					new Block { PosX = -200, PosY = 50, X = -1, Y = 2, Top = 4, Right = 7, Bottom = 8, Left = 8, CorrectRotate = 90 },
					new Block { PosX = 300, PosY = -50, X = 4, Y = 1, Top = 9, Right = 3, Bottom = 1, Left = 4, CorrectRotate = 90 },
					new Block { PosX = -300, PosY = -50, X = -2, Y = 1, Top = 1, Right = 7, Bottom = 4, Left = 8, CorrectRotate = 90 },
					new Block { PosX = 200, PosY = -150, X = 3, Y = 0, Top = 2, Right = 7, Bottom = 4, Left = 4, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = 350, X = 1, Y = 5, Top = 8, Right = -2, Bottom = 5, Left = 1, CorrectRotate = 270 },
				}
			};
		}
	}
}