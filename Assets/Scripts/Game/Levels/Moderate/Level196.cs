using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Moderate
{
	public abstract class Level196
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 196,
				MatchsToWin = 47,
				ThreeStarsLimit = 74,
				TwoStarsLimit = 89,
				BlockSizes = 90,
				Blocks = new List<Block>
				{
					new Block { PosX = 225, PosY = -45, X = 0, Y = 0, Top = 0, Right = -2, Bottom = 5, Left = -1, CorrectRotate = 270 },
					new Block { PosX = 135, PosY = -45, X = -1, Y = 0, Top = 0, Right = 3, Bottom = 2, Left = 8, CorrectRotate = 90 },
					new Block { PosX = 135, PosY = 45, X = -1, Y = 1, Top = 4, Right = 5, Bottom = 1, Left = 1, CorrectRotate = 180 },
					new Block { PosX = 135, PosY = -135, X = -1, Y = -1, Top = 8, Right = -2, Bottom = 8, Left = -1, CorrectRotate = 270 },
					new Block { PosX = 135, PosY = -225, X = -1, Y = -2, Top = 0, Right = 9, Bottom = 0, Left = -1, CorrectRotate = 90 },
					new Block { PosX = 45, PosY = -135, X = -2, Y = -1, Top = 5, Right = 3, Bottom = 6, Left = -1, CorrectRotate = 180 },
					new Block { PosX = 225, PosY = -225, X = 0, Y = -2, Top = 6, Right = 7, Bottom = 0, Left = 6, CorrectRotate = 180 },
					new Block { PosX = 135, PosY = -315, X = -1, Y = -3, Top = 9, Right = 8, Bottom = -1, Left = 1, CorrectRotate = 90 },
					new Block { PosX = 225, PosY = -135, X = 0, Y = -1, Top = 7, Right = -1, Bottom = 9, Left = 4, CorrectRotate = 180 },
					new Block { PosX = 45, PosY = -45, X = -2, Y = 0, Top = 7, Right = 7, Bottom = 7, Left = 1, CorrectRotate = 90 },
					new Block { PosX = -45, PosY = -135, X = -3, Y = -1, Top = 1, Right = 0, Bottom = 4, Left = 3, CorrectRotate = 90 },
					new Block { PosX = 315, PosY = -225, X = 1, Y = -2, Top = 1, Right = 5, Bottom = 9, Left = 4, CorrectRotate = 90 },
					new Block { PosX = 225, PosY = -315, X = 0, Y = -3, Top = 8, Right = 1, Bottom = 0, Left = 7, CorrectRotate = 90 },
					new Block { PosX = 135, PosY = -405, X = -1, Y = -4, Top = 1, Right = 4, Bottom = 6, Left = 0, CorrectRotate = 180 },
					new Block { PosX = 45, PosY = -315, X = -2, Y = -3, Top = -1, Right = 4, Bottom = -2, Left = 1, CorrectRotate = 90 },
					new Block { PosX = 315, PosY = -135, X = 1, Y = -1, Top = 3, Right = 0, Bottom = 2, Left = 2, CorrectRotate = 90 },
					new Block { PosX = 45, PosY = 45, X = -2, Y = 1, Top = 2, Right = 0, Bottom = 1, Left = 1, CorrectRotate = 270 },
					new Block { PosX = -45, PosY = 45, X = -3, Y = 1, Top = 9, Right = 2, Bottom = 5, Left = 6, CorrectRotate = 180 },
					new Block { PosX = -45, PosY = 135, X = -3, Y = 2, Top = -1, Right = 2, Bottom = 5, Left = 2, CorrectRotate = 90 },
					new Block { PosX = -135, PosY = 135, X = -4, Y = 2, Top = -1, Right = 8, Bottom = -2, Left = 8, CorrectRotate = 180 },
					new Block { PosX = -135, PosY = 225, X = -4, Y = 3, Top = -2, Right = 7, Bottom = 1, Left = 9, CorrectRotate = 90 },
					new Block { PosX = -135, PosY = 45, X = -4, Y = 1, Top = 3, Right = 2, Bottom = 8, Left = 5, CorrectRotate = 180 },
					new Block { PosX = -135, PosY = 315, X = -4, Y = 4, Top = 4, Right = 7, Bottom = 2, Left = 0, CorrectRotate = 90 },
					new Block { PosX = -225, PosY = 315, X = -5, Y = 4, Top = 3, Right = 7, Bottom = 7, Left = -2, CorrectRotate = 270 },
					new Block { PosX = -315, PosY = 315, X = -6, Y = 4, Top = 0, Right = 6, Bottom = -2, Left = -1, CorrectRotate = 270 },
					new Block { PosX = 45, PosY = -225, X = -2, Y = -2, Top = 3, Right = -1, Bottom = 2, Left = 7, CorrectRotate = 180 },
					new Block { PosX = 315, PosY = -45, X = 1, Y = 0, Top = 7, Right = 6, Bottom = 4, Left = 7, CorrectRotate = 90 },
					new Block { PosX = 45, PosY = 135, X = -2, Y = 2, Top = 8, Right = 6, Bottom = 2, Left = 3, CorrectRotate = 270 },
					new Block { PosX = -45, PosY = -45, X = -3, Y = 0, Top = 7, Right = 1, Bottom = -2, Left = 0, CorrectRotate = 180 },
					new Block { PosX = -45, PosY = 225, X = -3, Y = 3, Top = 5, Right = 6, Bottom = 4, Left = 0, CorrectRotate = 180 },
					new Block { PosX = -135, PosY = -45, X = -4, Y = 0, Top = 3, Right = -2, Bottom = 4, Left = 6, CorrectRotate = 180 },
					new Block { PosX = -225, PosY = 45, X = -5, Y = 1, Top = -2, Right = 6, Bottom = 6, Left = 5, CorrectRotate = 180 },
					new Block { PosX = -135, PosY = 405, X = -4, Y = 5, Top = 0, Right = 1, Bottom = 1, Left = 2, CorrectRotate = 180 },
				}
			};
		}
	}
}