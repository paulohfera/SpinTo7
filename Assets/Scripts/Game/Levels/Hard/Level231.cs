using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hard
{
	public abstract class Level231
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 231,
				MatchsToWin = 15,
				ThreeStarsLimit = 28,
				TwoStarsLimit = 34,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 260, PosY = 130, X = 0, Y = 0, Top = 1, Right = 1, Bottom = 3, Left = 2, CorrectRotate = 90 },
					new Block { PosX = 260, PosY = 0, X = 0, Y = -1, Top = 6, Right = 9, Bottom = 5, Left = 4, CorrectRotate = 180 },
					new Block { PosX = 130, PosY = 0, X = -1, Y = -1, Top = -2, Right = 9, Bottom = -1, Left = 2, CorrectRotate = 270 },
					new Block { PosX = 130, PosY = 130, X = -1, Y = 0, Top = 5, Right = -2, Bottom = -2, Left = 6, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = 0, X = -2, Y = -1, Top = 8, Right = 8, Bottom = 8, Left = 6, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = -130, X = -2, Y = -2, Top = 2, Right = -1, Bottom = 5, Left = 4, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = 0, X = -3, Y = -1, Top = 3, Right = 0, Bottom = -1, Left = 5, CorrectRotate = 90 },
					new Block { PosX = 130, PosY = -130, X = -1, Y = -2, Top = -2, Right = 9, Bottom = 2, Left = -2, CorrectRotate = 270 },
					new Block { PosX = -130, PosY = -130, X = -3, Y = -2, Top = 6, Right = 5, Bottom = 2, Left = 5, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = 130, X = -3, Y = 0, Top = 7, Right = 7, Bottom = 2, Left = -2, CorrectRotate = 270 },
					new Block { PosX = -260, PosY = 0, X = -4, Y = -1, Top = 4, Right = -2, Bottom = 4, Left = -1, CorrectRotate = 90 },
					new Block { PosX = 260, PosY = -130, X = 0, Y = -2, Top = 9, Right = 1, Bottom = 7, Left = 5, CorrectRotate = 90 },
				}
			};
		}
	}
}