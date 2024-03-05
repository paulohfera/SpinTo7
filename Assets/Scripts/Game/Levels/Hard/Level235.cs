using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hard
{
	public abstract class Level235
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 235,
				MatchsToWin = 17,
				ThreeStarsLimit = 36,
				TwoStarsLimit = 44,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 65, PosY = 130, X = 0, Y = 0, Top = 0, Right = 9, Bottom = 7, Left = -2, CorrectRotate = 270 },
					new Block { PosX = 65, PosY = 0, X = 0, Y = -1, Top = 2, Right = 3, Bottom = 3, Left = -2, CorrectRotate = 270 },
					new Block { PosX = -65, PosY = 0, X = -1, Y = -1, Top = 5, Right = -1, Bottom = 4, Left = 0, CorrectRotate = 90 },
					new Block { PosX = -65, PosY = -130, X = -1, Y = -2, Top = 7, Right = 9, Bottom = 5, Left = 7, CorrectRotate = 270 },
					new Block { PosX = -195, PosY = 0, X = -2, Y = -1, Top = 8, Right = 9, Bottom = 3, Left = 2, CorrectRotate = 180 },
					new Block { PosX = 65, PosY = -130, X = 0, Y = -2, Top = 8, Right = 0, Bottom = 4, Left = 2, CorrectRotate = 180 },
					new Block { PosX = -195, PosY = -130, X = -2, Y = -2, Top = 8, Right = 5, Bottom = -1, Left = 2, CorrectRotate = 180 },
					new Block { PosX = 65, PosY = 260, X = 0, Y = 1, Top = 9, Right = 7, Bottom = 7, Left = 0, CorrectRotate = 180 },
					new Block { PosX = 195, PosY = 130, X = 1, Y = 0, Top = -1, Right = 7, Bottom = 5, Left = 5, CorrectRotate = 180 },
					new Block { PosX = -65, PosY = 130, X = -1, Y = 0, Top = 0, Right = 8, Bottom = 0, Left = 6, CorrectRotate = 270 },
					new Block { PosX = 195, PosY = 0, X = 1, Y = -1, Top = 3, Right = 5, Bottom = 5, Left = 8, CorrectRotate = 270 },
					new Block { PosX = -65, PosY = -260, X = -1, Y = -3, Top = 6, Right = -2, Bottom = 1, Left = -2, CorrectRotate = 270 },
					new Block { PosX = -195, PosY = 130, X = -2, Y = 0, Top = 2, Right = 6, Bottom = 7, Left = 4, CorrectRotate = 90 },
				}
			};
		}
	}
}