using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hard
{
	public abstract class Level258
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 258,
				MatchsToWin = 21,
				ThreeStarsLimit = 39,
				TwoStarsLimit = 47,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 65, PosY = 325, X = 0, Y = 0, Top = 0, Right = -2, Bottom = 8, Left = -2, CorrectRotate = 90 },
					new Block { PosX = 65, PosY = 455, X = 0, Y = 1, Top = 0, Right = 8, Bottom = 1, Left = 9, CorrectRotate = 90 },
					new Block { PosX = 195, PosY = 325, X = 1, Y = 0, Top = -1, Right = -1, Bottom = 1, Left = 6, CorrectRotate = 90 },
					new Block { PosX = 65, PosY = 195, X = 0, Y = -1, Top = 4, Right = -1, Bottom = 3, Left = 9, CorrectRotate = 270 },
					new Block { PosX = 65, PosY = 65, X = 0, Y = -2, Top = 8, Right = 8, Bottom = 2, Left = 4, CorrectRotate = 90 },
					new Block { PosX = -65, PosY = 195, X = -1, Y = -1, Top = -1, Right = 1, Bottom = 1, Left = 4, CorrectRotate = 180 },
					new Block { PosX = -65, PosY = 65, X = -1, Y = -2, Top = -1, Right = 2, Bottom = 2, Left = 8, CorrectRotate = 270 },
					new Block { PosX = -65, PosY = -65, X = -1, Y = -3, Top = -2, Right = 5, Bottom = 6, Left = 6, CorrectRotate = 90 },
					new Block { PosX = -195, PosY = 65, X = -2, Y = -2, Top = 3, Right = 9, Bottom = 5, Left = 3, CorrectRotate = 90 },
					new Block { PosX = 65, PosY = -65, X = 0, Y = -3, Top = -1, Right = 1, Bottom = 3, Left = 3, CorrectRotate = 180 },
					new Block { PosX = -195, PosY = -65, X = -2, Y = -3, Top = 4, Right = 0, Bottom = 4, Left = 9, CorrectRotate = 180 },
					new Block { PosX = -195, PosY = 195, X = -2, Y = -1, Top = 6, Right = -2, Bottom = 3, Left = 7, CorrectRotate = 270 },
					new Block { PosX = 195, PosY = -65, X = 1, Y = -3, Top = 6, Right = -1, Bottom = 4, Left = 2, CorrectRotate = 270 },
					new Block { PosX = 65, PosY = -195, X = 0, Y = -4, Top = -1, Right = 8, Bottom = 8, Left = 9, CorrectRotate = 90 },
					new Block { PosX = 65, PosY = -325, X = 0, Y = -5, Top = 8, Right = 7, Bottom = 9, Left = -2, CorrectRotate = 270 },
					new Block { PosX = -65, PosY = -195, X = -1, Y = -4, Top = 7, Right = 5, Bottom = 1, Left = 8, CorrectRotate = 180 },
					new Block { PosX = 65, PosY = -455, X = 0, Y = -6, Top = 0, Right = 4, Bottom = 0, Left = 0, CorrectRotate = 180 },
				}
			};
		}
	}
}