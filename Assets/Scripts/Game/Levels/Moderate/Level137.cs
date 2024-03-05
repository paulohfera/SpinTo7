using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Moderate
{
	public abstract class Level137
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 137,
				MatchsToWin = 24,
				ThreeStarsLimit = 49,
				TwoStarsLimit = 59,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 130, PosY = -65, X = 0, Y = 0, Top = 6, Right = 6, Bottom = 4, Left = 8, CorrectRotate = 270 },
					new Block { PosX = 130, PosY = 65, X = 0, Y = 1, Top = -1, Right = 4, Bottom = -2, Left = 6, CorrectRotate = 180 },
					new Block { PosX = 260, PosY = -65, X = 1, Y = 0, Top = 8, Right = 1, Bottom = 8, Left = 4, CorrectRotate = 180 },
					new Block { PosX = 130, PosY = -195, X = 0, Y = -1, Top = 1, Right = 4, Bottom = 6, Left = 1, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = -195, X = -1, Y = -1, Top = -1, Right = 7, Bottom = 0, Left = 1, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = -65, X = -1, Y = 0, Top = 7, Right = 2, Bottom = 6, Left = 3, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = -195, X = -2, Y = -1, Top = 2, Right = 8, Bottom = 9, Left = 0, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = 65, X = -1, Y = 1, Top = 1, Right = 6, Bottom = -1, Left = 3, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = -65, X = -2, Y = 0, Top = 7, Right = 2, Bottom = 5, Left = -2, CorrectRotate = 90 },
					new Block { PosX = -260, PosY = -195, X = -3, Y = -1, Top = 4, Right = 7, Bottom = 3, Left = -1, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = 195, X = -1, Y = 2, Top = 9, Right = 8, Bottom = 9, Left = 4, CorrectRotate = 270 },
					new Block { PosX = -130, PosY = 195, X = -2, Y = 2, Top = 6, Right = 4, Bottom = 8, Left = -2, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = 325, X = -2, Y = 3, Top = 0, Right = -1, Bottom = 5, Left = -1, CorrectRotate = 90 },
					new Block { PosX = 260, PosY = 65, X = 1, Y = 1, Top = 1, Right = -1, Bottom = 4, Left = -1, CorrectRotate = 90 },
					new Block { PosX = 260, PosY = -195, X = 1, Y = -1, Top = 8, Right = 2, Bottom = 6, Left = -1, CorrectRotate = 270 },
					new Block { PosX = 130, PosY = -325, X = 0, Y = -2, Top = 5, Right = 4, Bottom = 2, Left = 3, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = -325, X = -1, Y = -2, Top = 6, Right = 7, Bottom = 8, Left = 5, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = -325, X = -2, Y = -2, Top = 0, Right = 2, Bottom = -2, Left = 5, CorrectRotate = 270 },
				}
			};
		}
	}
}