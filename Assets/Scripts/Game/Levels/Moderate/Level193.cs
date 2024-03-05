using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Moderate
{
	public abstract class Level193
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 193,
				MatchsToWin = 46,
				ThreeStarsLimit = 70,
				TwoStarsLimit = 84,
				BlockSizes = 110,
				Blocks = new List<Block>
				{
					new Block { PosX = 275, PosY = -330, X = 0, Y = 0, Top = 9, Right = 0, Bottom = 8, Left = 3, CorrectRotate = 180 },
					new Block { PosX = 165, PosY = -330, X = -1, Y = 0, Top = 1, Right = -1, Bottom = 9, Left = 7, CorrectRotate = 180 },
					new Block { PosX = 55, PosY = -330, X = -2, Y = 0, Top = 3, Right = 8, Bottom = 8, Left = 9, CorrectRotate = 90 },
					new Block { PosX = 55, PosY = -220, X = -2, Y = 1, Top = -1, Right = 3, Bottom = 7, Left = 1, CorrectRotate = 180 },
					new Block { PosX = -55, PosY = -220, X = -3, Y = 1, Top = 2, Right = 6, Bottom = 4, Left = 6, CorrectRotate = 90 },
					new Block { PosX = -55, PosY = -110, X = -3, Y = 2, Top = -2, Right = 1, Bottom = -1, Left = 1, CorrectRotate = 90 },
					new Block { PosX = -55, PosY = -330, X = -3, Y = 0, Top = 4, Right = 0, Bottom = 8, Left = 1, CorrectRotate = 270 },
					new Block { PosX = -55, PosY = 0, X = -3, Y = 3, Top = 0, Right = 6, Bottom = -1, Left = 8, CorrectRotate = 270 },
					new Block { PosX = 55, PosY = -110, X = -2, Y = 2, Top = 0, Right = 8, Bottom = 3, Left = 7, CorrectRotate = 180 },
					new Block { PosX = -55, PosY = -440, X = -3, Y = -1, Top = 5, Right = 7, Bottom = 2, Left = 8, CorrectRotate = 90 },
					new Block { PosX = -165, PosY = -330, X = -4, Y = 0, Top = -1, Right = -1, Bottom = 9, Left = 3, CorrectRotate = 270 },
					new Block { PosX = -55, PosY = 110, X = -3, Y = 4, Top = -1, Right = 9, Bottom = 2, Left = 8, CorrectRotate = 180 },
					new Block { PosX = 55, PosY = 0, X = -2, Y = 3, Top = 7, Right = 7, Bottom = 4, Left = 4, CorrectRotate = 90 },
					new Block { PosX = -165, PosY = 0, X = -4, Y = 3, Top = 6, Right = 5, Bottom = 9, Left = 8, CorrectRotate = 180 },
					new Block { PosX = -55, PosY = 220, X = -3, Y = 5, Top = 5, Right = 7, Bottom = -1, Left = -2, CorrectRotate = 180 },
					new Block { PosX = 55, PosY = 110, X = -2, Y = 4, Top = -1, Right = 0, Bottom = -1, Left = -1, CorrectRotate = 270 },
					new Block { PosX = -165, PosY = 110, X = -4, Y = 4, Top = -1, Right = 4, Bottom = -2, Left = -2, CorrectRotate = 90 },
					new Block { PosX = 165, PosY = 0, X = -1, Y = 3, Top = -2, Right = 9, Bottom = 3, Left = 5, CorrectRotate = 270 },
					new Block { PosX = -165, PosY = -110, X = -4, Y = 2, Top = 6, Right = 2, Bottom = 1, Left = 9, CorrectRotate = 180 },
					new Block { PosX = -55, PosY = 330, X = -3, Y = 6, Top = 6, Right = 8, Bottom = 9, Left = 9, CorrectRotate = 270 },
					new Block { PosX = 55, PosY = 220, X = -2, Y = 5, Top = 9, Right = 4, Bottom = 5, Left = 8, CorrectRotate = 90 },
					new Block { PosX = 165, PosY = 220, X = -1, Y = 5, Top = -2, Right = 2, Bottom = 1, Left = 5, CorrectRotate = 180 },
					new Block { PosX = 165, PosY = 330, X = -1, Y = 6, Top = 6, Right = 6, Bottom = 0, Left = 6, CorrectRotate = 90 },
					new Block { PosX = 275, PosY = 220, X = 0, Y = 5, Top = 2, Right = 0, Bottom = 4, Left = 3, CorrectRotate = 90 },
					new Block { PosX = 165, PosY = 110, X = -1, Y = 4, Top = 8, Right = 9, Bottom = 4, Left = 2, CorrectRotate = 90 },
					new Block { PosX = 55, PosY = 330, X = -2, Y = 6, Top = 1, Right = 3, Bottom = 1, Left = 6, CorrectRotate = 270 },
					new Block { PosX = 275, PosY = 110, X = 0, Y = 4, Top = 3, Right = 4, Bottom = 5, Left = 6, CorrectRotate = 90 },
					new Block { PosX = 55, PosY = 440, X = -2, Y = 7, Top = 8, Right = 3, Bottom = 8, Left = 1, CorrectRotate = 90 },
					new Block { PosX = -165, PosY = 220, X = -4, Y = 5, Top = 9, Right = 2, Bottom = 0, Left = 3, CorrectRotate = 90 },
					new Block { PosX = 275, PosY = 0, X = 0, Y = 3, Top = 8, Right = 9, Bottom = 1, Left = 6, CorrectRotate = 180 },
					new Block { PosX = 165, PosY = -110, X = -1, Y = 2, Top = 0, Right = -2, Bottom = 4, Left = 0, CorrectRotate = 90 },
					new Block { PosX = -275, PosY = -110, X = -5, Y = 2, Top = 6, Right = 7, Bottom = 5, Left = 7, CorrectRotate = 90 },
				}
			};
		}
	}
}