using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hard
{
	public abstract class Level230
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 230,
				MatchsToWin = 13,
				ThreeStarsLimit = 24,
				TwoStarsLimit = 29,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 260, PosY = 0, X = 0, Y = 0, Top = -2, Right = 1, Bottom = 5, Left = -1, CorrectRotate = 180 },
					new Block { PosX = 260, PosY = 130, X = 0, Y = 1, Top = 2, Right = 2, Bottom = 5, Left = -1, CorrectRotate = 270 },
					new Block { PosX = 130, PosY = 0, X = -1, Y = 0, Top = 0, Right = 3, Bottom = 6, Left = 2, CorrectRotate = 90 },
					new Block { PosX = 130, PosY = -130, X = -1, Y = -1, Top = -1, Right = 5, Bottom = -2, Left = 8, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = -130, X = -2, Y = -1, Top = 3, Right = 0, Bottom = -2, Left = 8, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = 0, X = -2, Y = 0, Top = 0, Right = 3, Bottom = 7, Left = 9, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = -130, X = -3, Y = -1, Top = 2, Right = 1, Bottom = 7, Left = -1, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = 130, X = -2, Y = 1, Top = 9, Right = 4, Bottom = 2, Left = 4, CorrectRotate = 270 },
					new Block { PosX = -130, PosY = 0, X = -3, Y = 0, Top = 5, Right = 4, Bottom = 7, Left = 6, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = -260, X = -3, Y = -2, Top = 2, Right = 3, Bottom = 8, Left = 7, CorrectRotate = 180 },
					new Block { PosX = -260, PosY = -130, X = -4, Y = -1, Top = -2, Right = 1, Bottom = 8, Left = 5, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = 260, X = -2, Y = 2, Top = 8, Right = 2, Bottom = 2, Left = 3, CorrectRotate = 90 },
				}
			};
		}
	}
}