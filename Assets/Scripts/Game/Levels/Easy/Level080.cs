using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Easy
{
	public abstract class Level080
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 80,
				MatchsToWin = 38,
				ThreeStarsLimit = 78,
				TwoStarsLimit = 93,
				BlockSizes = 100,
				Blocks = new List<Block>
				{
					new Block { PosX = 100, PosY = 100, X = 0, Y = 0, Top = 2, Right = 7, Bottom = 7, Left = 7, CorrectRotate = 90 },
					new Block { PosX = 100, PosY = 200, X = 0, Y = 1, Top = 0, Right = 3, Bottom = 3, Left = 0, CorrectRotate = 90 },
					new Block { PosX = 200, PosY = 100, X = 1, Y = 0, Top = 3, Right = 0, Bottom = 5, Left = 2, CorrectRotate = 180 },
					new Block { PosX = 100, PosY = 0, X = 0, Y = -1, Top = 3, Right = 1, Bottom = 4, Left = 0, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = 100, X = -1, Y = 0, Top = 0, Right = 5, Bottom = 4, Left = 5, CorrectRotate = 180 },
					new Block { PosX = 100, PosY = 300, X = 0, Y = 2, Top = 1, Right = 3, Bottom = 6, Left = 4, CorrectRotate = 90 },
					new Block { PosX = 200, PosY = 200, X = 1, Y = 1, Top = 2, Right = 4, Bottom = 3, Left = 5, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = 200, X = -1, Y = 1, Top = 3, Right = 6, Bottom = 1, Left = 7, CorrectRotate = 180 },
					new Block { PosX = 300, PosY = 100, X = 2, Y = 0, Top = 0, Right = 5, Bottom = 6, Left = 5, CorrectRotate = 180 },
					new Block { PosX = 200, PosY = 0, X = 1, Y = -1, Top = 0, Right = 4, Bottom = 4, Left = 0, CorrectRotate = 180 },
					new Block { PosX = 100, PosY = -100, X = 0, Y = -2, Top = 3, Right = 6, Bottom = 5, Left = 6, CorrectRotate = 90 },
					new Block { PosX = 100, PosY = -200, X = 0, Y = -3, Top = 5, Right = 7, Bottom = 1, Left = 1, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = -100, X = -1, Y = -2, Top = 4, Right = 0, Bottom = 3, Left = 7, CorrectRotate = 270 },
					new Block { PosX = 200, PosY = -200, X = 1, Y = -3, Top = 3, Right = 2, Bottom = 3, Left = 3, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = -200, X = -1, Y = -3, Top = 4, Right = 7, Bottom = 6, Left = 5, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = 0, X = -1, Y = -1, Top = 0, Right = 1, Bottom = 7, Left = 3, CorrectRotate = 180 },
					new Block { PosX = 300, PosY = -200, X = 2, Y = -3, Top = 3, Right = 7, Bottom = 4, Left = 6, CorrectRotate = 270 },
					new Block { PosX = 200, PosY = -300, X = 1, Y = -4, Top = 5, Right = 7, Bottom = 2, Left = 4, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = -300, X = -1, Y = -4, Top = 5, Right = 2, Bottom = 1, Left = 3, CorrectRotate = 90 },
					new Block { PosX = -100, PosY = -200, X = -2, Y = -3, Top = 3, Right = 0, Bottom = 0, Left = 5, CorrectRotate = 270 },
					new Block { PosX = -100, PosY = 0, X = -2, Y = -1, Top = 5, Right = 7, Bottom = 6, Left = 6, CorrectRotate = 180 },
					new Block { PosX = -200, PosY = 0, X = -3, Y = -1, Top = 5, Right = 7, Bottom = 2, Left = 0, CorrectRotate = 180 },
					new Block { PosX = -200, PosY = 100, X = -3, Y = 0, Top = 6, Right = 5, Bottom = 6, Left = 3, CorrectRotate = 270 },
					new Block { PosX = -200, PosY = -100, X = -3, Y = -2, Top = 4, Right = 0, Bottom = 1, Left = 2, CorrectRotate = 270 },
					new Block { PosX = -300, PosY = 0, X = -4, Y = -1, Top = 4, Right = 4, Bottom = 0, Left = 6, CorrectRotate = 90 },
					new Block { PosX = -200, PosY = 200, X = -3, Y = 1, Top = 6, Right = 6, Bottom = 4, Left = 4, CorrectRotate = 90 },
					new Block { PosX = -100, PosY = 100, X = -2, Y = 0, Top = 2, Right = 1, Bottom = 1, Left = 5, CorrectRotate = 270 },
					new Block { PosX = -200, PosY = -200, X = -3, Y = -3, Top = 4, Right = 5, Bottom = 7, Left = 7, CorrectRotate = 180 },
					new Block { PosX = -300, PosY = 100, X = -4, Y = 0, Top = 1, Right = 3, Bottom = 1, Left = 1, CorrectRotate = 270 },
				}
			};
		}
	}
}