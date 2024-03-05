using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hard
{
	public abstract class Level220
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 220,
				MatchsToWin = 10,
				ThreeStarsLimit = 24,
				TwoStarsLimit = 29,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = -65, PosY = -65, X = 0, Y = 0, Top = 7, Right = 1, Bottom = 3, Left = 4, CorrectRotate = 90 },
					new Block { PosX = -195, PosY = -65, X = -1, Y = 0, Top = 0, Right = 3, Bottom = 0, Left = -1, CorrectRotate = 90 },
					new Block { PosX = -195, PosY = 65, X = -1, Y = 1, Top = 9, Right = 4, Bottom = 8, Left = 7, CorrectRotate = 270 },
					new Block { PosX = -65, PosY = 65, X = 0, Y = 1, Top = 6, Right = 6, Bottom = -2, Left = 8, CorrectRotate = 270 },
					new Block { PosX = -65, PosY = 195, X = 0, Y = 2, Top = 3, Right = -1, Bottom = 3, Left = 1, CorrectRotate = 270 },
					new Block { PosX = 65, PosY = 65, X = 1, Y = 1, Top = 5, Right = 1, Bottom = 5, Left = 8, CorrectRotate = 180 },
					new Block { PosX = 65, PosY = -65, X = 1, Y = 0, Top = 4, Right = 5, Bottom = 4, Left = 2, CorrectRotate = 270 },
					new Block { PosX = 65, PosY = -195, X = 1, Y = -1, Top = 7, Right = -2, Bottom = 5, Left = 2, CorrectRotate = 270 },
					new Block { PosX = 195, PosY = -195, X = 2, Y = -1, Top = 0, Right = 9, Bottom = -1, Left = 3, CorrectRotate = 90 },
				}
			};
		}
	}
}