using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Easy
{
	public abstract class Level044
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 44,
				MatchsToWin = 27,
				ThreeStarsLimit = 45,
				TwoStarsLimit = 53,
				BlockSizes = 85,
				Blocks = new List<Block>
				{
					new Block { PosX = -212, PosY = 43, X = 0, Y = 0, Top = 4, Right = 0, Bottom = 7, Left = 7, CorrectRotate = 90 },
					new Block { PosX = -212, PosY = 128, X = 0, Y = 1, Top = 4, Right = 3, Bottom = 7, Left = 7, CorrectRotate = 90 },
					new Block { PosX = -127, PosY = 128, X = 1, Y = 1, Top = 6, Right = 0, Bottom = 6, Left = 1, CorrectRotate = 180 },
					new Block { PosX = -42, PosY = 128, X = 2, Y = 1, Top = 6, Right = 3, Bottom = 5, Left = 0, CorrectRotate = 90 },
					new Block { PosX = -42, PosY = 43, X = 2, Y = 0, Top = 4, Right = 7, Bottom = 5, Left = 2, CorrectRotate = 90 },
					new Block { PosX = 43, PosY = 43, X = 3, Y = 0, Top = 2, Right = 2, Bottom = 6, Left = 7, CorrectRotate = 180 },
					new Block { PosX = -42, PosY = -42, X = 2, Y = -1, Top = 4, Right = 5, Bottom = 5, Left = 4, CorrectRotate = 90 },
					new Block { PosX = -127, PosY = 43, X = 1, Y = 0, Top = 0, Right = 1, Bottom = 3, Left = 1, CorrectRotate = 90 },
					new Block { PosX = 43, PosY = -42, X = 3, Y = -1, Top = 7, Right = 6, Bottom = 2, Left = 5, CorrectRotate = 270 },
					new Block { PosX = -42, PosY = -127, X = 2, Y = -2, Top = 5, Right = 6, Bottom = 3, Left = 1, CorrectRotate = 180 },
					new Block { PosX = -127, PosY = -42, X = 1, Y = -1, Top = 4, Right = 6, Bottom = 3, Left = 7, CorrectRotate = 90 },
					new Block { PosX = 128, PosY = -42, X = 4, Y = -1, Top = 0, Right = 5, Bottom = 5, Left = 3, CorrectRotate = 90 },
					new Block { PosX = 213, PosY = -42, X = 5, Y = -1, Top = 0, Right = 2, Bottom = 7, Left = 2, CorrectRotate = 180 },
					new Block { PosX = 128, PosY = -127, X = 4, Y = -2, Top = 0, Right = 1, Bottom = 4, Left = 0, CorrectRotate = 180 },
					new Block { PosX = 213, PosY = 43, X = 5, Y = 0, Top = 7, Right = 3, Bottom = 6, Left = 0, CorrectRotate = 90 },
					new Block { PosX = 298, PosY = -42, X = 6, Y = -1, Top = 7, Right = 4, Bottom = 5, Left = 1, CorrectRotate = 270 },
					new Block { PosX = 213, PosY = -127, X = 5, Y = -2, Top = 6, Right = 6, Bottom = 7, Left = 7, CorrectRotate = 270 },
					new Block { PosX = 128, PosY = -212, X = 4, Y = -3, Top = 7, Right = 5, Bottom = 7, Left = 2, CorrectRotate = 180 },
					new Block { PosX = 43, PosY = -127, X = 3, Y = -2, Top = 6, Right = 1, Bottom = 6, Left = 4, CorrectRotate = 90 },
					new Block { PosX = -297, PosY = 128, X = -1, Y = 1, Top = 6, Right = 3, Bottom = 3, Left = 4, CorrectRotate = 90 },
					new Block { PosX = -127, PosY = 213, X = 1, Y = 2, Top = 1, Right = 4, Bottom = 6, Left = 4, CorrectRotate = 180 },
				}
			};
		}
	}
}