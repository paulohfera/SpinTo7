using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hard
{
	public abstract class Level240
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 240,
				MatchsToWin = 17,
				ThreeStarsLimit = 36,
				TwoStarsLimit = 44,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 260, PosY = 130, X = 0, Y = 0, Top = 0, Right = -2, Bottom = 2, Left = -1, CorrectRotate = 180 },
					new Block { PosX = 130, PosY = 130, X = -1, Y = 0, Top = 5, Right = 4, Bottom = 9, Left = 7, CorrectRotate = 90 },
					new Block { PosX = 130, PosY = 260, X = -1, Y = 1, Top = 3, Right = 5, Bottom = 8, Left = 0, CorrectRotate = 180 },
					new Block { PosX = 130, PosY = 0, X = -1, Y = -1, Top = -2, Right = 0, Bottom = 9, Left = 1, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = 0, X = -2, Y = -1, Top = 9, Right = 7, Bottom = 1, Left = 6, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = -130, X = -2, Y = -2, Top = -2, Right = 9, Bottom = 6, Left = 0, CorrectRotate = 270 },
					new Block { PosX = -130, PosY = 0, X = -3, Y = -1, Top = 6, Right = 7, Bottom = 8, Left = -2, CorrectRotate = 270 },
					new Block { PosX = 130, PosY = -130, X = -1, Y = -2, Top = 7, Right = 9, Bottom = 9, Left = 6, CorrectRotate = 270 },
					new Block { PosX = 260, PosY = 0, X = 0, Y = -1, Top = -2, Right = 7, Bottom = 5, Left = -1, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = -260, X = -2, Y = -3, Top = 0, Right = -2, Bottom = 4, Left = 0, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = -130, X = -3, Y = -2, Top = 1, Right = -2, Bottom = 9, Left = 0, CorrectRotate = 270 },
					new Block { PosX = -130, PosY = 130, X = -3, Y = 0, Top = 8, Right = 5, Bottom = 7, Left = 9, CorrectRotate = 90 },
					new Block { PosX = -260, PosY = 0, X = -4, Y = -1, Top = -1, Right = 6, Bottom = 1, Left = 7, CorrectRotate = 270 },
					new Block { PosX = 260, PosY = -130, X = 0, Y = -2, Top = 4, Right = -2, Bottom = 0, Left = 8, CorrectRotate = 270 },
				}
			};
		}
	}
}