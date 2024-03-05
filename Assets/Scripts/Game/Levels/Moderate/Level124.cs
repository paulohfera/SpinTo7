using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Moderate
{
	public abstract class Level124
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 124,
				MatchsToWin = 16,
				ThreeStarsLimit = 32,
				TwoStarsLimit = 38,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 260, PosY = -130, X = 0, Y = 0, Top = -2, Right = -1, Bottom = 3, Left = 8, CorrectRotate = 180 },
					new Block { PosX = 130, PosY = -130, X = -1, Y = 0, Top = 3, Right = 7, Bottom = 8, Left = -2, CorrectRotate = 90 },
					new Block { PosX = 130, PosY = 0, X = -1, Y = 1, Top = 0, Right = 7, Bottom = -2, Left = 7, CorrectRotate = 180 },
					new Block { PosX = 130, PosY = -260, X = -1, Y = -1, Top = 6, Right = 6, Bottom = 9, Left = 2, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = -130, X = -2, Y = 0, Top = 5, Right = 8, Bottom = 4, Left = 1, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = -130, X = -3, Y = 0, Top = -2, Right = 9, Bottom = 2, Left = -2, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = 0, X = -3, Y = 1, Top = 1, Right = -2, Bottom = 4, Left = -2, CorrectRotate = 270 },
					new Block { PosX = -130, PosY = 130, X = -3, Y = 2, Top = 4, Right = 9, Bottom = 9, Left = 2, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = 0, X = -2, Y = 1, Top = 0, Right = -1, Bottom = 6, Left = 4, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = 130, X = -2, Y = 2, Top = 3, Right = 3, Bottom = 9, Left = 3, CorrectRotate = 90 },
					new Block { PosX = -260, PosY = 130, X = -4, Y = 2, Top = 5, Right = 3, Bottom = 1, Left = -2, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = 260, X = -2, Y = 3, Top = 2, Right = 6, Bottom = 3, Left = 4, CorrectRotate = 90 },
					new Block { PosX = 130, PosY = 130, X = -1, Y = 2, Top = 5, Right = 9, Bottom = -2, Left = 1, CorrectRotate = 270 },
				}
			};
		}
	}
}