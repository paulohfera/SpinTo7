using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Moderate
{
	public abstract class Level132
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 132,
				MatchsToWin = 18,
				ThreeStarsLimit = 35,
				TwoStarsLimit = 42,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 0, PosY = -325, X = 0, Y = 0, Top = 9, Right = 2, Bottom = 7, Left = 6, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = -195, X = 0, Y = 1, Top = 6, Right = 8, Bottom = 5, Left = 1, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = -65, X = 0, Y = 2, Top = -2, Right = -1, Bottom = -2, Left = 7, CorrectRotate = 270 },
					new Block { PosX = 130, PosY = -195, X = 1, Y = 1, Top = 2, Right = 8, Bottom = 4, Left = 8, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = -195, X = -1, Y = 1, Top = 1, Right = 4, Bottom = 5, Left = 7, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = 65, X = 0, Y = 3, Top = 7, Right = 4, Bottom = 1, Left = 0, CorrectRotate = 90 },
					new Block { PosX = 130, PosY = -65, X = 1, Y = 2, Top = 9, Right = -2, Bottom = 0, Left = -1, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = -65, X = -1, Y = 2, Top = -2, Right = 2, Bottom = 9, Left = 0, CorrectRotate = 90 },
					new Block { PosX = 260, PosY = -195, X = 2, Y = 1, Top = 2, Right = 3, Bottom = -1, Left = -1, CorrectRotate = 180 },
					new Block { PosX = 130, PosY = -325, X = 1, Y = 0, Top = 2, Right = -2, Bottom = -1, Left = 4, CorrectRotate = 180 },
					new Block { PosX = -260, PosY = -195, X = -2, Y = 1, Top = 2, Right = 5, Bottom = 8, Left = 0, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = 195, X = 0, Y = 4, Top = 3, Right = 0, Bottom = 5, Left = 6, CorrectRotate = 180 },
					new Block { PosX = 130, PosY = 195, X = 1, Y = 4, Top = -2, Right = 1, Bottom = 1, Left = 0, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = 195, X = -1, Y = 4, Top = 4, Right = 9, Bottom = 7, Left = 2, CorrectRotate = 90 },
					new Block { PosX = 130, PosY = 325, X = 1, Y = 5, Top = 2, Right = 9, Bottom = 0, Left = 6, CorrectRotate = 90 },
					new Block { PosX = 260, PosY = 195, X = 2, Y = 4, Top = 7, Right = 4, Bottom = 6, Left = 3, CorrectRotate = 90 },
				}
			};
		}
	}
}