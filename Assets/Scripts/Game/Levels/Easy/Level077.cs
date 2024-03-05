using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Easy
{
	public abstract class Level077
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 77,
				MatchsToWin = 39,
				ThreeStarsLimit = 81,
				TwoStarsLimit = 97,
				BlockSizes = 85,
				Blocks = new List<Block>
				{
					new Block { PosX = 213, PosY = -170, X = 0, Y = 0, Top = 5, Right = 3, Bottom = 1, Left = 3, CorrectRotate = 180 },
					new Block { PosX = 298, PosY = -170, X = 1, Y = 0, Top = 4, Right = 0, Bottom = 4, Left = 2, CorrectRotate = 270 },
					new Block { PosX = 213, PosY = -255, X = 0, Y = -1, Top = 1, Right = 3, Bottom = 2, Left = 0, CorrectRotate = 180 },
					new Block { PosX = 128, PosY = -170, X = -1, Y = 0, Top = 1, Right = 5, Bottom = 4, Left = 5, CorrectRotate = 90 },
					new Block { PosX = 298, PosY = -85, X = 1, Y = 1, Top = 6, Right = 5, Bottom = 5, Left = 6, CorrectRotate = 270 },
					new Block { PosX = 213, PosY = -85, X = 0, Y = 1, Top = 6, Right = 4, Bottom = 6, Left = 2, CorrectRotate = 180 },
					new Block { PosX = 128, PosY = -85, X = -1, Y = 1, Top = 2, Right = 4, Bottom = 5, Left = 3, CorrectRotate = 180 },
					new Block { PosX = 43, PosY = -85, X = -2, Y = 1, Top = 5, Right = 2, Bottom = 6, Left = 3, CorrectRotate = 180 },
					new Block { PosX = 43, PosY = 0, X = -2, Y = 2, Top = 4, Right = 1, Bottom = 4, Left = 2, CorrectRotate = 270 },
					new Block { PosX = 128, PosY = 0, X = -1, Y = 2, Top = 2, Right = 3, Bottom = 3, Left = 2, CorrectRotate = 180 },
					new Block { PosX = 128, PosY = 85, X = -1, Y = 3, Top = 6, Right = 0, Bottom = 2, Left = 4, CorrectRotate = 90 },
					new Block { PosX = 43, PosY = 85, X = -2, Y = 3, Top = 5, Right = 1, Bottom = 2, Left = 1, CorrectRotate = 180 },
					new Block { PosX = -42, PosY = 0, X = -3, Y = 2, Top = 6, Right = 2, Bottom = 3, Left = 5, CorrectRotate = 90 },
					new Block { PosX = -127, PosY = 0, X = -4, Y = 2, Top = 1, Right = 7, Bottom = 1, Left = 4, CorrectRotate = 270 },
					new Block { PosX = -127, PosY = 85, X = -4, Y = 3, Top = 3, Right = 6, Bottom = 6, Left = 3, CorrectRotate = 180 },
					new Block { PosX = -127, PosY = -85, X = -4, Y = 1, Top = 2, Right = 7, Bottom = 0, Left = 0, CorrectRotate = 270 },
					new Block { PosX = -212, PosY = 0, X = -5, Y = 2, Top = 0, Right = 0, Bottom = 5, Left = 6, CorrectRotate = 180 },
					new Block { PosX = -127, PosY = 170, X = -4, Y = 4, Top = 4, Right = 1, Bottom = 4, Left = 7, CorrectRotate = 270 },
					new Block { PosX = -42, PosY = 85, X = -3, Y = 3, Top = 4, Right = 3, Bottom = 6, Left = 5, CorrectRotate = 90 },
					new Block { PosX = -127, PosY = -170, X = -4, Y = 0, Top = 3, Right = 0, Bottom = 5, Left = 0, CorrectRotate = 270 },
					new Block { PosX = -212, PosY = -85, X = -5, Y = 1, Top = 5, Right = 5, Bottom = 7, Left = 7, CorrectRotate = 180 },
					new Block { PosX = -212, PosY = 85, X = -5, Y = 3, Top = 2, Right = 1, Bottom = 6, Left = 1, CorrectRotate = 180 },
					new Block { PosX = -127, PosY = 255, X = -4, Y = 5, Top = 3, Right = 7, Bottom = 4, Left = 0, CorrectRotate = 90 },
					new Block { PosX = -42, PosY = 170, X = -3, Y = 4, Top = 4, Right = 3, Bottom = 7, Left = 7, CorrectRotate = 180 },
					new Block { PosX = -212, PosY = 170, X = -5, Y = 4, Top = 1, Right = 6, Bottom = 1, Left = 3, CorrectRotate = 180 },
					new Block { PosX = -42, PosY = -170, X = -3, Y = 0, Top = 3, Right = 6, Bottom = 4, Left = 6, CorrectRotate = 270 },
					new Block { PosX = -127, PosY = -255, X = -4, Y = -1, Top = 0, Right = 1, Bottom = 1, Left = 7, CorrectRotate = 270 },
					new Block { PosX = -212, PosY = -170, X = -5, Y = 0, Top = 2, Right = 5, Bottom = 7, Left = 2, CorrectRotate = 270 },
					new Block { PosX = -297, PosY = -85, X = -6, Y = 1, Top = 5, Right = 0, Bottom = 2, Left = 1, CorrectRotate = 90 },
				}
			};
		}
	}
}