using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Moderate
{
	public abstract class Level112
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 112,
				MatchsToWin = 10,
				ThreeStarsLimit = 25,
				TwoStarsLimit = 30,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 130, PosY = -195, X = 0, Y = 0, Top = 9, Right = 0, Bottom = 7, Left = 9, CorrectRotate = 90 },
					new Block { PosX = 130, PosY = -65, X = 0, Y = 1, Top = 4, Right = 7, Bottom = 2, Left = 2, CorrectRotate = 270 },
					new Block { PosX = 260, PosY = -65, X = 1, Y = 1, Top = 2, Right = 3, Bottom = 1, Left = 3, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = -65, X = -1, Y = 1, Top = 5, Right = 4, Bottom = 4, Left = 4, CorrectRotate = 270 },
					new Block { PosX = -130, PosY = -65, X = -2, Y = 1, Top = -2, Right = 8, Bottom = 1, Left = 3, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = 65, X = -2, Y = 2, Top = 6, Right = 9, Bottom = 8, Left = 5, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = -195, X = -2, Y = 0, Top = 9, Right = 8, Bottom = 9, Left = 4, CorrectRotate = 180 },
					new Block { PosX = -260, PosY = -65, X = -3, Y = 1, Top = 3, Right = -1, Bottom = -1, Left = 1, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = 195, X = -2, Y = 3, Top = 0, Right = -1, Bottom = 5, Left = 1, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = 65, X = -1, Y = 2, Top = 2, Right = 5, Bottom = 6, Left = 3, CorrectRotate = 90 },
				}
			};
		}
	}
}