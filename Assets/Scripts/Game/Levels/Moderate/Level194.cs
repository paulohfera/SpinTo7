using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Moderate
{
	public abstract class Level194
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 194,
				MatchsToWin = 46,
				ThreeStarsLimit = 75,
				TwoStarsLimit = 90,
				BlockSizes = 90,
				Blocks = new List<Block>
				{
					new Block { PosX = 45, PosY = 225, X = 0, Y = 0, Top = 1, Right = 7, Bottom = 6, Left = 3, CorrectRotate = 180 },
					new Block { PosX = 135, PosY = 225, X = 1, Y = 0, Top = 4, Right = 4, Bottom = 8, Left = 3, CorrectRotate = 90 },
					new Block { PosX = 135, PosY = 135, X = 1, Y = -1, Top = 7, Right = 7, Bottom = 4, Left = 0, CorrectRotate = 180 },
					new Block { PosX = 45, PosY = 135, X = 0, Y = -1, Top = 0, Right = 2, Bottom = 1, Left = 6, CorrectRotate = 270 },
					new Block { PosX = -45, PosY = 135, X = -1, Y = -1, Top = 6, Right = 2, Bottom = -1, Left = -2, CorrectRotate = 270 },
					new Block { PosX = -45, PosY = 225, X = -1, Y = 0, Top = 8, Right = 0, Bottom = 0, Left = 9, CorrectRotate = 90 },
					new Block { PosX = 45, PosY = 45, X = 0, Y = -2, Top = 0, Right = 5, Bottom = 2, Left = 2, CorrectRotate = 90 },
					new Block { PosX = -45, PosY = 45, X = -1, Y = -2, Top = 7, Right = -2, Bottom = 5, Left = 7, CorrectRotate = 180 },
					new Block { PosX = -135, PosY = 135, X = -2, Y = -1, Top = -2, Right = -2, Bottom = 8, Left = 2, CorrectRotate = 90 },
					new Block { PosX = -45, PosY = 315, X = -1, Y = 1, Top = 7, Right = -1, Bottom = 8, Left = 3, CorrectRotate = 180 },
					new Block { PosX = -135, PosY = 225, X = -2, Y = 0, Top = -1, Right = 9, Bottom = 8, Left = 4, CorrectRotate = 270 },
					new Block { PosX = 135, PosY = 45, X = 1, Y = -2, Top = 5, Right = 0, Bottom = -2, Left = 3, CorrectRotate = 90 },
					new Block { PosX = -45, PosY = -45, X = -1, Y = -3, Top = 3, Right = 8, Bottom = 8, Left = 0, CorrectRotate = 270 },
					new Block { PosX = -135, PosY = 45, X = -2, Y = -2, Top = 9, Right = 4, Bottom = 5, Left = 5, CorrectRotate = 270 },
					new Block { PosX = -225, PosY = 135, X = -3, Y = -1, Top = 6, Right = -2, Bottom = 9, Left = 4, CorrectRotate = 90 },
					new Block { PosX = -45, PosY = 405, X = -1, Y = 2, Top = -1, Right = 4, Bottom = 8, Left = 1, CorrectRotate = 180 },
					new Block { PosX = 45, PosY = -45, X = 0, Y = -3, Top = 4, Right = 5, Bottom = 6, Left = 5, CorrectRotate = 90 },
					new Block { PosX = 45, PosY = 315, X = 0, Y = 1, Top = 6, Right = 1, Bottom = 4, Left = -1, CorrectRotate = 270 },
					new Block { PosX = -135, PosY = 315, X = -2, Y = 1, Top = -2, Right = 0, Bottom = 8, Left = 3, CorrectRotate = 90 },
					new Block { PosX = 225, PosY = 45, X = 2, Y = -2, Top = 7, Right = 1, Bottom = 9, Left = 3, CorrectRotate = 270 },
					new Block { PosX = 135, PosY = -45, X = 1, Y = -3, Top = -2, Right = 1, Bottom = 4, Left = -2, CorrectRotate = 180 },
					new Block { PosX = -45, PosY = -135, X = -1, Y = -4, Top = 2, Right = -1, Bottom = -1, Left = 5, CorrectRotate = 90 },
					new Block { PosX = -45, PosY = -225, X = -1, Y = -5, Top = 3, Right = 2, Bottom = 3, Left = -1, CorrectRotate = 90 },
					new Block { PosX = -135, PosY = -135, X = -2, Y = -4, Top = 5, Right = 8, Bottom = 2, Left = 0, CorrectRotate = 270 },
					new Block { PosX = 45, PosY = -225, X = 0, Y = -5, Top = 9, Right = 4, Bottom = 2, Left = 7, CorrectRotate = 180 },
					new Block { PosX = -45, PosY = -315, X = -1, Y = -6, Top = 8, Right = -2, Bottom = 6, Left = 8, CorrectRotate = 270 },
					new Block { PosX = -135, PosY = -225, X = -2, Y = -5, Top = 3, Right = -1, Bottom = -1, Left = 4, CorrectRotate = 180 },
					new Block { PosX = -135, PosY = -45, X = -2, Y = -3, Top = 4, Right = 3, Bottom = -1, Left = 7, CorrectRotate = 90 },
					new Block { PosX = 135, PosY = -225, X = 1, Y = -5, Top = 0, Right = 1, Bottom = -2, Left = 4, CorrectRotate = 90 },
					new Block { PosX = 45, PosY = -315, X = 0, Y = -6, Top = -1, Right = -2, Bottom = -1, Left = 7, CorrectRotate = 90 },
					new Block { PosX = -45, PosY = -405, X = -1, Y = -7, Top = 8, Right = -1, Bottom = 6, Left = 9, CorrectRotate = 270 },
					new Block { PosX = -135, PosY = 405, X = -2, Y = 2, Top = 2, Right = 5, Bottom = 3, Left = 7, CorrectRotate = 90 },
				}
			};
		}
	}
}