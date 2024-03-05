using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hard
{
	public abstract class Level249
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 249,
				MatchsToWin = 18,
				ThreeStarsLimit = 36,
				TwoStarsLimit = 44,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 0, PosY = 195, X = 0, Y = 0, Top = 8, Right = 4, Bottom = 3, Left = 2, CorrectRotate = 90 },
					new Block { PosX = 130, PosY = 195, X = 1, Y = 0, Top = -2, Right = 4, Bottom = -1, Left = -1, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = 65, X = 0, Y = -1, Top = 8, Right = 5, Bottom = 5, Left = 7, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = 195, X = -1, Y = 0, Top = -1, Right = 3, Bottom = 8, Left = -1, CorrectRotate = 270 },
					new Block { PosX = 130, PosY = 325, X = 1, Y = 1, Top = 8, Right = 9, Bottom = 3, Left = 8, CorrectRotate = 180 },
					new Block { PosX = 260, PosY = 195, X = 2, Y = 0, Top = 4, Right = 8, Bottom = 4, Left = 2, CorrectRotate = 180 },
					new Block { PosX = 130, PosY = 65, X = 1, Y = -1, Top = 1, Right = 0, Bottom = 9, Left = 0, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = -65, X = 0, Y = -2, Top = 4, Right = 2, Bottom = -1, Left = 3, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = 65, X = -1, Y = -1, Top = 8, Right = 8, Bottom = 4, Left = 2, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = -195, X = 0, Y = -3, Top = 8, Right = 6, Bottom = 0, Left = 3, CorrectRotate = 270 },
					new Block { PosX = -130, PosY = -65, X = -1, Y = -2, Top = 6, Right = 5, Bottom = -1, Left = 5, CorrectRotate = 180 },
					new Block { PosX = -260, PosY = 65, X = -2, Y = -1, Top = -1, Right = 8, Bottom = 8, Left = 6, CorrectRotate = 270 },
					new Block { PosX = 130, PosY = -195, X = 1, Y = -3, Top = -2, Right = -1, Bottom = 1, Left = 6, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = -325, X = 0, Y = -4, Top = 5, Right = 1, Bottom = 4, Left = 4, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = -195, X = -1, Y = -3, Top = 0, Right = 1, Bottom = 7, Left = 0, CorrectRotate = 90 },
				}
			};
		}
	}
}