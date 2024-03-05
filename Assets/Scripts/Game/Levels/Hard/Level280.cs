using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hard
{
	public abstract class Level280
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 280,
				MatchsToWin = 28,
				ThreeStarsLimit = 41,
				TwoStarsLimit = 50,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 130, PosY = 65, X = 0, Y = 0, Top = 6, Right = 4, Bottom = 9, Left = 0, CorrectRotate = 180 },
					new Block { PosX = 130, PosY = 195, X = 0, Y = 1, Top = -2, Right = 1, Bottom = 8, Left = 4, CorrectRotate = 180 },
					new Block { PosX = 260, PosY = 65, X = 1, Y = 0, Top = 4, Right = 7, Bottom = 2, Left = 5, CorrectRotate = 180 },
					new Block { PosX = 130, PosY = -65, X = 0, Y = -1, Top = -2, Right = 1, Bottom = 7, Left = 9, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = 65, X = -1, Y = 0, Top = -2, Right = 1, Bottom = 3, Left = 1, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = 65, X = -2, Y = 0, Top = 3, Right = 3, Bottom = 3, Left = 9, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = 195, X = -2, Y = 1, Top = 4, Right = 1, Bottom = -2, Left = 8, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = -65, X = -2, Y = -1, Top = -1, Right = 4, Bottom = 0, Left = 0, CorrectRotate = 90 },
					new Block { PosX = -260, PosY = 65, X = -3, Y = 0, Top = 3, Right = -2, Bottom = 5, Left = 4, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = 325, X = -2, Y = 2, Top = 2, Right = 5, Bottom = 6, Left = 9, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = 195, X = -1, Y = 1, Top = 6, Right = 6, Bottom = -1, Left = -2, CorrectRotate = 270 },
					new Block { PosX = -130, PosY = -195, X = -2, Y = -2, Top = 3, Right = 7, Bottom = 0, Left = 7, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = 325, X = -1, Y = 2, Top = 5, Right = 9, Bottom = 1, Left = 4, CorrectRotate = 270 },
					new Block { PosX = -130, PosY = -325, X = -2, Y = -3, Top = -2, Right = 0, Bottom = 0, Left = 8, CorrectRotate = 90 },
					new Block { PosX = -260, PosY = -195, X = -3, Y = -2, Top = 6, Right = 8, Bottom = 4, Left = 8, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = 455, X = -1, Y = 3, Top = 3, Right = -1, Bottom = 7, Left = 8, CorrectRotate = 180 },
					new Block { PosX = 130, PosY = 325, X = 0, Y = 2, Top = 2, Right = 3, Bottom = 8, Left = -1, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = -455, X = -2, Y = -4, Top = 1, Right = -1, Bottom = 8, Left = 1, CorrectRotate = 90 },
					new Block { PosX = -260, PosY = -325, X = -3, Y = -3, Top = -2, Right = -2, Bottom = -1, Left = 9, CorrectRotate = 180 },
					new Block { PosX = -260, PosY = -65, X = -3, Y = -1, Top = 8, Right = 4, Bottom = 8, Left = -1, CorrectRotate = 90 },
					new Block { PosX = 130, PosY = 455, X = 0, Y = 3, Top = 4, Right = -1, Bottom = 9, Left = -2, CorrectRotate = 180 },
				}
			};
		}
	}
}