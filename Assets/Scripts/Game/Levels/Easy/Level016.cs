using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Easy
{
	public abstract class Level016
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 16,
				MatchsToWin = 11,
				ThreeStarsLimit = 33,
				TwoStarsLimit = 39,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 130, PosY = 325, X = 0, Y = 0, Top = 5, Right = 1, Bottom = 3, Left = 0, CorrectRotate = 180 },
					new Block { PosX = 130, PosY = 195, X = 0, Y = -1, Top = 7, Right = 1, Bottom = 2, Left = 2, CorrectRotate = 270 },
					new Block { PosX = 130, PosY = 65, X = 0, Y = -2, Top = 1, Right = 5, Bottom = 6, Left = 7, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = 195, X = -1, Y = -1, Top = 5, Right = 0, Bottom = 1, Left = 6, CorrectRotate = 270 },
					new Block { PosX = 260, PosY = 65, X = 1, Y = -2, Top = 2, Right = 0, Bottom = 7, Left = 1, CorrectRotate = 180 },
					new Block { PosX = 130, PosY = -65, X = 0, Y = -3, Top = 6, Right = 1, Bottom = 4, Left = 4, CorrectRotate = 0 },
					new Block { PosX = 0, PosY = -65, X = -1, Y = -3, Top = 5, Right = 1, Bottom = 6, Left = 3, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = -65, X = -2, Y = -3, Top = 3, Right = 6, Bottom = 6, Left = 4, CorrectRotate = 0 },
					new Block { PosX = -130, PosY = 65, X = -2, Y = -2, Top = 4, Right = 5, Bottom = 0, Left = 2, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = -195, X = -2, Y = -4, Top = 6, Right = 0, Bottom = 6, Left = 1, CorrectRotate = 270 },
					new Block { PosX = -130, PosY = -325, X = -2, Y = -5, Top = 2, Right = 1, Bottom = 4, Left = 7, CorrectRotate = 270 },
					new Block { PosX = -260, PosY = -195, X = -3, Y = -4, Top = 1, Right = 4, Bottom = 6, Left = 0, CorrectRotate = 270 },
				}
			};
		}
	}
}