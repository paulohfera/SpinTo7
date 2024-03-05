using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Moderate
{
	public abstract class Level126
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 126,
				MatchsToWin = 18,
				ThreeStarsLimit = 42,
				TwoStarsLimit = 50,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 130, PosY = 0, X = 0, Y = 0, Top = 2, Right = 5, Bottom = 3, Left = 5, CorrectRotate = 270 },
					new Block { PosX = 130, PosY = 130, X = 0, Y = 1, Top = 5, Right = 3, Bottom = 1, Left = 2, CorrectRotate = 90 },
					new Block { PosX = 260, PosY = 0, X = 1, Y = 0, Top = 9, Right = 5, Bottom = 8, Left = -2, CorrectRotate = 180 },
					new Block { PosX = 130, PosY = -130, X = 0, Y = -1, Top = 7, Right = 5, Bottom = 8, Left = 2, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = -130, X = -1, Y = -1, Top = 4, Right = 3, Bottom = 9, Left = -1, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = 0, X = -1, Y = 0, Top = -2, Right = 0, Bottom = 8, Left = 4, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = -130, X = -2, Y = -1, Top = 4, Right = 3, Bottom = 2, Left = 9, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = 130, X = -1, Y = 1, Top = -1, Right = 2, Bottom = -2, Left = 2, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = 0, X = -2, Y = 0, Top = -2, Right = 0, Bottom = 7, Left = -2, CorrectRotate = 90 },
					new Block { PosX = -260, PosY = -130, X = -3, Y = -1, Top = 5, Right = -1, Bottom = 7, Left = 3, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = 260, X = -1, Y = 2, Top = 8, Right = 9, Bottom = 5, Left = 4, CorrectRotate = 270 },
					new Block { PosX = -130, PosY = 130, X = -2, Y = 1, Top = 7, Right = 4, Bottom = 4, Left = 5, CorrectRotate = 180 },
					new Block { PosX = -260, PosY = 0, X = -3, Y = 0, Top = 9, Right = 4, Bottom = -1, Left = 6, CorrectRotate = 270 },
					new Block { PosX = -260, PosY = -260, X = -3, Y = -2, Top = 5, Right = 6, Bottom = 6, Left = 8, CorrectRotate = 270 },
				}
			};
		}
	}
}