using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Moderate
{
	public abstract class Level113
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 113,
				MatchsToWin = 13,
				ThreeStarsLimit = 28,
				TwoStarsLimit = 33,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 0, PosY = 0, X = 0, Y = 0, Top = 7, Right = 9, Bottom = -1, Left = -2, CorrectRotate = 270 },
					new Block { PosX = 130, PosY = 0, X = 1, Y = 0, Top = -1, Right = 0, Bottom = 4, Left = 9, CorrectRotate = 180 },
					new Block { PosX = 260, PosY = 0, X = 2, Y = 0, Top = -2, Right = -2, Bottom = 4, Left = 3, CorrectRotate = 90 },
					new Block { PosX = 130, PosY = -130, X = 1, Y = -1, Top = 8, Right = 8, Bottom = 8, Left = 5, CorrectRotate = 180 },
					new Block { PosX = 260, PosY = 130, X = 2, Y = 1, Top = 5, Right = 2, Bottom = 5, Left = 9, CorrectRotate = 90 },
					new Block { PosX = 130, PosY = 130, X = 1, Y = 1, Top = 2, Right = 3, Bottom = 8, Left = -1, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = 130, X = 0, Y = 1, Top = 1, Right = 9, Bottom = -1, Left = 9, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = 130, X = -1, Y = 1, Top = 8, Right = 1, Bottom = 6, Left = -2, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = 0, X = -1, Y = 0, Top = 8, Right = -2, Bottom = 0, Left = 9, CorrectRotate = 270 },
					new Block { PosX = -130, PosY = -130, X = -1, Y = -1, Top = -1, Right = 0, Bottom = 9, Left = -1, CorrectRotate = 180 },
					new Block { PosX = -260, PosY = 0, X = -2, Y = 0, Top = 7, Right = 9, Bottom = 4, Left = 6, CorrectRotate = 270 },
				}
			};
		}
	}
}