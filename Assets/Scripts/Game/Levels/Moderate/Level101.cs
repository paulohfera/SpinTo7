using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Moderate
{
	public abstract class Level101
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 101,
				MatchsToWin = 4,
				ThreeStarsLimit = 10,
				TwoStarsLimit = 12,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 0, PosY = 0, X = 0, Y = 0, Top = 5, Right = 5, Bottom = 0, Left = -2, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = 130, X = 0, Y = 1, Top = 7, Right = 9, Bottom = 5, Left = -2, CorrectRotate = 180 },
					new Block { PosX = 130, PosY = 0, X = 1, Y = 0, Top = 9, Right = -2, Bottom = 7, Left = 0, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = -130, X = 0, Y = -1, Top = -1, Right = 8, Bottom = 2, Left = 6, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = 0, X = -1, Y = 0, Top = 6, Right = -2, Bottom = 2, Left = 5, CorrectRotate = 90 },
				}
			};
		}
	}
}