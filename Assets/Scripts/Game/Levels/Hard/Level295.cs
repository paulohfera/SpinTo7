using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hard
{
	public abstract class Level295
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 295,
				MatchsToWin = 30,
				ThreeStarsLimit = 57,
				TwoStarsLimit = 69,
				BlockSizes = 110,
				Blocks = new List<Block>
				{
					new Block { PosX = 165, PosY = 0, X = 0, Y = 0, Top = 7, Right = 3, Bottom = 9, Left = 5, CorrectRotate = 270 },
					new Block { PosX = 55, PosY = 0, X = -1, Y = 0, Top = 4, Right = -2, Bottom = -2, Left = 6, CorrectRotate = 90 },
					new Block { PosX = 55, PosY = 110, X = -1, Y = 1, Top = 6, Right = 9, Bottom = 9, Left = 2, CorrectRotate = 270 },
					new Block { PosX = 55, PosY = -110, X = -1, Y = -1, Top = 5, Right = 1, Bottom = 5, Left = 3, CorrectRotate = 90 },
					new Block { PosX = -55, PosY = 0, X = -2, Y = 0, Top = 4, Right = 1, Bottom = 7, Left = 3, CorrectRotate = 180 },
					new Block { PosX = 55, PosY = 220, X = -1, Y = 2, Top = 9, Right = 5, Bottom = 3, Left = 5, CorrectRotate = 90 },
					new Block { PosX = 165, PosY = 220, X = 0, Y = 2, Top = 9, Right = 4, Bottom = 1, Left = 4, CorrectRotate = 180 },
					new Block { PosX = -165, PosY = 0, X = -3, Y = 0, Top = 6, Right = 6, Bottom = 2, Left = 1, CorrectRotate = 270 },
					new Block { PosX = 55, PosY = 330, X = -1, Y = 3, Top = 1, Right = 2, Bottom = 1, Left = -1, CorrectRotate = 270 },
					new Block { PosX = -55, PosY = 220, X = -2, Y = 2, Top = -2, Right = 5, Bottom = 3, Left = 7, CorrectRotate = 270 },
					new Block { PosX = 165, PosY = 330, X = 0, Y = 3, Top = 9, Right = 6, Bottom = 6, Left = 5, CorrectRotate = 270 },
					new Block { PosX = 275, PosY = 220, X = 1, Y = 2, Top = 0, Right = 3, Bottom = -1, Left = 8, CorrectRotate = 180 },
					new Block { PosX = 165, PosY = 110, X = 0, Y = 1, Top = 1, Right = -2, Bottom = 5, Left = 2, CorrectRotate = 90 },
					new Block { PosX = -275, PosY = 0, X = -4, Y = 0, Top = 3, Right = 9, Bottom = 5, Left = 7, CorrectRotate = 90 },
					new Block { PosX = 55, PosY = 440, X = -1, Y = 4, Top = 8, Right = 6, Bottom = -2, Left = 6, CorrectRotate = 180 },
					new Block { PosX = -55, PosY = 330, X = -2, Y = 3, Top = 6, Right = -2, Bottom = 6, Left = 0, CorrectRotate = 90 },
					new Block { PosX = -55, PosY = 110, X = -2, Y = 1, Top = -2, Right = 0, Bottom = 3, Left = 2, CorrectRotate = 270 },
					new Block { PosX = 275, PosY = 0, X = 1, Y = 0, Top = 3, Right = 0, Bottom = 0, Left = -1, CorrectRotate = 270 },
					new Block { PosX = 165, PosY = -110, X = 0, Y = -1, Top = 2, Right = 4, Bottom = 5, Left = 1, CorrectRotate = 90 },
					new Block { PosX = 55, PosY = -220, X = -1, Y = -2, Top = 5, Right = 6, Bottom = 4, Left = 6, CorrectRotate = 180 },
					new Block { PosX = 55, PosY = -330, X = -1, Y = -3, Top = 1, Right = 2, Bottom = 8, Left = 9, CorrectRotate = 90 },
					new Block { PosX = -55, PosY = -220, X = -2, Y = -2, Top = 8, Right = 5, Bottom = 1, Left = -2, CorrectRotate = 90 },
					new Block { PosX = 165, PosY = -330, X = 0, Y = -3, Top = 8, Right = -1, Bottom = -1, Left = 1, CorrectRotate = 180 },
					new Block { PosX = 55, PosY = -440, X = -1, Y = -4, Top = -2, Right = -1, Bottom = -2, Left = 3, CorrectRotate = 180 },
				}
			};
		}
	}
}