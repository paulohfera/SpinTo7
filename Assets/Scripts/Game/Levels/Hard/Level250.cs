using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hard
{
	public abstract class Level250
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 250,
				MatchsToWin = 17,
				ThreeStarsLimit = 26,
				TwoStarsLimit = 31,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 65, PosY = 130, X = 0, Y = 0, Top = 5, Right = 8, Bottom = 6, Left = -1, CorrectRotate = 270 },
					new Block { PosX = -65, PosY = 130, X = -1, Y = 0, Top = 9, Right = 3, Bottom = 1, Left = 7, CorrectRotate = 90 },
					new Block { PosX = -65, PosY = 260, X = -1, Y = 1, Top = 7, Right = -2, Bottom = 7, Left = 4, CorrectRotate = 90 },
					new Block { PosX = -65, PosY = 0, X = -1, Y = -1, Top = 0, Right = 0, Bottom = 3, Left = 3, CorrectRotate = 90 },
					new Block { PosX = -195, PosY = 130, X = -2, Y = 0, Top = -1, Right = 5, Bottom = -2, Left = 3, CorrectRotate = 90 },
					new Block { PosX = -65, PosY = 390, X = -1, Y = 2, Top = 9, Right = 3, Bottom = -2, Left = 9, CorrectRotate = 90 },
					new Block { PosX = 65, PosY = 260, X = 0, Y = 1, Top = 0, Right = 7, Bottom = 6, Left = 8, CorrectRotate = 90 },
					new Block { PosX = 65, PosY = 0, X = 0, Y = -1, Top = 4, Right = -1, Bottom = 9, Left = -2, CorrectRotate = 90 },
					new Block { PosX = 65, PosY = 390, X = 0, Y = 2, Top = 9, Right = 6, Bottom = -2, Left = 0, CorrectRotate = 90 },
					new Block { PosX = -195, PosY = 390, X = -2, Y = 2, Top = 5, Right = -1, Bottom = 7, Left = -2, CorrectRotate = 180 },
					new Block { PosX = 195, PosY = 260, X = 1, Y = 1, Top = 0, Right = 1, Bottom = 3, Left = 2, CorrectRotate = 180 },
					new Block { PosX = 195, PosY = 0, X = 1, Y = -1, Top = -2, Right = 5, Bottom = 8, Left = -1, CorrectRotate = 90 },
					new Block { PosX = 65, PosY = -130, X = 0, Y = -2, Top = 0, Right = 9, Bottom = 4, Left = 6, CorrectRotate = 90 },
					new Block { PosX = 65, PosY = -260, X = 0, Y = -3, Top = 9, Right = 5, Bottom = 0, Left = 1, CorrectRotate = 270 },
					new Block { PosX = 65, PosY = -390, X = 0, Y = -4, Top = 6, Right = 2, Bottom = 6, Left = 3, CorrectRotate = 90 },
				}
			};
		}
	}
}