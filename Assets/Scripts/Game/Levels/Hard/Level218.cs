using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hard
{
	public abstract class Level218
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 218,
				MatchsToWin = 10,
				ThreeStarsLimit = 26,
				TwoStarsLimit = 31,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 130, PosY = 0, X = 0, Y = 0, Top = 8, Right = 1, Bottom = 3, Left = 9, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = 0, X = -1, Y = 0, Top = 6, Right = 8, Bottom = -1, Left = 3, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = 130, X = -1, Y = 1, Top = -1, Right = 4, Bottom = 9, Left = -1, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = -130, X = -1, Y = -1, Top = 9, Right = 5, Bottom = 2, Left = -1, CorrectRotate = 270 },
					new Block { PosX = -130, PosY = 0, X = -2, Y = 0, Top = 1, Right = 2, Bottom = 4, Left = 8, CorrectRotate = 180 },
					new Block { PosX = 130, PosY = -130, X = 0, Y = -1, Top = -1, Right = -2, Bottom = -1, Left = 0, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = 260, X = -1, Y = 2, Top = 1, Right = 8, Bottom = -1, Left = -1, CorrectRotate = 270 },
					new Block { PosX = 130, PosY = 130, X = 0, Y = 1, Top = 8, Right = 2, Bottom = -1, Left = 4, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = -260, X = -1, Y = -2, Top = -1, Right = 3, Bottom = 2, Left = 6, CorrectRotate = 180 },
				}
			};
		}
	}
}