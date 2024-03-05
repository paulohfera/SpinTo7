using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hard
{
	public abstract class Level227
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 227,
				MatchsToWin = 12,
				ThreeStarsLimit = 26,
				TwoStarsLimit = 31,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = -260, PosY = 195, X = 0, Y = 0, Top = 4, Right = 7, Bottom = -2, Left = 9, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = 195, X = 1, Y = 0, Top = -2, Right = -2, Bottom = 9, Left = 5, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = 65, X = 1, Y = -1, Top = -1, Right = 7, Bottom = 9, Left = 1, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = 65, X = 2, Y = -1, Top = 9, Right = 6, Bottom = 9, Left = 6, CorrectRotate = 180 },
					new Block { PosX = 130, PosY = 65, X = 3, Y = -1, Top = 2, Right = 1, Bottom = 6, Left = 0, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = -65, X = 2, Y = -2, Top = 1, Right = -2, Bottom = 2, Left = 7, CorrectRotate = 90 },
					new Block { PosX = 130, PosY = 195, X = 3, Y = 0, Top = 2, Right = 0, Bottom = -1, Left = 1, CorrectRotate = 90 },
					new Block { PosX = 260, PosY = 65, X = 4, Y = -1, Top = 7, Right = 6, Bottom = 7, Left = 4, CorrectRotate = 270 },
					new Block { PosX = 130, PosY = -65, X = 3, Y = -2, Top = 5, Right = 5, Bottom = -2, Left = 4, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = -195, X = 2, Y = -3, Top = -1, Right = -1, Bottom = 9, Left = 0, CorrectRotate = 270 },
					new Block { PosX = -130, PosY = -65, X = 1, Y = -2, Top = 4, Right = 6, Bottom = 8, Left = 6, CorrectRotate = 180 },
				}
			};
		}
	}
}