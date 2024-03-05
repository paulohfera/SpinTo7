using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Moderate
{
	public abstract class Level125
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 125,
				MatchsToWin = 15,
				ThreeStarsLimit = 34,
				TwoStarsLimit = 41,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = -130, PosY = 130, X = 0, Y = 0, Top = 3, Right = 3, Bottom = 7, Left = 7, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = 130, X = 1, Y = 0, Top = 0, Right = 5, Bottom = 2, Left = 1, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = 0, X = 0, Y = -1, Top = 1, Right = 4, Bottom = 7, Left = 9, CorrectRotate = 90 },
					new Block { PosX = -260, PosY = 130, X = -1, Y = 0, Top = 4, Right = 6, Bottom = 7, Left = 3, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = 260, X = 1, Y = 1, Top = 1, Right = 8, Bottom = 8, Left = 2, CorrectRotate = 90 },
					new Block { PosX = 130, PosY = 130, X = 2, Y = 0, Top = 2, Right = 3, Bottom = 5, Left = 8, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = 0, X = 1, Y = -1, Top = 2, Right = 6, Bottom = 0, Left = 6, CorrectRotate = 270 },
					new Block { PosX = -130, PosY = -130, X = 0, Y = -2, Top = -2, Right = -2, Bottom = 2, Left = -2, CorrectRotate = 270 },
					new Block { PosX = 260, PosY = 130, X = 3, Y = 0, Top = 4, Right = 2, Bottom = 5, Left = -1, CorrectRotate = 270 },
					new Block { PosX = 130, PosY = 0, X = 2, Y = -1, Top = 4, Right = 5, Bottom = 4, Left = 5, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = -130, X = 1, Y = -2, Top = 8, Right = 9, Bottom = 1, Left = -1, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = -260, X = 0, Y = -3, Top = 8, Right = 9, Bottom = 6, Left = 4, CorrectRotate = 90 },
					new Block { PosX = -260, PosY = -130, X = -1, Y = -2, Top = 6, Right = 0, Bottom = 9, Left = 5, CorrectRotate = 180 },
				}
			};
		}
	}
}