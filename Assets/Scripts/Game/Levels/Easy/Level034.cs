﻿using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Easy
{
	public abstract class Level034
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 34,
				MatchsToWin = 22,
				ThreeStarsLimit = 41,
				TwoStarsLimit = 49,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 260, PosY = -195, X = 0, Y = 0, Top = 2, Right = 1, Bottom = 1, Left = 4, CorrectRotate = 180 },
					new Block { PosX = 260, PosY = -325, X = 0, Y = -1, Top = 2, Right = 5, Bottom = 6, Left = 2, CorrectRotate = 90 },
					new Block { PosX = 130, PosY = -325, X = -1, Y = -1, Top = 3, Right = 1, Bottom = 4, Left = 5, CorrectRotate = 180 },
					new Block { PosX = 130, PosY = -195, X = -1, Y = 0, Top = 1, Right = 1, Bottom = 6, Left = 3, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = -325, X = -2, Y = -1, Top = 1, Right = 5, Bottom = 6, Left = 3, CorrectRotate = 90 },
					new Block { PosX = 130, PosY = -65, X = -1, Y = 1, Top = 6, Right = 7, Bottom = 0, Left = 0, CorrectRotate = 180 },
					new Block { PosX = 260, PosY = -65, X = 0, Y = 1, Top = 7, Right = 4, Bottom = 0, Left = 6, CorrectRotate = 90 },
					new Block { PosX = 260, PosY = 65, X = 0, Y = 2, Top = 3, Right = 4, Bottom = 4, Left = 5, CorrectRotate = 180 },
					new Block { PosX = 130, PosY = 65, X = -1, Y = 2, Top = 3, Right = 7, Bottom = 0, Left = 0, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = 65, X = -2, Y = 2, Top = 7, Right = 0, Bottom = 6, Left = 5, CorrectRotate = 270 },
					new Block { PosX = -130, PosY = 65, X = -3, Y = 2, Top = 4, Right = 7, Bottom = 1, Left = 2, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = 195, X = -3, Y = 3, Top = 0, Right = 6, Bottom = 5, Left = 6, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = -65, X = -3, Y = 1, Top = 4, Right = 2, Bottom = 5, Left = 5, CorrectRotate = 180 },
					new Block { PosX = -260, PosY = 65, X = -4, Y = 2, Top = 2, Right = 4, Bottom = 3, Left = 7, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = 325, X = -3, Y = 4, Top = 5, Right = 2, Bottom = 2, Left = 1, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = 195, X = -2, Y = 3, Top = 2, Right = 1, Bottom = 4, Left = 2, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = -65, X = -2, Y = 1, Top = 3, Right = 2, Bottom = 7, Left = 0, CorrectRotate = 180 },
				}
			};
		}
	}
}