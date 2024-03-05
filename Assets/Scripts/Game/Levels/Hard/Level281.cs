using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hard
{
	public abstract class Level281
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 281,
				MatchsToWin = 30,
				ThreeStarsLimit = 57,
				TwoStarsLimit = 69,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 0, PosY = 65, X = 0, Y = 0, Top = -2, Right = -1, Bottom = 5, Left = 5, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = -65, X = 0, Y = -1, Top = 4, Right = -1, Bottom = 8, Left = 7, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = 65, X = -1, Y = 0, Top = -1, Right = 1, Bottom = 2, Left = 6, CorrectRotate = 90 },
					new Block { PosX = 130, PosY = -65, X = 1, Y = -1, Top = 0, Right = 9, Bottom = 1, Left = 5, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = 195, X = -1, Y = 1, Top = 6, Right = 7, Bottom = 7, Left = 7, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = -65, X = -1, Y = -1, Top = 8, Right = 6, Bottom = 9, Left = 1, CorrectRotate = 270 },
					new Block { PosX = 130, PosY = 65, X = 1, Y = 0, Top = -2, Right = 9, Bottom = 5, Left = 8, CorrectRotate = 180 },
					new Block { PosX = 130, PosY = -195, X = 1, Y = -2, Top = 1, Right = 5, Bottom = 3, Left = 2, CorrectRotate = 270 },
					new Block { PosX = -130, PosY = 325, X = -1, Y = 2, Top = 0, Right = 4, Bottom = 4, Left = 0, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = 195, X = 0, Y = 1, Top = 2, Right = 0, Bottom = 2, Left = 7, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = -195, X = -1, Y = -2, Top = 0, Right = 1, Bottom = 1, Left = -1, CorrectRotate = 90 },
					new Block { PosX = -260, PosY = -65, X = -2, Y = -1, Top = 5, Right = 3, Bottom = 1, Left = -2, CorrectRotate = 180 },
					new Block { PosX = 130, PosY = 195, X = 1, Y = 1, Top = 2, Right = 0, Bottom = 9, Left = -2, CorrectRotate = 180 },
					new Block { PosX = 260, PosY = 65, X = 2, Y = 0, Top = 0, Right = 3, Bottom = -1, Left = 0, CorrectRotate = 270 },
					new Block { PosX = 260, PosY = -195, X = 2, Y = -2, Top = 7, Right = 4, Bottom = 6, Left = -1, CorrectRotate = 270 },
					new Block { PosX = -260, PosY = 195, X = -2, Y = 1, Top = 1, Right = 6, Bottom = 2, Left = 0, CorrectRotate = 180 },
					new Block { PosX = 130, PosY = -325, X = 1, Y = -3, Top = 9, Right = -2, Bottom = 6, Left = 2, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = -195, X = 0, Y = -2, Top = 6, Right = 3, Bottom = 4, Left = 7, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = 325, X = 0, Y = 2, Top = 5, Right = 5, Bottom = 7, Left = 6, CorrectRotate = 270 },
					new Block { PosX = -260, PosY = 325, X = -2, Y = 2, Top = 8, Right = 4, Bottom = 3, Left = 5, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = -325, X = -1, Y = -3, Top = -1, Right = 8, Bottom = 8, Left = 5, CorrectRotate = 180 },
					new Block { PosX = -260, PosY = -195, X = -2, Y = -2, Top = 7, Right = 1, Bottom = -1, Left = 2, CorrectRotate = 270 },
				}
			};
		}
	}
}