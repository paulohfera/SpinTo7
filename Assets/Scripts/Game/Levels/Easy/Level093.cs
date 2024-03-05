using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Easy
{
	public abstract class Level093
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 93,
				MatchsToWin = 47,
				ThreeStarsLimit = 94,
				TwoStarsLimit = 112,
				BlockSizes = 110,
				Blocks = new List<Block>
				{
					new Block { PosX = -55, PosY = 110, X = 0, Y = 0, Top = 0, Right = 5, Bottom = 2, Left = 3, CorrectRotate = 270 },
					new Block { PosX = -55, PosY = 220, X = 0, Y = 1, Top = 7, Right = 4, Bottom = 6, Left = 7, CorrectRotate = 270 },
					new Block { PosX = 55, PosY = 110, X = 1, Y = 0, Top = 3, Right = 0, Bottom = 7, Left = 7, CorrectRotate = 270 },
					new Block { PosX = -55, PosY = 0, X = 0, Y = -1, Top = 2, Right = 3, Bottom = 6, Left = 2, CorrectRotate = 270 },
					new Block { PosX = -165, PosY = 110, X = -1, Y = 0, Top = 0, Right = 5, Bottom = 6, Left = 5, CorrectRotate = 180 },
					new Block { PosX = -55, PosY = 330, X = 0, Y = 2, Top = 0, Right = 0, Bottom = 5, Left = 1, CorrectRotate = 180 },
					new Block { PosX = 55, PosY = 220, X = 1, Y = 1, Top = 0, Right = 0, Bottom = 4, Left = 7, CorrectRotate = 180 },
					new Block { PosX = -165, PosY = 220, X = -1, Y = 1, Top = 1, Right = 7, Bottom = 5, Left = 1, CorrectRotate = 180 },
					new Block { PosX = 165, PosY = 110, X = 2, Y = 0, Top = 0, Right = 1, Bottom = 4, Left = 4, CorrectRotate = 270 },
					new Block { PosX = 55, PosY = 0, X = 1, Y = -1, Top = 7, Right = 5, Bottom = 7, Left = 0, CorrectRotate = 180 },
					new Block { PosX = -55, PosY = -110, X = 0, Y = -2, Top = 4, Right = 7, Bottom = 7, Left = 4, CorrectRotate = 270 },
					new Block { PosX = -165, PosY = 0, X = -1, Y = -1, Top = 0, Right = 1, Bottom = 7, Left = 1, CorrectRotate = 180 },
					new Block { PosX = -275, PosY = 110, X = -2, Y = 0, Top = 2, Right = 2, Bottom = 4, Left = 1, CorrectRotate = 270 },
					new Block { PosX = -55, PosY = 440, X = 0, Y = 3, Top = 2, Right = 4, Bottom = 5, Left = 4, CorrectRotate = 180 },
					new Block { PosX = 55, PosY = 330, X = 1, Y = 2, Top = 6, Right = 3, Bottom = 6, Left = 7, CorrectRotate = 270 },
					new Block { PosX = -165, PosY = 330, X = -1, Y = 2, Top = 2, Right = 3, Bottom = 6, Left = 7, CorrectRotate = 180 },
					new Block { PosX = 165, PosY = 220, X = 2, Y = 1, Top = 0, Right = 1, Bottom = 0, Left = 3, CorrectRotate = 90 },
					new Block { PosX = -275, PosY = 220, X = -2, Y = 1, Top = 6, Right = 0, Bottom = 7, Left = 0, CorrectRotate = 180 },
					new Block { PosX = 275, PosY = 110, X = 3, Y = 0, Top = 7, Right = 3, Bottom = 7, Left = 5, CorrectRotate = 270 },
					new Block { PosX = 165, PosY = 0, X = 2, Y = -1, Top = 2, Right = 7, Bottom = 6, Left = 5, CorrectRotate = 180 },
					new Block { PosX = 55, PosY = -110, X = 1, Y = -2, Top = 5, Right = 4, Bottom = 3, Left = 0, CorrectRotate = 270 },
					new Block { PosX = -55, PosY = -220, X = 0, Y = -3, Top = 6, Right = 4, Bottom = 6, Left = 0, CorrectRotate = 270 },
					new Block { PosX = 55, PosY = -220, X = 1, Y = -3, Top = 1, Right = 3, Bottom = 6, Left = 1, CorrectRotate = 90 },
					new Block { PosX = -55, PosY = -330, X = 0, Y = -4, Top = 6, Right = 4, Bottom = 3, Left = 4, CorrectRotate = 180 },
					new Block { PosX = -165, PosY = -220, X = -1, Y = -3, Top = 1, Right = 3, Bottom = 7, Left = 6, CorrectRotate = 270 },
					new Block { PosX = 165, PosY = -220, X = 2, Y = -3, Top = 1, Right = 5, Bottom = 2, Left = 7, CorrectRotate = 90 },
					new Block { PosX = 55, PosY = -330, X = 1, Y = -4, Top = 6, Right = 3, Bottom = 6, Left = 7, CorrectRotate = 180 },
					new Block { PosX = -55, PosY = -440, X = 0, Y = -5, Top = 5, Right = 7, Bottom = 1, Left = 4, CorrectRotate = 180 },
					new Block { PosX = -165, PosY = -330, X = -1, Y = -4, Top = 3, Right = 6, Bottom = 4, Left = 3, CorrectRotate = 180 },
					new Block { PosX = -165, PosY = -110, X = -1, Y = -2, Top = 2, Right = 7, Bottom = 0, Left = 1, CorrectRotate = 90 },
					new Block { PosX = 275, PosY = -220, X = 3, Y = -3, Top = 0, Right = 0, Bottom = 5, Left = 7, CorrectRotate = 270 },
					new Block { PosX = 165, PosY = -330, X = 2, Y = -4, Top = 0, Right = 0, Bottom = 4, Left = 2, CorrectRotate = 90 },
				}
			};
		}
	}
}