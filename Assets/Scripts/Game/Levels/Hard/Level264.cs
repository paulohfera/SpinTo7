using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hard
{
	public abstract class Level264
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 264,
				MatchsToWin = 24,
				ThreeStarsLimit = 44,
				TwoStarsLimit = 53,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 195, PosY = -195, X = 0, Y = 0, Top = 4, Right = 5, Bottom = 4, Left = 6, CorrectRotate = 270 },
					new Block { PosX = 65, PosY = -195, X = -1, Y = 0, Top = 3, Right = 3, Bottom = 3, Left = 3, CorrectRotate = 180 },
					new Block { PosX = 65, PosY = -65, X = -1, Y = 1, Top = -2, Right = 8, Bottom = -2, Left = 4, CorrectRotate = 90 },
					new Block { PosX = -65, PosY = -65, X = -2, Y = 1, Top = 2, Right = 6, Bottom = 8, Left = 9, CorrectRotate = 180 },
					new Block { PosX = -65, PosY = 65, X = -2, Y = 2, Top = 0, Right = -1, Bottom = 3, Left = 5, CorrectRotate = 270 },
					new Block { PosX = -65, PosY = -195, X = -2, Y = 0, Top = 4, Right = 5, Bottom = 4, Left = 2, CorrectRotate = 90 },
					new Block { PosX = -65, PosY = 195, X = -2, Y = 3, Top = 2, Right = 7, Bottom = 0, Left = 4, CorrectRotate = 180 },
					new Block { PosX = 65, PosY = 65, X = -1, Y = 2, Top = -1, Right = 7, Bottom = 6, Left = 2, CorrectRotate = 180 },
					new Block { PosX = -65, PosY = -325, X = -2, Y = -1, Top = 4, Right = 6, Bottom = 5, Left = 1, CorrectRotate = 180 },
					new Block { PosX = -195, PosY = -195, X = -3, Y = 0, Top = 3, Right = 0, Bottom = 8, Left = 8, CorrectRotate = 270 },
					new Block { PosX = -65, PosY = 325, X = -2, Y = 4, Top = -2, Right = -2, Bottom = 8, Left = 7, CorrectRotate = 90 },
					new Block { PosX = 65, PosY = 195, X = -1, Y = 3, Top = 1, Right = 3, Bottom = 2, Left = 2, CorrectRotate = 180 },
					new Block { PosX = -195, PosY = 195, X = -3, Y = 3, Top = -2, Right = -2, Bottom = 0, Left = 8, CorrectRotate = 90 },
					new Block { PosX = 195, PosY = 65, X = 0, Y = 2, Top = 3, Right = 5, Bottom = 5, Left = 0, CorrectRotate = 180 },
					new Block { PosX = 65, PosY = 325, X = -1, Y = 4, Top = 5, Right = -1, Bottom = 6, Left = 8, CorrectRotate = 180 },
					new Block { PosX = -195, PosY = 325, X = -3, Y = 4, Top = 9, Right = 8, Bottom = 1, Left = 9, CorrectRotate = 180 },
					new Block { PosX = 195, PosY = 195, X = 0, Y = 3, Top = 8, Right = 2, Bottom = 5, Left = 4, CorrectRotate = 270 },
					new Block { PosX = -195, PosY = 65, X = -3, Y = 2, Top = 6, Right = 4, Bottom = -1, Left = 4, CorrectRotate = 180 },
				}
			};
		}
	}
}