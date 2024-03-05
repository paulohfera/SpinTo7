using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hard
{
	public abstract class Level248
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 248,
				MatchsToWin = 20,
				ThreeStarsLimit = 32,
				TwoStarsLimit = 38,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 0, PosY = -260, X = 0, Y = 0, Top = 5, Right = 8, Bottom = 8, Left = 3, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = -130, X = 0, Y = 1, Top = 3, Right = 3, Bottom = -1, Left = -1, CorrectRotate = 90 },
					new Block { PosX = 130, PosY = -260, X = 1, Y = 0, Top = 2, Right = 1, Bottom = -1, Left = 0, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = -390, X = 0, Y = -1, Top = 3, Right = 4, Bottom = 5, Left = 9, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = -260, X = -1, Y = 0, Top = -2, Right = 2, Bottom = 2, Left = 7, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = 0, X = 0, Y = 2, Top = 4, Right = -2, Bottom = -2, Left = 6, CorrectRotate = 180 },
					new Block { PosX = 130, PosY = -130, X = 1, Y = 1, Top = -2, Right = 7, Bottom = 8, Left = -1, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = 130, X = 0, Y = 3, Top = 6, Right = 7, Bottom = 0, Left = 9, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = 130, X = -1, Y = 3, Top = 3, Right = -1, Bottom = 1, Left = 7, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = 260, X = -1, Y = 4, Top = 7, Right = 8, Bottom = -2, Left = 4, CorrectRotate = 270 },
					new Block { PosX = -130, PosY = 0, X = -1, Y = 2, Top = 5, Right = 0, Bottom = 9, Left = 9, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = 390, X = -1, Y = 5, Top = 3, Right = 2, Bottom = 3, Left = 4, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = 260, X = 0, Y = 4, Top = 0, Right = 0, Bottom = 4, Left = 7, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = -130, X = -1, Y = 1, Top = 5, Right = 7, Bottom = -2, Left = 4, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = 390, X = 0, Y = 5, Top = 3, Right = 3, Bottom = 7, Left = 6, CorrectRotate = 180 },
				}
			};
		}
	}
}