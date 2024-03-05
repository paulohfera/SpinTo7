using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hard
{
	public abstract class Level262
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 262,
				MatchsToWin = 26,
				ThreeStarsLimit = 46,
				TwoStarsLimit = 56,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 0, PosY = -130, X = 0, Y = 0, Top = -2, Right = -2, Bottom = 7, Left = 7, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = -130, X = -1, Y = 0, Top = 5, Right = 8, Bottom = 9, Left = 7, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = 0, X = -1, Y = 1, Top = -1, Right = 9, Bottom = 2, Left = 1, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = -260, X = -1, Y = -1, Top = 6, Right = 0, Bottom = -2, Left = -2, CorrectRotate = 90 },
					new Block { PosX = -260, PosY = -130, X = -2, Y = 0, Top = 2, Right = 1, Bottom = 2, Left = 7, CorrectRotate = 270 },
					new Block { PosX = -130, PosY = 130, X = -1, Y = 2, Top = 5, Right = 8, Bottom = 2, Left = 9, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = 0, X = 0, Y = 1, Top = -2, Right = 0, Bottom = 6, Left = 8, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = -260, X = 0, Y = -1, Top = 7, Right = 9, Bottom = 9, Left = 5, CorrectRotate = 180 },
					new Block { PosX = -260, PosY = -260, X = -2, Y = -1, Top = 1, Right = 6, Bottom = 1, Left = 0, CorrectRotate = 90 },
					new Block { PosX = -260, PosY = 0, X = -2, Y = 1, Top = 5, Right = -2, Bottom = -2, Left = 0, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = 260, X = -1, Y = 3, Top = 6, Right = 5, Bottom = 3, Left = -2, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = 130, X = 0, Y = 2, Top = -1, Right = -2, Bottom = 3, Left = -2, CorrectRotate = 180 },
					new Block { PosX = 130, PosY = 130, X = 1, Y = 2, Top = 8, Right = 7, Bottom = 9, Left = 9, CorrectRotate = 270 },
					new Block { PosX = 130, PosY = 260, X = 1, Y = 3, Top = -2, Right = 2, Bottom = 6, Left = 7, CorrectRotate = 180 },
					new Block { PosX = 260, PosY = 130, X = 2, Y = 2, Top = 5, Right = 7, Bottom = -1, Left = 5, CorrectRotate = 270 },
					new Block { PosX = 130, PosY = 0, X = 1, Y = 1, Top = 9, Right = 0, Bottom = 4, Left = 2, CorrectRotate = 90 },
					new Block { PosX = 260, PosY = 260, X = 2, Y = 3, Top = 3, Right = 2, Bottom = 0, Left = 3, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = 260, X = 0, Y = 3, Top = 5, Right = 4, Bottom = 1, Left = -1, CorrectRotate = 270 },
				}
			};
		}
	}
}