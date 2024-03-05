using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hard
{
	public abstract class Level229
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 229,
				MatchsToWin = 12,
				ThreeStarsLimit = 24,
				TwoStarsLimit = 29,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = -65, PosY = 130, X = 0, Y = 0, Top = 8, Right = 1, Bottom = 2, Left = 0, CorrectRotate = 270 },
					new Block { PosX = -65, PosY = 260, X = 0, Y = 1, Top = 9, Right = -2, Bottom = 2, Left = 7, CorrectRotate = 90 },
					new Block { PosX = 65, PosY = 130, X = 1, Y = 0, Top = 6, Right = -1, Bottom = 9, Left = -1, CorrectRotate = 180 },
					new Block { PosX = -65, PosY = 0, X = 0, Y = -1, Top = 8, Right = 6, Bottom = 3, Left = 8, CorrectRotate = 90 },
					new Block { PosX = -195, PosY = 130, X = -1, Y = 0, Top = 7, Right = 1, Bottom = 7, Left = 5, CorrectRotate = 180 },
					new Block { PosX = -65, PosY = -130, X = 0, Y = -2, Top = 0, Right = 6, Bottom = -1, Left = 2, CorrectRotate = 180 },
					new Block { PosX = -195, PosY = 0, X = -1, Y = -1, Top = 5, Right = 0, Bottom = -1, Left = 4, CorrectRotate = 90 },
					new Block { PosX = -195, PosY = 260, X = -1, Y = 1, Top = 1, Right = 6, Bottom = -2, Left = 0, CorrectRotate = 90 },
					new Block { PosX = 65, PosY = -130, X = 1, Y = -2, Top = 8, Right = 7, Bottom = 5, Left = -1, CorrectRotate = 270 },
					new Block { PosX = 65, PosY = -260, X = 1, Y = -3, Top = -2, Right = 0, Bottom = 3, Left = 6, CorrectRotate = 90 },
					new Block { PosX = 195, PosY = -260, X = 2, Y = -3, Top = 9, Right = 6, Bottom = 4, Left = 2, CorrectRotate = 270 },
				}
			};
		}
	}
}