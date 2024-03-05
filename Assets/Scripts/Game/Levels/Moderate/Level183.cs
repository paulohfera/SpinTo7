using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Moderate
{
	public abstract class Level183
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 183,
				MatchsToWin = 45,
				ThreeStarsLimit = 78,
				TwoStarsLimit = 93,
				BlockSizes = 110,
				Blocks = new List<Block>
				{
					new Block { PosX = -55, PosY = 0, X = 0, Y = 0, Top = 0, Right = 8, Bottom = -2, Left = 3, CorrectRotate = 180 },
					new Block { PosX = -55, PosY = 110, X = 0, Y = 1, Top = 9, Right = 9, Bottom = 1, Left = 9, CorrectRotate = 90 },
					new Block { PosX = 55, PosY = 0, X = 1, Y = 0, Top = 2, Right = 9, Bottom = 4, Left = 1, CorrectRotate = 270 },
					new Block { PosX = -55, PosY = -110, X = 0, Y = -1, Top = 1, Right = 0, Bottom = 3, Left = 7, CorrectRotate = 270 },
					new Block { PosX = -55, PosY = 220, X = 0, Y = 2, Top = -2, Right = 1, Bottom = 6, Left = 8, CorrectRotate = 180 },
					new Block { PosX = 55, PosY = 110, X = 1, Y = 1, Top = 6, Right = 6, Bottom = 1, Left = 6, CorrectRotate = 90 },
					new Block { PosX = -165, PosY = 110, X = -1, Y = 1, Top = 3, Right = 2, Bottom = 0, Left = -2, CorrectRotate = 180 },
					new Block { PosX = 165, PosY = 0, X = 2, Y = 0, Top = 5, Right = 0, Bottom = 1, Left = 6, CorrectRotate = 90 },
					new Block { PosX = 55, PosY = -110, X = 1, Y = -1, Top = 6, Right = -2, Bottom = 7, Left = -2, CorrectRotate = 90 },
					new Block { PosX = -55, PosY = -220, X = 0, Y = -2, Top = 6, Right = 7, Bottom = 6, Left = 4, CorrectRotate = 90 },
					new Block { PosX = -165, PosY = -110, X = -1, Y = -1, Top = 4, Right = 4, Bottom = -2, Left = 6, CorrectRotate = 270 },
					new Block { PosX = -55, PosY = 330, X = 0, Y = 3, Top = 1, Right = 8, Bottom = 5, Left = 5, CorrectRotate = 180 },
					new Block { PosX = 55, PosY = 220, X = 1, Y = 2, Top = 6, Right = 1, Bottom = -1, Left = -2, CorrectRotate = 270 },
					new Block { PosX = -165, PosY = 220, X = -1, Y = 2, Top = 7, Right = 0, Bottom = 7, Left = 6, CorrectRotate = 180 },
					new Block { PosX = -165, PosY = 0, X = -1, Y = 0, Top = 2, Right = 4, Bottom = -1, Left = 1, CorrectRotate = 90 },
					new Block { PosX = 165, PosY = 110, X = 2, Y = 1, Top = 6, Right = -1, Bottom = 8, Left = 7, CorrectRotate = 90 },
					new Block { PosX = 165, PosY = -110, X = 2, Y = -1, Top = 2, Right = 7, Bottom = 0, Left = 1, CorrectRotate = 270 },
					new Block { PosX = 55, PosY = -220, X = 1, Y = -2, Top = 1, Right = 9, Bottom = 1, Left = 6, CorrectRotate = 90 },
					new Block { PosX = -55, PosY = -330, X = 0, Y = -3, Top = 7, Right = 2, Bottom = 6, Left = 3, CorrectRotate = 270 },
					new Block { PosX = -165, PosY = -220, X = -1, Y = -2, Top = 1, Right = -1, Bottom = 6, Left = 3, CorrectRotate = 270 },
					new Block { PosX = -275, PosY = -110, X = -2, Y = -1, Top = 4, Right = 4, Bottom = 2, Left = 9, CorrectRotate = 180 },
					new Block { PosX = -55, PosY = 440, X = 0, Y = 4, Top = 2, Right = 6, Bottom = 1, Left = 8, CorrectRotate = 180 },
					new Block { PosX = 55, PosY = 330, X = 1, Y = 3, Top = 7, Right = 9, Bottom = 2, Left = 1, CorrectRotate = 270 },
					new Block { PosX = -275, PosY = 0, X = -2, Y = 0, Top = 1, Right = -2, Bottom = 5, Left = 5, CorrectRotate = 90 },
					new Block { PosX = 165, PosY = 220, X = 2, Y = 2, Top = 1, Right = 2, Bottom = 7, Left = 8, CorrectRotate = 90 },
					new Block { PosX = 275, PosY = -110, X = 3, Y = -1, Top = 1, Right = 0, Bottom = 5, Left = 7, CorrectRotate = 270 },
					new Block { PosX = 165, PosY = -220, X = 2, Y = -2, Top = 1, Right = 6, Bottom = 6, Left = 0, CorrectRotate = 270 },
					new Block { PosX = 55, PosY = -330, X = 1, Y = -3, Top = 3, Right = 0, Bottom = 1, Left = 8, CorrectRotate = 180 },
					new Block { PosX = -55, PosY = -440, X = 0, Y = -4, Top = 8, Right = -1, Bottom = 7, Left = 5, CorrectRotate = 270 },
					new Block { PosX = -165, PosY = -330, X = -1, Y = -3, Top = 1, Right = 8, Bottom = -1, Left = 8, CorrectRotate = 270 },
				}
			};
		}
	}
}