using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Moderate
{
	public abstract class Level114
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 114,
				MatchsToWin = 14,
				ThreeStarsLimit = 32,
				TwoStarsLimit = 38,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 130, PosY = -130, X = 0, Y = 0, Top = 8, Right = 0, Bottom = 2, Left = 9, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = -130, X = -1, Y = 0, Top = 6, Right = 3, Bottom = 5, Left = -1, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = 0, X = -1, Y = 1, Top = 9, Right = 2, Bottom = 8, Left = 5, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = -260, X = -1, Y = -1, Top = -1, Right = 1, Bottom = 1, Left = -2, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = -130, X = -2, Y = 0, Top = 4, Right = -2, Bottom = 8, Left = 3, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = 130, X = -1, Y = 2, Top = 8, Right = 2, Bottom = 3, Left = -2, CorrectRotate = 270 },
					new Block { PosX = 130, PosY = 0, X = 0, Y = 1, Top = -1, Right = 7, Bottom = -2, Left = 3, CorrectRotate = 270 },
					new Block { PosX = 130, PosY = -260, X = 0, Y = -1, Top = 7, Right = 6, Bottom = 6, Left = -2, CorrectRotate = 270 },
					new Block { PosX = -130, PosY = -260, X = -2, Y = -1, Top = 8, Right = 2, Bottom = -1, Left = 9, CorrectRotate = 270 },
					new Block { PosX = -130, PosY = 0, X = -2, Y = 1, Top = 4, Right = -1, Bottom = 9, Left = -1, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = 260, X = -1, Y = 3, Top = 0, Right = -1, Bottom = 2, Left = 9, CorrectRotate = 90 },
				}
			};
		}
	}
}