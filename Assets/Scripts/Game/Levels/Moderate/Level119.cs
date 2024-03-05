using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Moderate
{
	public abstract class Level119
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 119,
				MatchsToWin = 11,
				ThreeStarsLimit = 34,
				TwoStarsLimit = 41,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 130, PosY = -130, X = 0, Y = 0, Top = 7, Right = 5, Bottom = 5, Left = 6, CorrectRotate = 270 },
					new Block { PosX = 260, PosY = -130, X = 1, Y = 0, Top = 6, Right = 0, Bottom = 9, Left = 9, CorrectRotate = 180 },
					new Block { PosX = 130, PosY = -260, X = 0, Y = -1, Top = 4, Right = 2, Bottom = 2, Left = 3, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = -130, X = -1, Y = 0, Top = -1, Right = 5, Bottom = 7, Left = 2, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = -130, X = -2, Y = 0, Top = 2, Right = 7, Bottom = 7, Left = -2, CorrectRotate = 270 },
					new Block { PosX = -130, PosY = 0, X = -2, Y = 1, Top = 9, Right = 3, Bottom = 5, Left = 9, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = -260, X = -2, Y = -1, Top = 7, Right = 0, Bottom = -2, Left = 1, CorrectRotate = 90 },
					new Block { PosX = -260, PosY = -130, X = -3, Y = 0, Top = 0, Right = 3, Bottom = 9, Left = 9, CorrectRotate = 270 },
					new Block { PosX = -130, PosY = 130, X = -2, Y = 2, Top = 4, Right = -1, Bottom = 8, Left = 4, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = 130, X = -1, Y = 2, Top = 4, Right = 1, Bottom = 3, Left = -2, CorrectRotate = 270 },
					new Block { PosX = -260, PosY = 130, X = -3, Y = 2, Top = 8, Right = 8, Bottom = 9, Left = 8, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = 260, X = -1, Y = 3, Top = 9, Right = 0, Bottom = -2, Left = 3, CorrectRotate = 180 },
				}
			};
		}
	}
}