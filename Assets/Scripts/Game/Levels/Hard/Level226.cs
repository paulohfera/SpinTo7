using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hard
{
	public abstract class Level226
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 226,
				MatchsToWin = 12,
				ThreeStarsLimit = 29,
				TwoStarsLimit = 35,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 195, PosY = -130, X = 0, Y = 0, Top = 9, Right = 3, Bottom = 1, Left = 8, CorrectRotate = 90 },
					new Block { PosX = 65, PosY = -130, X = -1, Y = 0, Top = 7, Right = 0, Bottom = 1, Left = -2, CorrectRotate = 180 },
					new Block { PosX = 195, PosY = -260, X = 0, Y = -1, Top = 8, Right = 4, Bottom = -1, Left = -1, CorrectRotate = 180 },
					new Block { PosX = 65, PosY = 0, X = -1, Y = 1, Top = 6, Right = 6, Bottom = 5, Left = 4, CorrectRotate = 180 },
					new Block { PosX = -65, PosY = 0, X = -2, Y = 1, Top = -1, Right = 1, Bottom = 5, Left = 1, CorrectRotate = 180 },
					new Block { PosX = -65, PosY = 130, X = -2, Y = 2, Top = 0, Right = 2, Bottom = 6, Left = 7, CorrectRotate = 270 },
					new Block { PosX = -65, PosY = -130, X = -2, Y = 0, Top = 7, Right = 6, Bottom = 0, Left = 8, CorrectRotate = 270 },
					new Block { PosX = -65, PosY = 260, X = -2, Y = 3, Top = -1, Right = 0, Bottom = 5, Left = 8, CorrectRotate = 270 },
					new Block { PosX = 65, PosY = 130, X = -1, Y = 2, Top = 2, Right = 7, Bottom = 5, Left = 9, CorrectRotate = 180 },
					new Block { PosX = -65, PosY = -260, X = -2, Y = -1, Top = 4, Right = 1, Bottom = 0, Left = 0, CorrectRotate = 90 },
					new Block { PosX = -195, PosY = -130, X = -3, Y = 0, Top = 7, Right = 8, Bottom = 1, Left = 5, CorrectRotate = 270 },
				}
			};
		}
	}
}