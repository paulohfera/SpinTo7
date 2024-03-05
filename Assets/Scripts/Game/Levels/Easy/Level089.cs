using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Easy
{
	public abstract class Level089
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 89,
				MatchsToWin = 43,
				ThreeStarsLimit = 81,
				TwoStarsLimit = 97,
				BlockSizes = 90,
				Blocks = new List<Block>
				{
					new Block { PosX = 0, PosY = 225, X = 0, Y = 0, Top = 1, Right = 6, Bottom = 7, Left = 5, CorrectRotate = 180 },
					new Block { PosX = -90, PosY = 225, X = -1, Y = 0, Top = 1, Right = 6, Bottom = 1, Left = 2, CorrectRotate = 90 },
					new Block { PosX = -90, PosY = 135, X = -1, Y = -1, Top = 4, Right = 3, Bottom = 4, Left = 5, CorrectRotate = 270 },
					new Block { PosX = -90, PosY = 45, X = -1, Y = -2, Top = 2, Right = 4, Bottom = 6, Left = 1, CorrectRotate = 90 },
					new Block { PosX = -180, PosY = 135, X = -2, Y = -1, Top = 3, Right = 0, Bottom = 6, Left = 4, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = 45, X = 0, Y = -2, Top = 2, Right = 1, Bottom = 1, Left = 6, CorrectRotate = 180 },
					new Block { PosX = -90, PosY = -45, X = -1, Y = -3, Top = 4, Right = 6, Bottom = 5, Left = 3, CorrectRotate = 90 },
					new Block { PosX = -180, PosY = 45, X = -2, Y = -2, Top = 2, Right = 7, Bottom = 5, Left = 7, CorrectRotate = 90 },
					new Block { PosX = -180, PosY = 225, X = -2, Y = 0, Top = 2, Right = 0, Bottom = 6, Left = 3, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = -45, X = 0, Y = -3, Top = 3, Right = 3, Bottom = 2, Left = 5, CorrectRotate = 270 },
					new Block { PosX = -90, PosY = -135, X = -1, Y = -4, Top = 5, Right = 4, Bottom = 1, Left = 6, CorrectRotate = 90 },
					new Block { PosX = -180, PosY = -45, X = -2, Y = -3, Top = 3, Right = 6, Bottom = 4, Left = 0, CorrectRotate = 270 },
					new Block { PosX = -270, PosY = 45, X = -3, Y = -2, Top = 7, Right = 5, Bottom = 5, Left = 2, CorrectRotate = 90 },
					new Block { PosX = -180, PosY = 315, X = -2, Y = 1, Top = 7, Right = 3, Bottom = 4, Left = 7, CorrectRotate = 180 },
					new Block { PosX = -270, PosY = 225, X = -3, Y = 0, Top = 5, Right = 4, Bottom = 3, Left = 4, CorrectRotate = 270 },
					new Block { PosX = 90, PosY = -45, X = 1, Y = -3, Top = 0, Right = 6, Bottom = 4, Left = 7, CorrectRotate = 270 },
					new Block { PosX = 90, PosY = -135, X = 1, Y = -4, Top = 6, Right = 1, Bottom = 0, Left = 7, CorrectRotate = 90 },
					new Block { PosX = 180, PosY = -135, X = 2, Y = -4, Top = 5, Right = 7, Bottom = 7, Left = 7, CorrectRotate = 180 },
					new Block { PosX = 90, PosY = -225, X = 1, Y = -5, Top = 3, Right = 4, Bottom = 0, Left = 4, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = -135, X = 0, Y = -4, Top = 6, Right = 4, Bottom = 1, Left = 1, CorrectRotate = 90 },
					new Block { PosX = 180, PosY = -225, X = 2, Y = -5, Top = 4, Right = 3, Bottom = 2, Left = 1, CorrectRotate = 180 },
					new Block { PosX = 90, PosY = -315, X = 1, Y = -6, Top = 3, Right = 3, Bottom = 4, Left = 3, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = -225, X = 0, Y = -5, Top = 3, Right = 3, Bottom = 2, Left = 6, CorrectRotate = 270 },
					new Block { PosX = 270, PosY = -225, X = 3, Y = -5, Top = 4, Right = 6, Bottom = 6, Left = 0, CorrectRotate = 270 },
					new Block { PosX = 180, PosY = -315, X = 2, Y = -6, Top = 0, Right = 4, Bottom = 3, Left = 6, CorrectRotate = 180 },
					new Block { PosX = 90, PosY = -405, X = 1, Y = -7, Top = 5, Right = 3, Bottom = 4, Left = 3, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = -315, X = 0, Y = -6, Top = 4, Right = 2, Bottom = 7, Left = 4, CorrectRotate = 270 },
					new Block { PosX = -90, PosY = -225, X = -1, Y = -5, Top = 5, Right = 5, Bottom = 1, Left = 1, CorrectRotate = 270 },
					new Block { PosX = -270, PosY = -45, X = -3, Y = -3, Top = 5, Right = 4, Bottom = 5, Left = 3, CorrectRotate = 180 },
					new Block { PosX = -180, PosY = 405, X = -2, Y = 2, Top = 3, Right = 1, Bottom = 3, Left = 4, CorrectRotate = 180 },
					new Block { PosX = -90, PosY = 315, X = -1, Y = 1, Top = 0, Right = 3, Bottom = 3, Left = 1, CorrectRotate = 90 },
				}
			};
		}
	}
}