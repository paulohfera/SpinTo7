using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Easy
{
	public abstract class Level052
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 52,
				MatchsToWin = 32,
				ThreeStarsLimit = 65,
				TwoStarsLimit = 78,
				BlockSizes = 100,
				Blocks = new List<Block>
				{
					new Block { PosX = -200, PosY = 150, X = 0, Y = 0, Top = 6, Right = 4, Bottom = 2, Left = 3, CorrectRotate = 180 },
					new Block { PosX = -200, PosY = 50, X = 0, Y = -1, Top = 3, Right = 7, Bottom = 6, Left = 1, CorrectRotate = 270 },
					new Block { PosX = -300, PosY = 150, X = -1, Y = 0, Top = 7, Right = 0, Bottom = 2, Left = 3, CorrectRotate = 180 },
					new Block { PosX = -100, PosY = 50, X = 1, Y = -1, Top = 4, Right = 3, Bottom = 1, Left = 2, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = 50, X = 2, Y = -1, Top = 2, Right = 6, Bottom = 4, Left = 2, CorrectRotate = 180 },
					new Block { PosX = -100, PosY = -50, X = 1, Y = -2, Top = 7, Right = 6, Bottom = 3, Left = 5, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = 150, X = 2, Y = 0, Top = 3, Right = 1, Bottom = 2, Left = 1, CorrectRotate = 180 },
					new Block { PosX = 100, PosY = 50, X = 3, Y = -1, Top = 2, Right = 5, Bottom = 5, Left = 6, CorrectRotate = 180 },
					new Block { PosX = 100, PosY = -50, X = 3, Y = -2, Top = 7, Right = 6, Bottom = 5, Left = 3, CorrectRotate = 180 },
					new Block { PosX = 200, PosY = -50, X = 4, Y = -2, Top = 4, Right = 6, Bottom = 4, Left = 7, CorrectRotate = 270 },
					new Block { PosX = 100, PosY = -150, X = 3, Y = -3, Top = 3, Right = 6, Bottom = 2, Left = 0, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = -50, X = 2, Y = -2, Top = 0, Right = 5, Bottom = 1, Left = 2, CorrectRotate = 90 },
					new Block { PosX = 200, PosY = -150, X = 4, Y = -3, Top = 4, Right = 4, Bottom = 1, Left = 4, CorrectRotate = 180 },
					new Block { PosX = 100, PosY = 150, X = 3, Y = 0, Top = 3, Right = 2, Bottom = 6, Left = 3, CorrectRotate = 270 },
					new Block { PosX = -100, PosY = 150, X = 1, Y = 0, Top = 4, Right = 4, Bottom = 3, Left = 6, CorrectRotate = 180 },
					new Block { PosX = 300, PosY = -50, X = 5, Y = -2, Top = 1, Right = 1, Bottom = 3, Left = 1, CorrectRotate = 270 },
					new Block { PosX = 100, PosY = -250, X = 3, Y = -4, Top = 5, Right = 7, Bottom = 1, Left = 4, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = -150, X = 2, Y = -3, Top = 1, Right = 7, Bottom = 5, Left = 5, CorrectRotate = 180 },
					new Block { PosX = 300, PosY = -150, X = 5, Y = -3, Top = 7, Right = 2, Bottom = 3, Left = 6, CorrectRotate = 270 },
					new Block { PosX = 200, PosY = -250, X = 4, Y = -4, Top = 3, Right = 3, Bottom = 5, Left = 2, CorrectRotate = 90 },
					new Block { PosX = 100, PosY = 250, X = 3, Y = 1, Top = 4, Right = 7, Bottom = 4, Left = 4, CorrectRotate = 90 },
					new Block { PosX = 200, PosY = 150, X = 4, Y = 0, Top = 4, Right = 1, Bottom = 2, Left = 0, CorrectRotate = 90 },
					new Block { PosX = -100, PosY = 250, X = 1, Y = 1, Top = 0, Right = 4, Bottom = 6, Left = 4, CorrectRotate = 90 },
					new Block { PosX = 300, PosY = 50, X = 5, Y = -1, Top = 3, Right = 6, Bottom = 0, Left = 4, CorrectRotate = 270 },
				}
			};
		}
	}
}