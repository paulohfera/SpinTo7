using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Easy
{
	public abstract class Level038
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 38,
				MatchsToWin = 24,
				ThreeStarsLimit = 51,
				TwoStarsLimit = 61,
				BlockSizes = 100,
				Blocks = new List<Block>
				{
					new Block { PosX = -200, PosY = 100, X = 0, Y = 0, Top = 6, Right = 0, Bottom = 7, Left = 6, CorrectRotate = 90 },
					new Block { PosX = -100, PosY = 100, X = 1, Y = 0, Top = 5, Right = 4, Bottom = 0, Left = 3, CorrectRotate = 270 },
					new Block { PosX = -200, PosY = 0, X = 0, Y = -1, Top = 3, Right = 2, Bottom = 3, Left = 1, CorrectRotate = 270 },
					new Block { PosX = -300, PosY = 0, X = -1, Y = -1, Top = 0, Right = 1, Bottom = 4, Left = 4, CorrectRotate = 90 },
					new Block { PosX = -300, PosY = 100, X = -1, Y = 0, Top = 1, Right = 5, Bottom = 1, Left = 6, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = 100, X = 2, Y = 0, Top = 6, Right = 2, Bottom = 3, Left = 0, CorrectRotate = 180 },
					new Block { PosX = 100, PosY = 100, X = 3, Y = 0, Top = 7, Right = 4, Bottom = 7, Left = 4, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = 0, X = 2, Y = -1, Top = 1, Right = 2, Bottom = 3, Left = 1, CorrectRotate = 270 },
					new Block { PosX = 100, PosY = 200, X = 3, Y = 1, Top = 1, Right = 3, Bottom = 3, Left = 3, CorrectRotate = 270 },
					new Block { PosX = 200, PosY = 100, X = 4, Y = 0, Top = 0, Right = 5, Bottom = 0, Left = 5, CorrectRotate = 270 },
					new Block { PosX = 100, PosY = 0, X = 3, Y = -1, Top = 6, Right = 6, Bottom = 3, Left = 1, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = -100, X = 2, Y = -2, Top = 5, Right = 6, Bottom = 1, Left = 5, CorrectRotate = 270 },
					new Block { PosX = -100, PosY = 0, X = 1, Y = -1, Top = 1, Right = 4, Bottom = 3, Left = 4, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = 200, X = 2, Y = 1, Top = 4, Right = 1, Bottom = 2, Left = 4, CorrectRotate = 180 },
					new Block { PosX = 300, PosY = 100, X = 5, Y = 0, Top = 2, Right = 7, Bottom = 1, Left = 0, CorrectRotate = 180 },
					new Block { PosX = 200, PosY = 0, X = 4, Y = -1, Top = 6, Right = 2, Bottom = 2, Left = 6, CorrectRotate = 90 },
					new Block { PosX = 100, PosY = -100, X = 3, Y = -2, Top = 2, Right = 1, Bottom = 0, Left = 4, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = -200, X = 2, Y = -3, Top = 0, Right = 0, Bottom = 1, Left = 1, CorrectRotate = 270 },
				}
			};
		}
	}
}
