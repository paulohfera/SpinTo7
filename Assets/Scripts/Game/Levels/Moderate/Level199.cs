using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Moderate
{
	public abstract class Level199
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 199,
				MatchsToWin = 48,
				ThreeStarsLimit = 88,
				TwoStarsLimit = 105,
				BlockSizes = 85,
				Blocks = new List<Block>
				{
					new Block { PosX = -42, PosY = 0, X = 0, Y = 0, Top = 0, Right = 6, Bottom = -1, Left = 7, CorrectRotate = 180 },
					new Block { PosX = 43, PosY = 0, X = 1, Y = 0, Top = 0, Right = 0, Bottom = 5, Left = 5, CorrectRotate = 90 },
					new Block { PosX = -42, PosY = -85, X = 0, Y = -1, Top = 0, Right = 9, Bottom = 7, Left = 7, CorrectRotate = 270 },
					new Block { PosX = -42, PosY = 85, X = 0, Y = 1, Top = 1, Right = 8, Bottom = 9, Left = 5, CorrectRotate = 270 },
					new Block { PosX = -127, PosY = 0, X = -1, Y = 0, Top = 1, Right = 4, Bottom = 1, Left = -1, CorrectRotate = 270 },
					new Block { PosX = -212, PosY = 0, X = -2, Y = 0, Top = 6, Right = 7, Bottom = -2, Left = 1, CorrectRotate = 270 },
					new Block { PosX = -212, PosY = 85, X = -2, Y = 1, Top = 2, Right = 5, Bottom = 8, Left = 6, CorrectRotate = 90 },
					new Block { PosX = -212, PosY = -85, X = -2, Y = -1, Top = -2, Right = 4, Bottom = 6, Left = 0, CorrectRotate = 270 },
					new Block { PosX = -297, PosY = 0, X = -3, Y = 0, Top = 9, Right = -2, Bottom = 4, Left = 8, CorrectRotate = 270 },
					new Block { PosX = -212, PosY = 170, X = -2, Y = 2, Top = 1, Right = 2, Bottom = 7, Left = 8, CorrectRotate = 270 },
					new Block { PosX = -127, PosY = 85, X = -1, Y = 1, Top = -1, Right = -2, Bottom = -2, Left = 8, CorrectRotate = 90 },
					new Block { PosX = -127, PosY = 170, X = -1, Y = 2, Top = 6, Right = 4, Bottom = -1, Left = 9, CorrectRotate = 90 },
					new Block { PosX = -42, PosY = 170, X = 0, Y = 2, Top = 2, Right = 8, Bottom = 2, Left = 6, CorrectRotate = 180 },
					new Block { PosX = 43, PosY = 170, X = 1, Y = 2, Top = 0, Right = 5, Bottom = 1, Left = 9, CorrectRotate = 270 },
					new Block { PosX = 128, PosY = 170, X = 2, Y = 2, Top = -2, Right = 0, Bottom = 7, Left = 3, CorrectRotate = 270 },
					new Block { PosX = 213, PosY = 170, X = 3, Y = 2, Top = 9, Right = 3, Bottom = 4, Left = 3, CorrectRotate = 90 },
					new Block { PosX = 128, PosY = 85, X = 2, Y = 1, Top = 1, Right = 7, Bottom = 6, Left = 7, CorrectRotate = 270 },
					new Block { PosX = 213, PosY = 255, X = 3, Y = 3, Top = 4, Right = 4, Bottom = 0, Left = 5, CorrectRotate = 180 },
					new Block { PosX = 298, PosY = 170, X = 4, Y = 2, Top = 8, Right = 3, Bottom = 8, Left = 8, CorrectRotate = 180 },
					new Block { PosX = 43, PosY = 85, X = 1, Y = 1, Top = 7, Right = 6, Bottom = 2, Left = 1, CorrectRotate = 180 },
					new Block { PosX = 128, PosY = 0, X = 2, Y = 0, Top = 2, Right = 4, Bottom = 2, Left = 0, CorrectRotate = 270 },
					new Block { PosX = 43, PosY = -85, X = 1, Y = -1, Top = 5, Right = 7, Bottom = 2, Left = 0, CorrectRotate = 180 },
					new Block { PosX = -42, PosY = -170, X = 0, Y = -2, Top = -1, Right = -1, Bottom = -2, Left = -1, CorrectRotate = 180 },
					new Block { PosX = -127, PosY = -85, X = -1, Y = -1, Top = 2, Right = 9, Bottom = 3, Left = 0, CorrectRotate = 180 },
					new Block { PosX = -297, PosY = 85, X = -3, Y = 1, Top = 3, Right = 4, Bottom = 5, Left = -1, CorrectRotate = 90 },
					new Block { PosX = -212, PosY = -170, X = -2, Y = -2, Top = 6, Right = 3, Bottom = 8, Left = 3, CorrectRotate = 270 },
					new Block { PosX = 298, PosY = 255, X = 4, Y = 3, Top = -1, Right = 2, Bottom = 4, Left = 2, CorrectRotate = 180 },
					new Block { PosX = 128, PosY = 255, X = 2, Y = 3, Top = 4, Right = 8, Bottom = 0, Left = 3, CorrectRotate = 180 },
					new Block { PosX = 298, PosY = 85, X = 4, Y = 1, Top = 8, Right = 5, Bottom = -1, Left = 3, CorrectRotate = 180 },
					new Block { PosX = 213, PosY = 0, X = 3, Y = 0, Top = 5, Right = 5, Bottom = 1, Left = 7, CorrectRotate = 90 },
					new Block { PosX = 128, PosY = -85, X = 2, Y = -1, Top = 9, Right = 9, Bottom = 7, Left = 3, CorrectRotate = 270 },
					new Block { PosX = 43, PosY = -170, X = 1, Y = -2, Top = 8, Right = 2, Bottom = 3, Left = 1, CorrectRotate = 90 },
					new Block { PosX = -42, PosY = -255, X = 0, Y = -3, Top = 8, Right = 8, Bottom = 5, Left = 7, CorrectRotate = 90 },
				}
			};
		}
	}
}