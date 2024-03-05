using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Moderate
{
	public abstract class Level115
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 115,
				MatchsToWin = 12,
				ThreeStarsLimit = 28,
				TwoStarsLimit = 33,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 130, PosY = -65, X = 0, Y = 0, Top = -2, Right = 5, Bottom = 6, Left = 4, CorrectRotate = 180 },
					new Block { PosX = 130, PosY = 65, X = 0, Y = 1, Top = 1, Right = -1, Bottom = 0, Left = 7, CorrectRotate = 180 },
					new Block { PosX = 260, PosY = -65, X = 1, Y = 0, Top = 3, Right = -2, Bottom = 7, Left = 6, CorrectRotate = 90 },
					new Block { PosX = 130, PosY = -195, X = 0, Y = -1, Top = 2, Right = 2, Bottom = -2, Left = 9, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = -65, X = -1, Y = 0, Top = 3, Right = -2, Bottom = 6, Left = 2, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = -65, X = -2, Y = 0, Top = 9, Right = 3, Bottom = 1, Left = 8, CorrectRotate = 270 },
					new Block { PosX = -130, PosY = 65, X = -2, Y = 1, Top = -1, Right = 3, Bottom = -1, Left = 1, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = -195, X = -2, Y = -1, Top = -1, Right = 4, Bottom = 8, Left = 3, CorrectRotate = 90 },
					new Block { PosX = -260, PosY = -65, X = -3, Y = 0, Top = 1, Right = 8, Bottom = 6, Left = 0, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = 195, X = -2, Y = 2, Top = -1, Right = 8, Bottom = -2, Left = -1, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = 65, X = -1, Y = 1, Top = 1, Right = 6, Bottom = 7, Left = 8, CorrectRotate = 180 },
				}
			};
		}
	}
}