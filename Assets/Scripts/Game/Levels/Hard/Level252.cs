using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hard
{
	public abstract class Level252
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 252,
				MatchsToWin = 19,
				ThreeStarsLimit = 40,
				TwoStarsLimit = 48,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = -260, PosY = 65, X = 0, Y = 0, Top = 3, Right = 0, Bottom = 6, Left = 7, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = 65, X = 1, Y = 0, Top = 8, Right = 0, Bottom = 9, Left = 8, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = 65, X = 2, Y = 0, Top = -1, Right = 0, Bottom = 4, Left = 6, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = -65, X = 1, Y = -1, Top = -1, Right = 7, Bottom = -1, Left = 7, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = 195, X = 2, Y = 1, Top = 7, Right = 9, Bottom = 0, Left = 0, CorrectRotate = 180 },
					new Block { PosX = 130, PosY = 65, X = 3, Y = 0, Top = 3, Right = -1, Bottom = 6, Left = -1, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = -65, X = 2, Y = -1, Top = 9, Right = 0, Bottom = 1, Left = 3, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = -195, X = 1, Y = -2, Top = 1, Right = 8, Bottom = 3, Left = 9, CorrectRotate = 90 },
					new Block { PosX = 130, PosY = 195, X = 3, Y = 1, Top = 8, Right = 7, Bottom = 3, Left = 5, CorrectRotate = 180 },
					new Block { PosX = 130, PosY = -65, X = 3, Y = -1, Top = 6, Right = 6, Bottom = 4, Left = 8, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = -195, X = 2, Y = -2, Top = 1, Right = 3, Bottom = 4, Left = -2, CorrectRotate = 270 },
					new Block { PosX = -130, PosY = -325, X = 1, Y = -3, Top = 0, Right = 9, Bottom = -2, Left = -2, CorrectRotate = 180 },
					new Block { PosX = -260, PosY = -195, X = 0, Y = -2, Top = 8, Right = 5, Bottom = 6, Left = 6, CorrectRotate = 180 },
					new Block { PosX = 130, PosY = 325, X = 3, Y = 2, Top = 4, Right = 1, Bottom = 6, Left = 6, CorrectRotate = 180 },
					new Block { PosX = 260, PosY = 195, X = 4, Y = 1, Top = 7, Right = -2, Bottom = 2, Left = 9, CorrectRotate = 270 },
					new Block { PosX = 260, PosY = -65, X = 4, Y = -1, Top = 6, Right = -1, Bottom = 1, Left = 1, CorrectRotate = 270 },
				}
			};
		}
	}
}