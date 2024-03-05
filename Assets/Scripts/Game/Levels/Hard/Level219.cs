using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hard
{
	public abstract class Level219
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 219,
				MatchsToWin = 10,
				ThreeStarsLimit = 24,
				TwoStarsLimit = 29,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 130, PosY = 65, X = 0, Y = 0, Top = 3, Right = 2, Bottom = 9, Left = -1, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = 65, X = -1, Y = 0, Top = 4, Right = 6, Bottom = -2, Left = 0, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = 195, X = -1, Y = 1, Top = 7, Right = 7, Bottom = 8, Left = 5, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = -65, X = -1, Y = -1, Top = 8, Right = 2, Bottom = 8, Left = 1, CorrectRotate = 270 },
					new Block { PosX = -130, PosY = 65, X = -2, Y = 0, Top = 8, Right = 4, Bottom = 2, Left = 9, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = -195, X = -1, Y = -2, Top = 1, Right = 5, Bottom = 5, Left = 3, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = -65, X = -2, Y = -1, Top = 0, Right = 0, Bottom = -1, Left = -1, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = 195, X = -2, Y = 1, Top = -1, Right = 5, Bottom = -1, Left = 9, CorrectRotate = 270 },
					new Block { PosX = 130, PosY = -195, X = 0, Y = -2, Top = 1, Right = 2, Bottom = 8, Left = 1, CorrectRotate = 180 },
				}
			};
		}
	}
}