using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Moderate
{
	public abstract class Level149
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 149,
				MatchsToWin = 31,
				ThreeStarsLimit = 58,
				TwoStarsLimit = 69,
				BlockSizes = 100,
				Blocks = new List<Block>
				{
					new Block { PosX = 200, PosY = 50, X = 0, Y = 0, Top = -1, Right = 5, Bottom = 0, Left = 3, CorrectRotate = 270 },
					new Block { PosX = 100, PosY = 50, X = -1, Y = 0, Top = -2, Right = 4, Bottom = 0, Left = 7, CorrectRotate = 180 },
					new Block { PosX = 300, PosY = 50, X = 1, Y = 0, Top = 1, Right = -1, Bottom = 8, Left = 8, CorrectRotate = 270 },
					new Block { PosX = 200, PosY = -50, X = 0, Y = -1, Top = 0, Right = 3, Bottom = 2, Left = -1, CorrectRotate = 180 },
					new Block { PosX = 100, PosY = 150, X = -1, Y = 1, Top = 7, Right = 2, Bottom = -2, Left = 1, CorrectRotate = 180 },
					new Block { PosX = 100, PosY = -50, X = -1, Y = -1, Top = 5, Right = 6, Bottom = 9, Left = 4, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = 50, X = -2, Y = 0, Top = 3, Right = 7, Bottom = 9, Left = 6, CorrectRotate = 270 },
					new Block { PosX = -100, PosY = 50, X = -3, Y = 0, Top = 7, Right = 1, Bottom = 9, Left = -2, CorrectRotate = 180 },
					new Block { PosX = -100, PosY = 150, X = -3, Y = 1, Top = 1, Right = 2, Bottom = 3, Left = -2, CorrectRotate = 90 },
					new Block { PosX = -100, PosY = -50, X = -3, Y = -1, Top = 4, Right = 0, Bottom = 9, Left = 8, CorrectRotate = 90 },
					new Block { PosX = -200, PosY = 50, X = -4, Y = 0, Top = 2, Right = 6, Bottom = 1, Left = 6, CorrectRotate = 180 },
					new Block { PosX = 200, PosY = 150, X = 0, Y = 1, Top = 6, Right = 5, Bottom = 3, Left = 4, CorrectRotate = 90 },
					new Block { PosX = 100, PosY = -150, X = -1, Y = -2, Top = -1, Right = 1, Bottom = 2, Left = 4, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = -50, X = -2, Y = -1, Top = 1, Right = 1, Bottom = -2, Left = 0, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = 150, X = -2, Y = 1, Top = 4, Right = 0, Bottom = 5, Left = 1, CorrectRotate = 90 },
					new Block { PosX = -200, PosY = 150, X = -4, Y = 1, Top = 6, Right = 6, Bottom = 7, Left = 5, CorrectRotate = 270 },
					new Block { PosX = -100, PosY = -150, X = -3, Y = -2, Top = -2, Right = -1, Bottom = 6, Left = 4, CorrectRotate = 90 },
					new Block { PosX = -200, PosY = -50, X = -4, Y = -1, Top = 3, Right = 5, Bottom = 5, Left = 3, CorrectRotate = 180 },
					new Block { PosX = -300, PosY = 50, X = -5, Y = 0, Top = 4, Right = 2, Bottom = 1, Left = 2, CorrectRotate = 90 },
					new Block { PosX = 200, PosY = 250, X = 0, Y = 2, Top = 2, Right = 9, Bottom = 8, Left = 3, CorrectRotate = 180 },
					new Block { PosX = 300, PosY = 150, X = 1, Y = 1, Top = 6, Right = -1, Bottom = 4, Left = 1, CorrectRotate = 270 },
					new Block { PosX = 100, PosY = -250, X = -1, Y = -3, Top = -1, Right = 8, Bottom = 0, Left = 6, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = -250, X = -2, Y = -3, Top = 8, Right = 8, Bottom = 1, Left = 5, CorrectRotate = 270 },
				}
			};
		}
	}
}