using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hard
{
	public abstract class Level282
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 282,
				MatchsToWin = 28,
				ThreeStarsLimit = 54,
				TwoStarsLimit = 66,
				BlockSizes = 100,
				Blocks = new List<Block>
				{
					new Block { PosX = 200, PosY = 200, X = 0, Y = 0, Top = 9, Right = 1, Bottom = 1, Left = 1, CorrectRotate = 180 },
					new Block { PosX = 300, PosY = 200, X = 1, Y = 0, Top = 1, Right = 6, Bottom = 9, Left = 2, CorrectRotate = 180 },
					new Block { PosX = 200, PosY = 100, X = 0, Y = -1, Top = -2, Right = 8, Bottom = -2, Left = 6, CorrectRotate = 180 },
					new Block { PosX = 100, PosY = 200, X = -1, Y = 0, Top = 6, Right = 6, Bottom = 9, Left = 7, CorrectRotate = 270 },
					new Block { PosX = 100, PosY = 100, X = -1, Y = -1, Top = -1, Right = 0, Bottom = 5, Left = 1, CorrectRotate = 270 },
					new Block { PosX = 100, PosY = 0, X = -1, Y = -2, Top = 4, Right = 7, Bottom = -1, Left = 8, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = 100, X = -2, Y = -1, Top = 2, Right = 5, Bottom = 3, Left = 9, CorrectRotate = 270 },
					new Block { PosX = 200, PosY = 0, X = 0, Y = -2, Top = 6, Right = 8, Bottom = 9, Left = 8, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = 0, X = -2, Y = -2, Top = 4, Right = 0, Bottom = 2, Left = 3, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = -100, X = -2, Y = -3, Top = -1, Right = 1, Bottom = 3, Left = -1, CorrectRotate = 180 },
					new Block { PosX = -100, PosY = 0, X = -3, Y = -2, Top = -2, Right = 0, Bottom = -2, Left = 7, CorrectRotate = 180 },
					new Block { PosX = 100, PosY = -100, X = -1, Y = -3, Top = 2, Right = 8, Bottom = 8, Left = -1, CorrectRotate = 270 },
					new Block { PosX = -100, PosY = -100, X = -3, Y = -3, Top = 6, Right = 9, Bottom = 6, Left = 8, CorrectRotate = 90 },
					new Block { PosX = -100, PosY = 100, X = -3, Y = -1, Top = 4, Right = 9, Bottom = 4, Left = 7, CorrectRotate = 270 },
					new Block { PosX = 200, PosY = -100, X = 0, Y = -3, Top = 7, Right = 5, Bottom = 1, Left = 1, CorrectRotate = 180 },
					new Block { PosX = -100, PosY = -200, X = -3, Y = -4, Top = 5, Right = -1, Bottom = 7, Left = 7, CorrectRotate = 90 },
					new Block { PosX = -200, PosY = -100, X = -4, Y = -3, Top = 2, Right = 0, Bottom = 1, Left = 1, CorrectRotate = 90 },
					new Block { PosX = -100, PosY = 200, X = -3, Y = 0, Top = 5, Right = 7, Bottom = 4, Left = 0, CorrectRotate = 90 },
					new Block { PosX = -200, PosY = 100, X = -4, Y = -1, Top = 3, Right = -1, Bottom = 7, Left = 3, CorrectRotate = 180 },
					new Block { PosX = 300, PosY = -100, X = 1, Y = -3, Top = 9, Right = 7, Bottom = 6, Left = 6, CorrectRotate = 270 },
					new Block { PosX = 200, PosY = -200, X = 0, Y = -4, Top = 9, Right = 0, Bottom = -1, Left = 0, CorrectRotate = 270 },
					new Block { PosX = -300, PosY = -100, X = -5, Y = -3, Top = -2, Right = -1, Bottom = 5, Left = 6, CorrectRotate = 90 },
				}
			};
		}
	}
}