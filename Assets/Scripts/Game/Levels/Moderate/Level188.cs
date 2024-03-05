using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Moderate
{
	public abstract class Level188
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 188,
				MatchsToWin = 45,
				ThreeStarsLimit = 72,
				TwoStarsLimit = 86,
				BlockSizes = 85,
				Blocks = new List<Block>
				{
					new Block { PosX = -127, PosY = 128, X = 0, Y = 0, Top = 7, Right = 5, Bottom = 0, Left = 6, CorrectRotate = 90 },
					new Block { PosX = -42, PosY = 128, X = 1, Y = 0, Top = 5, Right = 7, Bottom = 8, Left = -1, CorrectRotate = 180 },
					new Block { PosX = -212, PosY = 128, X = -1, Y = 0, Top = 4, Right = 0, Bottom = -2, Left = 0, CorrectRotate = 180 },
					new Block { PosX = -42, PosY = 213, X = 1, Y = 1, Top = -1, Right = 1, Bottom = 8, Left = -1, CorrectRotate = 90 },
					new Block { PosX = 43, PosY = 128, X = 2, Y = 0, Top = 8, Right = 5, Bottom = -2, Left = 8, CorrectRotate = 90 },
					new Block { PosX = -42, PosY = 43, X = 1, Y = -1, Top = 2, Right = 4, Bottom = 7, Left = 2, CorrectRotate = 270 },
					new Block { PosX = -212, PosY = 213, X = -1, Y = 1, Top = 6, Right = 2, Bottom = -2, Left = 9, CorrectRotate = 90 },
					new Block { PosX = -212, PosY = 43, X = -1, Y = -1, Top = -1, Right = 3, Bottom = 7, Left = -2, CorrectRotate = 90 },
					new Block { PosX = -297, PosY = 128, X = -2, Y = 0, Top = 2, Right = 9, Bottom = 5, Left = 7, CorrectRotate = 180 },
					new Block { PosX = -42, PosY = 298, X = 1, Y = 2, Top = 6, Right = 2, Bottom = -2, Left = 0, CorrectRotate = 180 },
					new Block { PosX = 43, PosY = 213, X = 2, Y = 1, Top = 2, Right = -1, Bottom = 8, Left = 8, CorrectRotate = 180 },
					new Block { PosX = -127, PosY = 213, X = 0, Y = 1, Top = 8, Right = 2, Bottom = 9, Left = 3, CorrectRotate = 270 },
					new Block { PosX = 43, PosY = 43, X = 2, Y = -1, Top = 2, Right = 5, Bottom = -1, Left = 2, CorrectRotate = 180 },
					new Block { PosX = -42, PosY = -42, X = 1, Y = -2, Top = 4, Right = 8, Bottom = 2, Left = 3, CorrectRotate = 270 },
					new Block { PosX = -127, PosY = 43, X = 0, Y = -1, Top = 0, Right = 1, Bottom = 0, Left = 9, CorrectRotate = 90 },
					new Block { PosX = -297, PosY = 213, X = -2, Y = 1, Top = 2, Right = 9, Bottom = -2, Left = 1, CorrectRotate = 180 },
					new Block { PosX = 43, PosY = 298, X = 2, Y = 2, Top = -1, Right = 7, Bottom = 1, Left = 9, CorrectRotate = 180 },
					new Block { PosX = -127, PosY = 298, X = 0, Y = 2, Top = 5, Right = 4, Bottom = -1, Left = 7, CorrectRotate = 270 },
					new Block { PosX = 128, PosY = 213, X = 3, Y = 1, Top = 9, Right = -1, Bottom = -1, Left = 9, CorrectRotate = 270 },
					new Block { PosX = 128, PosY = 43, X = 3, Y = -1, Top = 5, Right = 1, Bottom = 6, Left = 9, CorrectRotate = 90 },
					new Block { PosX = 128, PosY = -42, X = 3, Y = -2, Top = 0, Right = -2, Bottom = 3, Left = -1, CorrectRotate = 90 },
					new Block { PosX = 213, PosY = -42, X = 4, Y = -2, Top = -2, Right = 3, Bottom = 4, Left = 8, CorrectRotate = 270 },
					new Block { PosX = 128, PosY = -127, X = 3, Y = -3, Top = -1, Right = 8, Bottom = 3, Left = 8, CorrectRotate = 90 },
					new Block { PosX = 43, PosY = -42, X = 2, Y = -2, Top = 3, Right = 5, Bottom = 7, Left = 6, CorrectRotate = 90 },
					new Block { PosX = 213, PosY = -127, X = 4, Y = -3, Top = 1, Right = 0, Bottom = 4, Left = 4, CorrectRotate = 270 },
					new Block { PosX = 128, PosY = -212, X = 3, Y = -4, Top = 0, Right = -1, Bottom = -2, Left = 0, CorrectRotate = 90 },
					new Block { PosX = 43, PosY = -127, X = 2, Y = -3, Top = -1, Right = 5, Bottom = 1, Left = 8, CorrectRotate = 180 },
					new Block { PosX = 298, PosY = -127, X = 5, Y = -3, Top = 0, Right = 6, Bottom = 0, Left = 1, CorrectRotate = 180 },
					new Block { PosX = 213, PosY = -212, X = 4, Y = -4, Top = 9, Right = 9, Bottom = 7, Left = 5, CorrectRotate = 180 },
					new Block { PosX = 128, PosY = -297, X = 3, Y = -5, Top = 6, Right = 2, Bottom = 7, Left = 1, CorrectRotate = 180 },
					new Block { PosX = 298, PosY = -212, X = 5, Y = -4, Top = 2, Right = 7, Bottom = -1, Left = 3, CorrectRotate = 90 },
				}
			};
		}
	}
}