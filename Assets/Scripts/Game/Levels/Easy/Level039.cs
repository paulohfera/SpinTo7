using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Easy
{
	public abstract class Level039
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 39,
				MatchsToWin = 27,
				ThreeStarsLimit = 55,
				TwoStarsLimit = 66,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 0, PosY = 65, X = 0, Y = 0, Top = 6, Right = 6, Bottom = 7, Left = 4, CorrectRotate = 90 },
					new Block { PosX = 130, PosY = 65, X = 1, Y = 0, Top = 1, Right = 0, Bottom = 6, Left = 2, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = -65, X = 0, Y = -1, Top = 7, Right = 2, Bottom = 2, Left = 3, CorrectRotate = 270 },
					new Block { PosX = -130, PosY = 65, X = -1, Y = 0, Top = 5, Right = 4, Bottom = 6, Left = 1, CorrectRotate = 180 },
					new Block { PosX = 130, PosY = 195, X = 1, Y = 1, Top = 1, Right = 1, Bottom = 2, Left = 4, CorrectRotate = 270 },
					new Block { PosX = 260, PosY = 65, X = 2, Y = 0, Top = 0, Right = 1, Bottom = 5, Left = 2, CorrectRotate = 270 },
					new Block { PosX = 130, PosY = -65, X = 1, Y = -1, Top = 3, Right = 1, Bottom = 0, Left = 6, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = -195, X = 0, Y = -2, Top = 2, Right = 6, Bottom = 5, Left = 3, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = -65, X = -1, Y = -1, Top = 5, Right = 2, Bottom = 5, Left = 1, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = 195, X = -1, Y = 1, Top = 6, Right = 1, Bottom = 1, Left = 7, CorrectRotate = 270 },
					new Block { PosX = -260, PosY = 65, X = -2, Y = 0, Top = 2, Right = 3, Bottom = 3, Left = 3, CorrectRotate = 180 },
					new Block { PosX = 130, PosY = 325, X = 1, Y = 2, Top = 3, Right = 1, Bottom = 4, Left = 2, CorrectRotate = 180 },
					new Block { PosX = 260, PosY = 195, X = 2, Y = 1, Top = 2, Right = 5, Bottom = 6, Left = 4, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = 195, X = 0, Y = 1, Top = 1, Right = 1, Bottom = 3, Left = 5, CorrectRotate = 180 },
					new Block { PosX = 260, PosY = -65, X = 2, Y = -1, Top = 0, Right = 4, Bottom = 6, Left = 5, CorrectRotate = 180 },
					new Block { PosX = 130, PosY = -195, X = 1, Y = -2, Top = 4, Right = 6, Bottom = 4, Left = 6, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = -325, X = 0, Y = -3, Top = 3, Right = 5, Bottom = 6, Left = 7, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = -195, X = -1, Y = -2, Top = 0, Right = 7, Bottom = 6, Left = 1, CorrectRotate = 180 },
					new Block { PosX = -260, PosY = -65, X = -2, Y = -1, Top = 2, Right = 1, Bottom = 5, Left = 2, CorrectRotate = 180 },
				}
			};
		}
	}
}
