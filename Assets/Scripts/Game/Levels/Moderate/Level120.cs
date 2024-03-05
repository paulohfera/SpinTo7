using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Moderate
{
	public abstract class Level120
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 120,
				MatchsToWin = 15,
				ThreeStarsLimit = 28,
				TwoStarsLimit = 33,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = -65, PosY = 0, X = 0, Y = 0, Top = 8, Right = 8, Bottom = 7, Left = 8, CorrectRotate = 270 },
					new Block { PosX = -65, PosY = 130, X = 0, Y = 1, Top = -1, Right = -1, Bottom = 7, Left = 5, CorrectRotate = 180 },
					new Block { PosX = 65, PosY = 0, X = 1, Y = 0, Top = -1, Right = 4, Bottom = 6, Left = 2, CorrectRotate = 90 },
					new Block { PosX = -65, PosY = -130, X = 0, Y = -1, Top = 3, Right = 2, Bottom = -1, Left = -1, CorrectRotate = 270 },
					new Block { PosX = -195, PosY = 0, X = -1, Y = 0, Top = 0, Right = 0, Bottom = 2, Left = -2, CorrectRotate = 270 },
					new Block { PosX = -65, PosY = 260, X = 0, Y = 2, Top = 0, Right = 5, Bottom = 0, Left = 0, CorrectRotate = 90 },
					new Block { PosX = 65, PosY = 130, X = 1, Y = 1, Top = 2, Right = 2, Bottom = 0, Left = 3, CorrectRotate = 90 },
					new Block { PosX = -195, PosY = 130, X = -1, Y = 1, Top = 2, Right = 5, Bottom = 8, Left = 9, CorrectRotate = 90 },
					new Block { PosX = 195, PosY = 0, X = 2, Y = 0, Top = 5, Right = 4, Bottom = 1, Left = 5, CorrectRotate = 270 },
					new Block { PosX = 65, PosY = -130, X = 1, Y = -1, Top = 4, Right = 5, Bottom = 3, Left = -1, CorrectRotate = 90 },
					new Block { PosX = -65, PosY = -260, X = 0, Y = -2, Top = 5, Right = -1, Bottom = 5, Left = 9, CorrectRotate = 180 },
					new Block { PosX = -195, PosY = -130, X = -1, Y = -1, Top = 1, Right = 7, Bottom = 8, Left = -1, CorrectRotate = 90 },
				}
			};
		}
	}
}