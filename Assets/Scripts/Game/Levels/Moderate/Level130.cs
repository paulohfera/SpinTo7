using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Moderate
{
	public abstract class Level130
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 130,
				MatchsToWin = 18,
				ThreeStarsLimit = 39,
				TwoStarsLimit = 47,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 65, PosY = -65, X = 0, Y = 0, Top = 8, Right = 3, Bottom = 0, Left = -1, CorrectRotate = 270 },
					new Block { PosX = -65, PosY = -65, X = -1, Y = 0, Top = 9, Right = 6, Bottom = -1, Left = 7, CorrectRotate = 180 },
					new Block { PosX = -65, PosY = 65, X = -1, Y = 1, Top = 7, Right = -2, Bottom = 5, Left = 8, CorrectRotate = 90 },
					new Block { PosX = -65, PosY = -195, X = -1, Y = -1, Top = 0, Right = 0, Bottom = -2, Left = 5, CorrectRotate = 180 },
					new Block { PosX = -195, PosY = -65, X = -2, Y = 0, Top = 1, Right = 5, Bottom = 8, Left = 9, CorrectRotate = 270 },
					new Block { PosX = -65, PosY = 195, X = -1, Y = 2, Top = 9, Right = 1, Bottom = 1, Left = 3, CorrectRotate = 180 },
					new Block { PosX = 65, PosY = 65, X = 0, Y = 1, Top = 2, Right = 0, Bottom = 8, Left = 8, CorrectRotate = 90 },
					new Block { PosX = 65, PosY = -195, X = 0, Y = -1, Top = 8, Right = 2, Bottom = 4, Left = 9, CorrectRotate = 180 },
					new Block { PosX = -195, PosY = -195, X = -2, Y = -1, Top = 6, Right = 0, Bottom = 2, Left = 7, CorrectRotate = 180 },
					new Block { PosX = -65, PosY = 325, X = -1, Y = 3, Top = 7, Right = 6, Bottom = 5, Left = 7, CorrectRotate = 270 },
					new Block { PosX = 65, PosY = 195, X = 0, Y = 2, Top = 7, Right = 4, Bottom = 3, Left = 0, CorrectRotate = 180 },
					new Block { PosX = -195, PosY = 195, X = -2, Y = 2, Top = 5, Right = 3, Bottom = 6, Left = 1, CorrectRotate = 90 },
					new Block { PosX = 195, PosY = 65, X = 1, Y = 1, Top = 6, Right = -1, Bottom = 4, Left = 5, CorrectRotate = 180 },
					new Block { PosX = 195, PosY = -195, X = 1, Y = -1, Top = 6, Right = -2, Bottom = 6, Left = -1, CorrectRotate = 180 },
					new Block { PosX = 65, PosY = -325, X = 0, Y = -2, Top = 3, Right = 2, Bottom = -2, Left = -1, CorrectRotate = 270 },
				}
			};
		}
	}
}