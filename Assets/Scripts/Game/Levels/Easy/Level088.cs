using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Easy
{
	public abstract class Level088
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 88,
				MatchsToWin = 46,
				ThreeStarsLimit = 88,
				TwoStarsLimit = 104,
				BlockSizes = 85,
				Blocks = new List<Block>
				{
					new Block { PosX = 298, PosY = 0, X = 0, Y = 0, Top = 1, Right = 5, Bottom = 0, Left = 0, CorrectRotate = 180 },
					new Block { PosX = 298, PosY = -85, X = 0, Y = -1, Top = 5, Right = 6, Bottom = 1, Left = 7, CorrectRotate = 90 },
					new Block { PosX = 213, PosY = -85, X = -1, Y = -1, Top = 2, Right = 0, Bottom = 0, Left = 2, CorrectRotate = 180 },
					new Block { PosX = 213, PosY = 0, X = -1, Y = 0, Top = 7, Right = 4, Bottom = 4, Left = 2, CorrectRotate = 180 },
					new Block { PosX = 128, PosY = -85, X = -2, Y = -1, Top = 7, Right = 7, Bottom = 7, Left = 2, CorrectRotate = 270 },
					new Block { PosX = 213, PosY = 85, X = -1, Y = 1, Top = 7, Right = 3, Bottom = 5, Left = 1, CorrectRotate = 270 },
					new Block { PosX = 128, PosY = 0, X = -2, Y = 0, Top = 3, Right = 5, Bottom = 6, Left = 2, CorrectRotate = 270 },
					new Block { PosX = 128, PosY = -170, X = -2, Y = -2, Top = 3, Right = 1, Bottom = 5, Left = 0, CorrectRotate = 270 },
					new Block { PosX = 43, PosY = -170, X = -3, Y = -2, Top = 2, Right = 2, Bottom = 1, Left = 7, CorrectRotate = 270 },
					new Block { PosX = 43, PosY = -85, X = -3, Y = -1, Top = 0, Right = 0, Bottom = 0, Left = 6, CorrectRotate = 270 },
					new Block { PosX = -42, PosY = -170, X = -4, Y = -2, Top = 6, Right = 2, Bottom = 2, Left = 6, CorrectRotate = 180 },
					new Block { PosX = 43, PosY = 0, X = -3, Y = 0, Top = 1, Right = 1, Bottom = 6, Left = 4, CorrectRotate = 270 },
					new Block { PosX = -42, PosY = -85, X = -4, Y = -1, Top = 5, Right = 3, Bottom = 2, Left = 7, CorrectRotate = 180 },
					new Block { PosX = -127, PosY = -170, X = -5, Y = -2, Top = 5, Right = 0, Bottom = 3, Left = 7, CorrectRotate = 270 },
					new Block { PosX = 43, PosY = 85, X = -3, Y = 1, Top = 7, Right = 1, Bottom = 4, Left = 3, CorrectRotate = 90 },
					new Block { PosX = -42, PosY = 0, X = -4, Y = 0, Top = 1, Right = 5, Bottom = 2, Left = 5, CorrectRotate = 270 },
					new Block { PosX = -127, PosY = -85, X = -5, Y = -1, Top = 0, Right = 7, Bottom = 7, Left = 4, CorrectRotate = 180 },
					new Block { PosX = -127, PosY = -255, X = -5, Y = -3, Top = 2, Right = 7, Bottom = 2, Left = 7, CorrectRotate = 90 },
					new Block { PosX = -212, PosY = -170, X = -6, Y = -2, Top = 2, Right = 7, Bottom = 0, Left = 4, CorrectRotate = 180 },
					new Block { PosX = 43, PosY = 170, X = -3, Y = 2, Top = 2, Right = 6, Bottom = 7, Left = 5, CorrectRotate = 270 },
					new Block { PosX = 128, PosY = 85, X = -2, Y = 1, Top = 3, Right = 4, Bottom = 2, Left = 5, CorrectRotate = 90 },
					new Block { PosX = -127, PosY = 0, X = -5, Y = 0, Top = 0, Right = 1, Bottom = 2, Left = 5, CorrectRotate = 180 },
					new Block { PosX = -212, PosY = -85, X = -6, Y = -1, Top = 0, Right = 7, Bottom = 3, Left = 7, CorrectRotate = 270 },
					new Block { PosX = -42, PosY = -255, X = -4, Y = -3, Top = 5, Right = 1, Bottom = 0, Left = 6, CorrectRotate = 90 },
					new Block { PosX = -212, PosY = -255, X = -6, Y = -3, Top = 7, Right = 5, Bottom = 5, Left = 7, CorrectRotate = 90 },
					new Block { PosX = -297, PosY = -170, X = -7, Y = -2, Top = 7, Right = 3, Bottom = 7, Left = 0, CorrectRotate = 180 },
					new Block { PosX = 43, PosY = 255, X = -3, Y = 3, Top = 3, Right = 4, Bottom = 5, Left = 2, CorrectRotate = 90 },
					new Block { PosX = 128, PosY = 170, X = -2, Y = 2, Top = 6, Right = 3, Bottom = 5, Left = 0, CorrectRotate = 270 },
					new Block { PosX = -42, PosY = 170, X = -4, Y = 2, Top = 1, Right = 6, Bottom = 0, Left = 1, CorrectRotate = 90 },
					new Block { PosX = 213, PosY = 170, X = -1, Y = 2, Top = 6, Right = 1, Bottom = 2, Left = 3, CorrectRotate = 180 },
					new Block { PosX = 298, PosY = 85, X = 0, Y = 1, Top = 5, Right = 7, Bottom = 0, Left = 0, CorrectRotate = 270 },
				}
			};
		}
	}
}