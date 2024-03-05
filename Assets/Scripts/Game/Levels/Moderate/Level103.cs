using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Moderate
{
	public abstract class Level103
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 103,
				MatchsToWin = 4,
				ThreeStarsLimit = 9,
				TwoStarsLimit = 11,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 130, PosY = 130, X = 0, Y = 0, Top = -2, Right = 8, Bottom = 0, Left = 5, CorrectRotate = 90 },
					new Block { PosX = 130, PosY = 0, X = 0, Y = -1, Top = 6, Right = 2, Bottom = -2, Left = 2, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = 0, X = -1, Y = -1, Top = 7, Right = 4, Bottom = 1, Left = 2, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = -130, X = -1, Y = -2, Top = -1, Right = 2, Bottom = 9, Left = 5, CorrectRotate = 270 },
					new Block { PosX = -130, PosY = -130, X = -2, Y = -2, Top = 8, Right = 3, Bottom = -2, Left = 3, CorrectRotate = 90 },
				}
			};
		}
	}
}