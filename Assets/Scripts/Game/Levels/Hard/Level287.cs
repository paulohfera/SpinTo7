using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hard
{
	public abstract class Level287
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 287,
				MatchsToWin = 29,
				ThreeStarsLimit = 57,
				TwoStarsLimit = 69,
				BlockSizes = 110,
				Blocks = new List<Block>
				{
					new Block { PosX = 110, PosY = 0, X = 0, Y = 0, Top = 4, Right = 6, Bottom = 2, Left = 1, CorrectRotate = 180 },
					new Block { PosX = 110, PosY = -110, X = 0, Y = -1, Top = 7, Right = 6, Bottom = 3, Left = 4, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = 0, X = -1, Y = 0, Top = 9, Right = 6, Bottom = 1, Left = 6, CorrectRotate = 90 },
					new Block { PosX = 220, PosY = -110, X = 1, Y = -1, Top = -2, Right = 3, Bottom = 5, Left = 8, CorrectRotate = 180 },
					new Block { PosX = 110, PosY = -220, X = 0, Y = -2, Top = 7, Right = 6, Bottom = 0, Left = 7, CorrectRotate = 180 },
					new Block { PosX = 110, PosY = -330, X = 0, Y = -3, Top = -1, Right = 0, Bottom = 1, Left = 3, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = -220, X = -1, Y = -2, Top = -2, Right = 4, Bottom = 8, Left = 1, CorrectRotate = 180 },
					new Block { PosX = 220, PosY = -330, X = 1, Y = -3, Top = 1, Right = 6, Bottom = 1, Left = 7, CorrectRotate = 180 },
					new Block { PosX = 110, PosY = -440, X = 0, Y = -4, Top = 0, Right = 5, Bottom = 4, Left = -2, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = 110, X = -1, Y = 1, Top = 3, Right = 1, Bottom = 4, Left = 0, CorrectRotate = 270 },
					new Block { PosX = -110, PosY = 110, X = -2, Y = 1, Top = -2, Right = 4, Bottom = 0, Left = 3, CorrectRotate = 180 },
					new Block { PosX = -110, PosY = 220, X = -2, Y = 2, Top = -1, Right = 7, Bottom = 0, Left = 9, CorrectRotate = 270 },
					new Block { PosX = -110, PosY = 0, X = -2, Y = 0, Top = -1, Right = 9, Bottom = -2, Left = 0, CorrectRotate = 90 },
					new Block { PosX = -110, PosY = 330, X = -2, Y = 3, Top = 2, Right = -2, Bottom = 0, Left = 5, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = 220, X = -1, Y = 2, Top = 8, Right = 2, Bottom = 9, Left = 7, CorrectRotate = 90 },
					new Block { PosX = -110, PosY = -110, X = -2, Y = -1, Top = 0, Right = 1, Bottom = 3, Left = 7, CorrectRotate = 270 },
					new Block { PosX = -220, PosY = 0, X = -3, Y = 0, Top = 8, Right = 7, Bottom = 7, Left = 0, CorrectRotate = 270 },
					new Block { PosX = -110, PosY = 440, X = -2, Y = 4, Top = 2, Right = -1, Bottom = 2, Left = 2, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = 330, X = -1, Y = 3, Top = 5, Right = 5, Bottom = 7, Left = 5, CorrectRotate = 180 },
					new Block { PosX = -220, PosY = 330, X = -3, Y = 3, Top = 7, Right = -2, Bottom = -1, Left = 7, CorrectRotate = 180 },
					new Block { PosX = 110, PosY = 220, X = 0, Y = 2, Top = -2, Right = 8, Bottom = -2, Left = 9, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = -110, X = -1, Y = -1, Top = -1, Right = 7, Bottom = 1, Left = 1, CorrectRotate = 180 },
					new Block { PosX = -220, PosY = -110, X = -3, Y = -1, Top = 3, Right = 0, Bottom = 4, Left = 0, CorrectRotate = 90 },
				}
			};
		}
	}
}