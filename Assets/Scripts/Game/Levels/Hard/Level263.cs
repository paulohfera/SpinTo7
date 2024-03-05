using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hard
{
	public abstract class Level263
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 263,
				MatchsToWin = 22,
				ThreeStarsLimit = 38,
				TwoStarsLimit = 45,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 0, PosY = -195, X = 0, Y = 0, Top = -2, Right = -2, Bottom = -2, Left = -1, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = -65, X = 0, Y = 1, Top = 8, Right = 2, Bottom = 6, Left = -1, CorrectRotate = 180 },
					new Block { PosX = 130, PosY = -195, X = 1, Y = 0, Top = 5, Right = 5, Bottom = 9, Left = 8, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = -325, X = 0, Y = -1, Top = 3, Right = 5, Bottom = 9, Left = 1, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = -195, X = -1, Y = 0, Top = 5, Right = -1, Bottom = 9, Left = 1, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = 65, X = 0, Y = 2, Top = 4, Right = 9, Bottom = 1, Left = 1, CorrectRotate = 90 },
					new Block { PosX = 130, PosY = 65, X = 1, Y = 2, Top = -1, Right = 6, Bottom = -2, Left = -2, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = 65, X = -1, Y = 2, Top = -2, Right = 9, Bottom = 5, Left = 3, CorrectRotate = 180 },
					new Block { PosX = 130, PosY = 195, X = 1, Y = 3, Top = 9, Right = 5, Bottom = 5, Left = 3, CorrectRotate = 180 },
					new Block { PosX = 260, PosY = 65, X = 2, Y = 2, Top = 6, Right = 0, Bottom = 9, Left = 9, CorrectRotate = 270 },
					new Block { PosX = 130, PosY = -65, X = 1, Y = 1, Top = -1, Right = 8, Bottom = 8, Left = 5, CorrectRotate = 180 },
					new Block { PosX = -260, PosY = 65, X = -2, Y = 2, Top = -2, Right = 5, Bottom = -2, Left = 8, CorrectRotate = 90 },
					new Block { PosX = 130, PosY = 325, X = 1, Y = 4, Top = 0, Right = 0, Bottom = 9, Left = 2, CorrectRotate = 90 },
					new Block { PosX = 260, PosY = 195, X = 2, Y = 3, Top = 4, Right = 8, Bottom = 1, Left = -2, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = 195, X = 0, Y = 3, Top = 1, Right = 9, Bottom = 2, Left = -2, CorrectRotate = 90 },
					new Block { PosX = 260, PosY = -65, X = 2, Y = 1, Top = 2, Right = 7, Bottom = 5, Left = -2, CorrectRotate = 90 },
					new Block { PosX = -260, PosY = 195, X = -2, Y = 3, Top = 2, Right = -2, Bottom = 0, Left = -2, CorrectRotate = 180 },
					new Block { PosX = -260, PosY = -65, X = -2, Y = 1, Top = 2, Right = -1, Bottom = 8, Left = 1, CorrectRotate = 90 },
				}
			};
		}
	}
}