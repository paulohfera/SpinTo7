using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Moderate
{
	public abstract class Level184
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 184,
				MatchsToWin = 42,
				ThreeStarsLimit = 62,
				TwoStarsLimit = 74,
				BlockSizes = 90,
				Blocks = new List<Block>
				{
					new Block { PosX = 45, PosY = -225, X = 0, Y = 0, Top = 1, Right = 1, Bottom = 1, Left = -2, CorrectRotate = 270 },
					new Block { PosX = 45, PosY = -135, X = 0, Y = 1, Top = 4, Right = 9, Bottom = -1, Left = 8, CorrectRotate = 270 },
					new Block { PosX = 135, PosY = -225, X = 1, Y = 0, Top = 6, Right = -1, Bottom = 5, Left = 2, CorrectRotate = 90 },
					new Block { PosX = 45, PosY = -315, X = 0, Y = -1, Top = -1, Right = 6, Bottom = -1, Left = 8, CorrectRotate = 90 },
					new Block { PosX = -45, PosY = -225, X = -1, Y = 0, Top = 6, Right = 4, Bottom = -1, Left = 9, CorrectRotate = 270 },
					new Block { PosX = 45, PosY = -45, X = 0, Y = 2, Top = -1, Right = 1, Bottom = 4, Left = 7, CorrectRotate = 180 },
					new Block { PosX = 135, PosY = -135, X = 1, Y = 1, Top = 5, Right = 8, Bottom = 3, Left = 9, CorrectRotate = 270 },
					new Block { PosX = -45, PosY = -135, X = -1, Y = 1, Top = -2, Right = 6, Bottom = 4, Left = 8, CorrectRotate = 180 },
					new Block { PosX = 225, PosY = -225, X = 2, Y = 0, Top = 2, Right = -1, Bottom = 1, Left = 1, CorrectRotate = 90 },
					new Block { PosX = 135, PosY = -315, X = 1, Y = -1, Top = 7, Right = 8, Bottom = 8, Left = 5, CorrectRotate = 270 },
					new Block { PosX = 45, PosY = -405, X = 0, Y = -2, Top = 6, Right = 5, Bottom = -1, Left = 1, CorrectRotate = 180 },
					new Block { PosX = -45, PosY = -315, X = -1, Y = -1, Top = -1, Right = 3, Bottom = 8, Left = 5, CorrectRotate = 90 },
					new Block { PosX = -135, PosY = -225, X = -2, Y = 0, Top = 2, Right = 5, Bottom = 8, Left = 8, CorrectRotate = 180 },
					new Block { PosX = 45, PosY = 45, X = 0, Y = 3, Top = 3, Right = -2, Bottom = 7, Left = -1, CorrectRotate = 180 },
					new Block { PosX = -45, PosY = 45, X = -1, Y = 3, Top = 9, Right = 5, Bottom = 9, Left = 4, CorrectRotate = 90 },
					new Block { PosX = -45, PosY = 135, X = -1, Y = 4, Top = 2, Right = 5, Bottom = 9, Left = 6, CorrectRotate = 180 },
					new Block { PosX = -135, PosY = 135, X = -2, Y = 4, Top = 0, Right = 5, Bottom = 2, Left = 8, CorrectRotate = 90 },
					new Block { PosX = -135, PosY = 225, X = -2, Y = 5, Top = 2, Right = 3, Bottom = 0, Left = 8, CorrectRotate = 180 },
					new Block { PosX = -135, PosY = 45, X = -2, Y = 3, Top = 4, Right = -1, Bottom = -2, Left = -2, CorrectRotate = 90 },
					new Block { PosX = -135, PosY = 315, X = -2, Y = 6, Top = 9, Right = 8, Bottom = 2, Left = 7, CorrectRotate = 90 },
					new Block { PosX = -45, PosY = 225, X = -1, Y = 5, Top = -1, Right = 5, Bottom = 6, Left = -2, CorrectRotate = 90 },
					new Block { PosX = -135, PosY = -45, X = -2, Y = 2, Top = 8, Right = 9, Bottom = 5, Left = 1, CorrectRotate = 90 },
					new Block { PosX = -225, PosY = 45, X = -3, Y = 3, Top = 6, Right = 1, Bottom = 3, Left = 2, CorrectRotate = 90 },
					new Block { PosX = -135, PosY = 405, X = -2, Y = 7, Top = -1, Right = 9, Bottom = 6, Left = -1, CorrectRotate = 90 },
					new Block { PosX = -45, PosY = 315, X = -1, Y = 6, Top = 5, Right = 3, Bottom = 2, Left = 2, CorrectRotate = 90 },
					new Block { PosX = -225, PosY = 315, X = -3, Y = 6, Top = 1, Right = 5, Bottom = 1, Left = -2, CorrectRotate = 180 },
					new Block { PosX = 45, PosY = 225, X = 0, Y = 5, Top = 7, Right = 1, Bottom = -2, Left = -2, CorrectRotate = 180 },
					new Block { PosX = -45, PosY = -45, X = -1, Y = 2, Top = 2, Right = 3, Bottom = 6, Left = 3, CorrectRotate = 90 },
					new Block { PosX = -225, PosY = 225, X = -3, Y = 5, Top = 0, Right = 6, Bottom = 4, Left = 5, CorrectRotate = 90 },
					new Block { PosX = -135, PosY = -135, X = -2, Y = 1, Top = 6, Right = 6, Bottom = 1, Left = -1, CorrectRotate = 90 },
				}
			};
		}
	}
}