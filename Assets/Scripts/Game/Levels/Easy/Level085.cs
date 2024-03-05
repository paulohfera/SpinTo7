using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Easy
{
	public abstract class Level085
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 85,
				MatchsToWin = 41,
				ThreeStarsLimit = 94,
				TwoStarsLimit = 112,
				BlockSizes = 90,
				Blocks = new List<Block>
				{
					new Block { PosX = 135, PosY = 45, X = 0, Y = 0, Top = 0, Right = 5, Bottom = 7, Left = 6, CorrectRotate = 270 },
					new Block { PosX = 135, PosY = -45, X = 0, Y = -1, Top = 3, Right = 1, Bottom = 6, Left = 2, CorrectRotate = 270 },
					new Block { PosX = 45, PosY = -45, X = -1, Y = -1, Top = 0, Right = 1, Bottom = 5, Left = 1, CorrectRotate = 180 },
					new Block { PosX = 45, PosY = -135, X = -1, Y = -2, Top = 3, Right = 7, Bottom = 3, Left = 0, CorrectRotate = 90 },
					new Block { PosX = -45, PosY = -45, X = -2, Y = -1, Top = 6, Right = 5, Bottom = 6, Left = 7, CorrectRotate = 90 },
					new Block { PosX = 135, PosY = -135, X = 0, Y = -2, Top = 6, Right = 4, Bottom = 6, Left = 7, CorrectRotate = 180 },
					new Block { PosX = -45, PosY = -135, X = -2, Y = -2, Top = 4, Right = 5, Bottom = 1, Left = 0, CorrectRotate = 270 },
					new Block { PosX = -45, PosY = 45, X = -2, Y = 0, Top = 5, Right = 6, Bottom = 2, Left = 2, CorrectRotate = 90 },
					new Block { PosX = -135, PosY = -45, X = -3, Y = -1, Top = 1, Right = 2, Bottom = 5, Left = 7, CorrectRotate = 270 },
					new Block { PosX = 225, PosY = -135, X = 1, Y = -2, Top = 4, Right = 3, Bottom = 0, Left = 6, CorrectRotate = 270 },
					new Block { PosX = 135, PosY = -225, X = 0, Y = -3, Top = 4, Right = 6, Bottom = 1, Left = 7, CorrectRotate = 180 },
					new Block { PosX = -45, PosY = -225, X = -2, Y = -3, Top = 4, Right = 6, Bottom = 3, Left = 2, CorrectRotate = 270 },
					new Block { PosX = -135, PosY = -135, X = -3, Y = -2, Top = 6, Right = 6, Bottom = 7, Left = 5, CorrectRotate = 270 },
					new Block { PosX = -45, PosY = 135, X = -2, Y = 1, Top = 3, Right = 3, Bottom = 6, Left = 1, CorrectRotate = 90 },
					new Block { PosX = -135, PosY = -225, X = -3, Y = -3, Top = 4, Right = 1, Bottom = 4, Left = 7, CorrectRotate = 90 },
					new Block { PosX = -45, PosY = 225, X = -2, Y = 2, Top = 5, Right = 4, Bottom = 1, Left = 7, CorrectRotate = 270 },
					new Block { PosX = 45, PosY = 135, X = -1, Y = 1, Top = 3, Right = 6, Bottom = 1, Left = 6, CorrectRotate = 270 },
					new Block { PosX = -135, PosY = 135, X = -3, Y = 1, Top = 1, Right = 2, Bottom = 2, Left = 4, CorrectRotate = 180 },
					new Block { PosX = -135, PosY = -315, X = -3, Y = -4, Top = 5, Right = 2, Bottom = 7, Left = 0, CorrectRotate = 270 },
					new Block { PosX = -225, PosY = -225, X = -4, Y = -3, Top = 3, Right = 6, Bottom = 7, Left = 7, CorrectRotate = 270 },
					new Block { PosX = -45, PosY = 315, X = -2, Y = 3, Top = 2, Right = 0, Bottom = 1, Left = 3, CorrectRotate = 270 },
					new Block { PosX = 45, PosY = 225, X = -1, Y = 2, Top = 1, Right = 2, Bottom = 5, Left = 0, CorrectRotate = 180 },
					new Block { PosX = -135, PosY = 225, X = -3, Y = 2, Top = 6, Right = 5, Bottom = 4, Left = 0, CorrectRotate = 270 },
					new Block { PosX = 135, PosY = 135, X = 0, Y = 1, Top = 6, Right = 1, Bottom = 4, Left = 7, CorrectRotate = 270 },
					new Block { PosX = -135, PosY = 45, X = -3, Y = 0, Top = 0, Right = 1, Bottom = 6, Left = 2, CorrectRotate = 180 },
					new Block { PosX = -135, PosY = -405, X = -3, Y = -5, Top = 6, Right = 0, Bottom = 5, Left = 3, CorrectRotate = 180 },
					new Block { PosX = -225, PosY = -315, X = -4, Y = -4, Top = 0, Right = 6, Bottom = 0, Left = 1, CorrectRotate = 270 },
					new Block { PosX = -225, PosY = -135, X = -4, Y = -2, Top = 0, Right = 0, Bottom = 3, Left = 4, CorrectRotate = 270 },
					new Block { PosX = -45, PosY = 405, X = -2, Y = 4, Top = 0, Right = 4, Bottom = 3, Left = 7, CorrectRotate = 270 },
					new Block { PosX = 45, PosY = 315, X = -1, Y = 3, Top = 2, Right = 5, Bottom = 0, Left = 1, CorrectRotate = 180 },
				}
			};
		}
	}
}