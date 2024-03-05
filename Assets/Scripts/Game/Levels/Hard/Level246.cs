using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hard
{
	public abstract class Level246
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 246,
				MatchsToWin = 18,
				ThreeStarsLimit = 39,
				TwoStarsLimit = 47,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 130, PosY = 130, X = 0, Y = 0, Top = 7, Right = 6, Bottom = 6, Left = 1, CorrectRotate = 90 },
					new Block { PosX = 260, PosY = 130, X = 1, Y = 0, Top = 8, Right = 6, Bottom = 1, Left = -2, CorrectRotate = 270 },
					new Block { PosX = 130, PosY = 260, X = 0, Y = 1, Top = 5, Right = 1, Bottom = 0, Left = 9, CorrectRotate = 270 },
					new Block { PosX = 130, PosY = 0, X = 0, Y = -1, Top = 5, Right = 6, Bottom = -1, Left = 6, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = 130, X = -1, Y = 0, Top = 8, Right = 3, Bottom = 0, Left = -1, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = 0, X = -1, Y = -1, Top = 2, Right = -2, Bottom = 5, Left = 8, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = -130, X = -1, Y = -2, Top = 8, Right = 2, Bottom = 9, Left = 1, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = 0, X = -2, Y = -1, Top = 2, Right = 9, Bottom = 4, Left = 3, CorrectRotate = 270 },
					new Block { PosX = 130, PosY = -130, X = 0, Y = -2, Top = 6, Right = 1, Bottom = 4, Left = 3, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = -130, X = -2, Y = -2, Top = 6, Right = -2, Bottom = 5, Left = -2, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = 130, X = -2, Y = 0, Top = -1, Right = 4, Bottom = 1, Left = 2, CorrectRotate = 270 },
					new Block { PosX = 260, PosY = -130, X = 1, Y = -2, Top = 1, Right = 9, Bottom = 3, Left = 8, CorrectRotate = 270 },
					new Block { PosX = 130, PosY = -260, X = 0, Y = -3, Top = -2, Right = 3, Bottom = 8, Left = 4, CorrectRotate = 270 },
					new Block { PosX = -130, PosY = -260, X = -2, Y = -3, Top = 0, Right = 9, Bottom = 8, Left = 3, CorrectRotate = 90 },
					new Block { PosX = -260, PosY = -260, X = -3, Y = -3, Top = 7, Right = 1, Bottom = 7, Left = 6, CorrectRotate = 270 },
				}
			};
		}
	}
}