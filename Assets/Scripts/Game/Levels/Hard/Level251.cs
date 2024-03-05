using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hard
{
	public abstract class Level251
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 251,
				MatchsToWin = 21,
				ThreeStarsLimit = 34,
				TwoStarsLimit = 41,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 130, PosY = 325, X = 0, Y = 0, Top = 2, Right = 9, Bottom = 2, Left = 9, CorrectRotate = 90 },
					new Block { PosX = 260, PosY = 325, X = 1, Y = 0, Top = 8, Right = 5, Bottom = 1, Left = 2, CorrectRotate = 180 },
					new Block { PosX = 260, PosY = 195, X = 1, Y = -1, Top = 2, Right = -1, Bottom = -2, Left = 0, CorrectRotate = 90 },
					new Block { PosX = 130, PosY = 195, X = 0, Y = -1, Top = 5, Right = -2, Bottom = 5, Left = 9, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = 195, X = -1, Y = -1, Top = 7, Right = 2, Bottom = 2, Left = 1, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = 65, X = -1, Y = -2, Top = 6, Right = 8, Bottom = 6, Left = 2, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = 195, X = -2, Y = -1, Top = 0, Right = 1, Bottom = 6, Left = 9, CorrectRotate = 270 },
					new Block { PosX = -130, PosY = 65, X = -2, Y = -2, Top = 9, Right = 7, Bottom = 6, Left = -1, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = -65, X = -2, Y = -3, Top = 5, Right = 7, Bottom = -2, Left = -2, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = -195, X = -2, Y = -4, Top = 2, Right = 7, Bottom = 2, Left = -2, CorrectRotate = 180 },
					new Block { PosX = -260, PosY = -65, X = -3, Y = -3, Top = 8, Right = 4, Bottom = 0, Left = 5, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = -195, X = -1, Y = -4, Top = 6, Right = 6, Bottom = 9, Left = 7, CorrectRotate = 270 },
					new Block { PosX = -130, PosY = -325, X = -2, Y = -5, Top = 4, Right = 5, Bottom = 0, Left = 0, CorrectRotate = 90 },
					new Block { PosX = -260, PosY = -195, X = -3, Y = -4, Top = 0, Right = -1, Bottom = 4, Left = 2, CorrectRotate = 270 },
					new Block { PosX = -260, PosY = 65, X = -3, Y = -2, Top = 3, Right = 6, Bottom = 5, Left = 0, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = -65, X = -1, Y = -3, Top = 9, Right = 1, Bottom = 8, Left = 0, CorrectRotate = 90 },
				}
			};
		}
	}
}