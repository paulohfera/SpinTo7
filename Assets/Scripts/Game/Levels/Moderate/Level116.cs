using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Moderate
{
	public abstract class Level116
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 116,
				MatchsToWin = 14,
				ThreeStarsLimit = 29,
				TwoStarsLimit = 35,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 195, PosY = -195, X = 0, Y = 0, Top = 4, Right = 5, Bottom = 3, Left = 3, CorrectRotate = 90 },
					new Block { PosX = 65, PosY = -195, X = -1, Y = 0, Top = 2, Right = 0, Bottom = 3, Left = 1, CorrectRotate = 90 },
					new Block { PosX = 65, PosY = -65, X = -1, Y = 1, Top = 7, Right = 8, Bottom = 9, Left = -1, CorrectRotate = 180 },
					new Block { PosX = 65, PosY = -325, X = -1, Y = -1, Top = 5, Right = 6, Bottom = 7, Left = 0, CorrectRotate = 90 },
					new Block { PosX = -65, PosY = -195, X = -2, Y = 0, Top = 1, Right = 2, Bottom = 5, Left = -1, CorrectRotate = 90 },
					new Block { PosX = 65, PosY = 65, X = -1, Y = 2, Top = -2, Right = -1, Bottom = 6, Left = 8, CorrectRotate = 180 },
					new Block { PosX = -65, PosY = 65, X = -2, Y = 2, Top = 8, Right = 0, Bottom = 2, Left = 6, CorrectRotate = 270 },
					new Block { PosX = -65, PosY = 195, X = -2, Y = 3, Top = 8, Right = 3, Bottom = -1, Left = 1, CorrectRotate = 90 },
					new Block { PosX = -65, PosY = -65, X = -2, Y = 1, Top = -1, Right = 5, Bottom = 0, Left = 7, CorrectRotate = 270 },
					new Block { PosX = 65, PosY = 195, X = -1, Y = 3, Top = 6, Right = 1, Bottom = 8, Left = 2, CorrectRotate = 270 },
					new Block { PosX = -195, PosY = -65, X = -3, Y = 1, Top = 7, Right = 8, Bottom = 2, Left = -2, CorrectRotate = 270 },
					new Block { PosX = 65, PosY = 325, X = -1, Y = 4, Top = 5, Right = 5, Bottom = 8, Left = 6, CorrectRotate = 180 },
				}
			};
		}
	}
}