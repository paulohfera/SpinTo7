using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Easy
{
	public abstract class Level014
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 14,
				MatchsToWin = 12,
				ThreeStarsLimit = 36,
				TwoStarsLimit = 44,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = -195, PosY = 260, X = 0, Y = 0, Top = 7, Right = 0, Bottom = 0, Left = 5, CorrectRotate = 270 },
					new Block { PosX = -65, PosY = 260, X = 1, Y = 0, Top = 2, Right = 0, Bottom = 2, Left = 2, CorrectRotate = 180 },
					new Block { PosX = -65, PosY = 130, X = 1, Y = -1, Top = 3, Right = 1, Bottom = 6, Left = 5, CorrectRotate = 270 },
					new Block { PosX = 65, PosY = 130, X = 2, Y = -1, Top = 2, Right = 4, Bottom = 3, Left = 6, CorrectRotate = 180 },
					new Block { PosX = 65, PosY = 0, X = 2, Y = -2, Top = 7, Right = 1, Bottom = 2, Left = 5, CorrectRotate = 270 },
					new Block { PosX = 65, PosY = -130, X = 2, Y = -3, Top = 5, Right = 7, Bottom = 6, Left = 0, CorrectRotate = 180 },
					new Block { PosX = -65, PosY = 0, X = 1, Y = -2, Top = 5, Right = 5, Bottom = 3, Left = 6, CorrectRotate = 270 },
					new Block { PosX = 65, PosY = -260, X = 2, Y = -4, Top = 1, Right = 0, Bottom = 6, Left = 2, CorrectRotate = 270 },
					new Block { PosX = -65, PosY = -130, X = 1, Y = -3, Top = 0, Right = 3, Bottom = 3, Left = 2, CorrectRotate = 270 },
					new Block { PosX = -195, PosY = 0, X = 0, Y = -2, Top = 4, Right = 6, Bottom = 7, Left = 0, CorrectRotate = 270 },
					new Block { PosX = 195, PosY = -260, X = 3, Y = -4, Top = 3, Right = 5, Bottom = 6, Left = 4, CorrectRotate = 270 },
				}
			};

		}
	}
}