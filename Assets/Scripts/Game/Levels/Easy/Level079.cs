using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Easy
{
	public abstract class Level079
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 79,
				MatchsToWin = 44,
				ThreeStarsLimit = 75,
				TwoStarsLimit = 89,
				BlockSizes = 110,
				Blocks = new List<Block>
				{
					new Block { PosX = 220, PosY = 0, X = 0, Y = 0, Top = 0, Right = 2, Bottom = 6, Left = 2, CorrectRotate = 90 },
					new Block { PosX = 220, PosY = -110, X = 0, Y = -1, Top = 5, Right = 2, Bottom = 5, Left = 3, CorrectRotate = 180 },
					new Block { PosX = 110, PosY = -110, X = -1, Y = -1, Top = 6, Right = 0, Bottom = 5, Left = 2, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = -110, X = -2, Y = -1, Top = 5, Right = 4, Bottom = 1, Left = 6, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = 0, X = -2, Y = 0, Top = 3, Right = 7, Bottom = 3, Left = 2, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = -220, X = -2, Y = -2, Top = 0, Right = 5, Bottom = 1, Left = 3, CorrectRotate = 180 },
					new Block { PosX = -110, PosY = -110, X = -3, Y = -1, Top = 2, Right = 7, Bottom = 5, Left = 7, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = 110, X = -2, Y = 1, Top = 4, Right = 5, Bottom = 5, Left = 2, CorrectRotate = 180 },
					new Block { PosX = 110, PosY = 0, X = -1, Y = 0, Top = 7, Right = 7, Bottom = 5, Left = 2, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = -330, X = -2, Y = -3, Top = 5, Right = 1, Bottom = 2, Left = 7, CorrectRotate = 270 },
					new Block { PosX = -110, PosY = -220, X = -3, Y = -2, Top = 4, Right = 5, Bottom = 0, Left = 2, CorrectRotate = 180 },
					new Block { PosX = -110, PosY = 0, X = -3, Y = 0, Top = 4, Right = 2, Bottom = 0, Left = 0, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = 220, X = -2, Y = 2, Top = 2, Right = 7, Bottom = 7, Left = 3, CorrectRotate = 180 },
					new Block { PosX = -110, PosY = 220, X = -3, Y = 2, Top = 5, Right = 7, Bottom = 6, Left = 0, CorrectRotate = 180 },
					new Block { PosX = -110, PosY = 330, X = -3, Y = 3, Top = 1, Right = 5, Bottom = 1, Left = 4, CorrectRotate = 180 },
					new Block { PosX = -110, PosY = 110, X = -3, Y = 1, Top = 5, Right = 2, Bottom = 2, Left = 5, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = 330, X = -2, Y = 3, Top = 0, Right = 3, Bottom = 1, Left = 1, CorrectRotate = 180 },
					new Block { PosX = -220, PosY = 110, X = -4, Y = 1, Top = 2, Right = 3, Bottom = 3, Left = 5, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = 440, X = -2, Y = 4, Top = 6, Right = 3, Bottom = 4, Left = 4, CorrectRotate = 180 },
					new Block { PosX = 110, PosY = -220, X = -1, Y = -2, Top = 3, Right = 4, Bottom = 5, Left = 0, CorrectRotate = 180 },
					new Block { PosX = -220, PosY = -110, X = -4, Y = -1, Top = 2, Right = 7, Bottom = 2, Left = 6, CorrectRotate = 90 },
					new Block { PosX = 110, PosY = 110, X = -1, Y = 1, Top = 7, Right = 5, Bottom = 5, Left = 6, CorrectRotate = 270 },
					new Block { PosX = 110, PosY = -330, X = -1, Y = -3, Top = 3, Right = 1, Bottom = 2, Left = 4, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = -440, X = -2, Y = -4, Top = 3, Right = 3, Bottom = 6, Left = 2, CorrectRotate = 180 },
					new Block { PosX = -110, PosY = -330, X = -3, Y = -3, Top = 3, Right = 5, Bottom = 3, Left = 5, CorrectRotate = 180 },
					new Block { PosX = -220, PosY = -220, X = -4, Y = -2, Top = 2, Right = 7, Bottom = 1, Left = 2, CorrectRotate = 180 },
					new Block { PosX = -220, PosY = 0, X = -4, Y = 0, Top = 6, Right = 4, Bottom = 3, Left = 0, CorrectRotate = 90 },
					new Block { PosX = 110, PosY = 220, X = -1, Y = 2, Top = 1, Right = 4, Bottom = 7, Left = 5, CorrectRotate = 180 },
					new Block { PosX = -220, PosY = 220, X = -4, Y = 2, Top = 2, Right = 1, Bottom = 3, Left = 0, CorrectRotate = 180 },
				}
			};
		}
	}
}