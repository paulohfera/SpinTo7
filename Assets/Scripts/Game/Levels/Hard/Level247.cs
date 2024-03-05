using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hard
{
	public abstract class Level247
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 247,
				MatchsToWin = 18,
				ThreeStarsLimit = 34,
				TwoStarsLimit = 41,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 130, PosY = 0, X = 0, Y = 0, Top = 5, Right = 9, Bottom = -1, Left = 2, CorrectRotate = 90 },
					new Block { PosX = 130, PosY = 130, X = 0, Y = 1, Top = 0, Right = 8, Bottom = 1, Left = -2, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = 130, X = -1, Y = 1, Top = 7, Right = 1, Bottom = 6, Left = 8, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = 0, X = -1, Y = 0, Top = 2, Right = -2, Bottom = -2, Left = 6, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = -130, X = -1, Y = -1, Top = 3, Right = 9, Bottom = 5, Left = 4, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = 0, X = -2, Y = 0, Top = 8, Right = 0, Bottom = 9, Left = -2, CorrectRotate = 90 },
					new Block { PosX = 130, PosY = -130, X = 0, Y = -1, Top = 2, Right = 5, Bottom = 8, Left = 8, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = -130, X = -2, Y = -1, Top = 5, Right = 9, Bottom = 4, Left = -1, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = 130, X = -2, Y = 1, Top = 1, Right = 7, Bottom = 0, Left = 3, CorrectRotate = 270 },
					new Block { PosX = 260, PosY = -130, X = 1, Y = -1, Top = 4, Right = 3, Bottom = -1, Left = 2, CorrectRotate = 270 },
					new Block { PosX = 130, PosY = -260, X = 0, Y = -2, Top = 8, Right = 1, Bottom = -1, Left = 7, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = -260, X = -2, Y = -2, Top = 0, Right = 5, Bottom = 8, Left = 1, CorrectRotate = 180 },
					new Block { PosX = -260, PosY = -130, X = -3, Y = -1, Top = 6, Right = 2, Bottom = -1, Left = 2, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = 260, X = -2, Y = 2, Top = 4, Right = 6, Bottom = 4, Left = 4, CorrectRotate = 180 },
					new Block { PosX = -260, PosY = 130, X = -3, Y = 1, Top = 6, Right = 5, Bottom = 3, Left = 7, CorrectRotate = 180 },
				}
			};
		}
	}
}