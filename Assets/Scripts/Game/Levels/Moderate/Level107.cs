using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Moderate
{
	public abstract class Level107
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 107,
				MatchsToWin = 6,
				ThreeStarsLimit = 14,
				TwoStarsLimit = 17,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 130, PosY = 130, X = 0, Y = 0, Top = 9, Right = 3, Bottom = -1, Left = 3, CorrectRotate = 90 },
					new Block { PosX = 130, PosY = 0, X = 0, Y = -1, Top = 6, Right = 9, Bottom = 4, Left = 3, CorrectRotate = 180 },
					new Block { PosX = 130, PosY = -130, X = 0, Y = -2, Top = 5, Right = 1, Bottom = 1, Left = 9, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = 0, X = -1, Y = -1, Top = -2, Right = 5, Bottom = 6, Left = 7, CorrectRotate = 270 },
					new Block { PosX = -130, PosY = 0, X = -2, Y = -1, Top = 8, Right = 2, Bottom = 1, Left = 3, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = 130, X = -2, Y = 0, Top = 5, Right = 8, Bottom = 6, Left = 5, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = -130, X = -2, Y = -2, Top = 1, Right = 8, Bottom = 4, Left = 7, CorrectRotate = 180 },
				}
			};
		}
	}
}