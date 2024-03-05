using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Easy
{
	public abstract class Level031
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 31,
				MatchsToWin = 22,
				ThreeStarsLimit = 41,
				TwoStarsLimit = 49,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = -260, PosY = 0, X = 0, Y = 0, Top = 0, Right = 3, Bottom = 5, Left = 7, CorrectRotate = 0 },
					new Block { PosX = -260, PosY = 130, X = 0, Y = 1, Top = 7, Right = 1, Bottom = 2, Left = 6, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = 130, X = 1, Y = 1, Top = 6, Right = 2, Bottom = 1, Left = 4, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = 130, X = 2, Y = 1, Top = 4, Right = 1, Bottom = 6, Left = 2, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = 0, X = 1, Y = 0, Top = 7, Right = 4, Bottom = 5, Left = 3, CorrectRotate = 180 },
					new Block { PosX = 130, PosY = 130, X = 3, Y = 1, Top = 7, Right = 2, Bottom = 4, Left = 5, CorrectRotate = 0 },
					new Block { PosX = 0, PosY = 0, X = 2, Y = 0, Top = 2, Right = 4, Bottom = 3, Left = 6, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = -130, X = 1, Y = -1, Top = 0, Right = 3, Bottom = 1, Left = 0, CorrectRotate = 270 },
					new Block { PosX = 130, PosY = 260, X = 3, Y = 2, Top = 0, Right = 7, Bottom = 5, Left = 2, CorrectRotate = 180 },
					new Block { PosX = 260, PosY = 130, X = 4, Y = 1, Top = 7, Right = 2, Bottom = 5, Left = 4, CorrectRotate = 270 },
					new Block { PosX = 130, PosY = 0, X = 3, Y = 0, Top = 0, Right = 2, Bottom = 1, Left = 3, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = -130, X = 2, Y = -1, Top = 7, Right = 3, Bottom = 7, Left = 5, CorrectRotate = 270 },
					new Block { PosX = -130, PosY = -260, X = 1, Y = -2, Top = 1, Right = 6, Bottom = 4, Left = 2, CorrectRotate = 180 },
					new Block { PosX = -260, PosY = -130, X = 0, Y = -1, Top = 7, Right = 1, Bottom = 2, Left = 6, CorrectRotate = 180 },
					new Block { PosX = 260, PosY = 260, X = 4, Y = 2, Top = 2, Right = 3, Bottom = 3, Left = 5, CorrectRotate = 0 },
					new Block { PosX = 0, PosY = 260, X = 2, Y = 2, Top = 1, Right = 2, Bottom = 4, Left = 0, CorrectRotate = 180 },
				}
			};
		}
	}
}