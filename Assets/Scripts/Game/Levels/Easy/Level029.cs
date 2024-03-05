using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Easy
{
	public abstract class Level029
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 29,
				MatchsToWin = 14,
				ThreeStarsLimit = 34,
				TwoStarsLimit = 41,
				BlockSizes = 100,
				Blocks = new List<Block>
				{
					new Block { PosX = 300, PosY = 50, Fixed = false, X = 0, Y = 0, Top = 5, Right = 7, Bottom = 2, Left = 2, CorrectRotate = 270 },
					new Block { PosX = 200, PosY = 50, Fixed = false, X = -1, Y = 0, Top = 3, Right = 7, Bottom = 7, Left = 5, CorrectRotate = 180 },
					new Block { PosX = 200, PosY = 150, Fixed = false, X = -1, Y = 1, Top = 0, Right = 5, Bottom = 4, Left = 5, CorrectRotate = 180 },
					new Block { PosX = 200, PosY = -50, Fixed = false, X = -1, Y = -1, Top = 1, Right = 7, Bottom = 3, Left = 4, CorrectRotate = 270 },
					new Block { PosX = 100, PosY = 50, Fixed = false, X = -2, Y = 0, Top = 1, Right = 4, Bottom = 2, Left = 0, CorrectRotate = 180 },
					new Block { PosX = 100, PosY = -50, Fixed = false, X = -2, Y = -1, Top = 6, Right = 4, Bottom = 5, Left = 2, CorrectRotate = 0 },
					new Block { PosX = 100, PosY = -150, Fixed = false, X = -2, Y = -2, Top = 2, Right = 7, Bottom = 5, Left = 1, CorrectRotate = 0 },
					new Block { PosX = 0, PosY = -50, Fixed = false, X = -3, Y = -1, Top = 5, Right = 0, Bottom = 3, Left = 6, CorrectRotate = 270 },
					new Block { PosX = -100, PosY = -50, Fixed = false, X = -4, Y = -1, Top = 1, Right = 6, Bottom = 1, Left = 4, CorrectRotate = 180 },
					new Block { PosX = -200, PosY = -50, Fixed = false, X = -5, Y = -1, Top = 1, Right = 1, Bottom = 4, Left = 2, CorrectRotate = 270 },
					new Block { PosX = -200, PosY = 50, Fixed = false, X = -5, Y = 0, Top = 0, Right = 5, Bottom = 1, Left = 1, CorrectRotate = 270 },
					new Block { PosX = -200, PosY = -150, Fixed = false, X = -5, Y = -2, Top = 6, Right = 0, Bottom = 3, Left = 6, CorrectRotate = 270 },
					new Block { PosX = -300, PosY = -50, Fixed = false, X = -6, Y = -1, Top = 5, Right = 3, Bottom = 5, Left = 0, CorrectRotate = 0 },
					new Block { PosX = -200, PosY = 150, Fixed = false, X = -5, Y = 1, Top = 6, Right = 4, Bottom = 6, Left = 5, CorrectRotate = 0 }
				}
			};
		}
	}
}