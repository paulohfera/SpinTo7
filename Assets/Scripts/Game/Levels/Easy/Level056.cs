using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Easy
{
	public abstract class Level056
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 56,
				MatchsToWin = 37,
				ThreeStarsLimit = 65,
				TwoStarsLimit = 78,
				BlockSizes = 85,
				Blocks = new List<Block>
				{
					new Block { PosX = -127, PosY = -42, X = 0, Y = 0, Top = 3, Right = 0, Bottom = 1, Left = 3, CorrectRotate = 180 },
					new Block { PosX = -42, PosY = -42, X = 1, Y = 0, Top = 4, Right = 2, Bottom = 1, Left = 5, CorrectRotate = 90 },
					new Block { PosX = -127, PosY = -127, X = 0, Y = -1, Top = 7, Right = 5, Bottom = 1, Left = 4, CorrectRotate = 270 },
					new Block { PosX = -212, PosY = -42, X = -1, Y = 0, Top = 7, Right = 0, Bottom = 1, Left = 0, CorrectRotate = 270 },
					new Block { PosX = -42, PosY = 43, X = 1, Y = 1, Top = 5, Right = 5, Bottom = 6, Left = 3, CorrectRotate = 270 },
					new Block { PosX = 43, PosY = 43, X = 2, Y = 1, Top = 2, Right = 3, Bottom = 2, Left = 3, CorrectRotate = 90 },
					new Block { PosX = -127, PosY = 43, X = 0, Y = 1, Top = 2, Right = 6, Bottom = 1, Left = 6, CorrectRotate = 90 },
					new Block { PosX = 128, PosY = 43, X = 3, Y = 1, Top = 5, Right = 4, Bottom = 3, Left = 6, CorrectRotate = 90 },
					new Block { PosX = 43, PosY = -42, X = 2, Y = 0, Top = 6, Right = 4, Bottom = 2, Left = 2, CorrectRotate = 90 },
					new Block { PosX = -212, PosY = 43, X = -1, Y = 1, Top = 5, Right = 7, Bottom = 7, Left = 7, CorrectRotate = 270 },
					new Block { PosX = 213, PosY = 43, X = 4, Y = 1, Top = 1, Right = 2, Bottom = 4, Left = 4, CorrectRotate = 270 },
					new Block { PosX = 128, PosY = -42, X = 3, Y = 0, Top = 5, Right = 1, Bottom = 4, Left = 3, CorrectRotate = 90 },
					new Block { PosX = 43, PosY = -127, X = 2, Y = -1, Top = 5, Right = 2, Bottom = 5, Left = 5, CorrectRotate = 270 },
					new Block { PosX = -212, PosY = 128, X = -1, Y = 2, Top = 7, Right = 0, Bottom = 1, Left = 6, CorrectRotate = 270 },
					new Block { PosX = -297, PosY = 43, X = -2, Y = 1, Top = 6, Right = 4, Bottom = 6, Left = 0, CorrectRotate = 180 },
					new Block { PosX = 213, PosY = 128, X = 4, Y = 2, Top = 2, Right = 3, Bottom = 5, Left = 1, CorrectRotate = 270 },
					new Block { PosX = 298, PosY = 43, X = 5, Y = 1, Top = 6, Right = 4, Bottom = 1, Left = 6, CorrectRotate = 90 },
					new Block { PosX = 213, PosY = -42, X = 4, Y = 0, Top = 3, Right = 5, Bottom = 5, Left = 5, CorrectRotate = 90 },
					new Block { PosX = -212, PosY = -127, X = -1, Y = -1, Top = 0, Right = 7, Bottom = 6, Left = 1, CorrectRotate = 90 },
					new Block { PosX = -297, PosY = -42, X = -2, Y = 0, Top = 1, Right = 3, Bottom = 1, Left = 6, CorrectRotate = 180 },
					new Block { PosX = -42, PosY = 128, X = 1, Y = 2, Top = 4, Right = 5, Bottom = 6, Left = 6, CorrectRotate = 180 },
					new Block { PosX = 43, PosY = 128, X = 2, Y = 2, Top = 7, Right = 4, Bottom = 1, Left = 3, CorrectRotate = 270 },
					new Block { PosX = -127, PosY = 128, X = 0, Y = 2, Top = 1, Right = 0, Bottom = 0, Left = 2, CorrectRotate = 180 },
					new Block { PosX = 128, PosY = 128, X = 3, Y = 2, Top = 3, Right = 0, Bottom = 2, Left = 2, CorrectRotate = 180 },
					new Block { PosX = 128, PosY = -127, X = 3, Y = -1, Top = 7, Right = 2, Bottom = 4, Left = 7, CorrectRotate = 180 },
				}
			};
		}
	}
}