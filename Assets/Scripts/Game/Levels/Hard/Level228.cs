using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hard
{
	public abstract class Level228
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 228,
				MatchsToWin = 12,
				ThreeStarsLimit = 27,
				TwoStarsLimit = 32,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 130, PosY = -260, X = 0, Y = 0, Top = 4, Right = 0, Bottom = 2, Left = 0, CorrectRotate = 270 },
					new Block { PosX = 130, PosY = -130, X = 0, Y = 1, Top = 7, Right = 4, Bottom = 4, Left = 7, CorrectRotate = 180 },
					new Block { PosX = 260, PosY = -260, X = 1, Y = 0, Top = 3, Right = 3, Bottom = 5, Left = 3, CorrectRotate = 180 },
					new Block { PosX = 260, PosY = -130, X = 1, Y = 1, Top = 0, Right = 8, Bottom = 2, Left = 2, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = -130, X = -1, Y = 1, Top = 1, Right = -2, Bottom = 3, Left = 3, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = -130, X = -2, Y = 1, Top = 9, Right = 5, Bottom = 5, Left = 6, CorrectRotate = 270 },
					new Block { PosX = -130, PosY = 0, X = -2, Y = 2, Top = 1, Right = -2, Bottom = 2, Left = -1, CorrectRotate = 180 },
					new Block { PosX = -260, PosY = 0, X = -3, Y = 2, Top = 2, Right = -1, Bottom = -2, Left = 9, CorrectRotate = 180 },
					new Block { PosX = -260, PosY = 130, X = -3, Y = 3, Top = 7, Right = 9, Bottom = 9, Left = 6, CorrectRotate = 270 },
					new Block { PosX = -260, PosY = -130, X = -3, Y = 1, Top = 0, Right = 5, Bottom = 2, Left = 5, CorrectRotate = 90 },
					new Block { PosX = -260, PosY = 260, X = -3, Y = 4, Top = -2, Right = 3, Bottom = 2, Left = 1, CorrectRotate = 90 },
				}
			};
		}
	}
}