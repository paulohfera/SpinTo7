using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hard
{
	public abstract class Level221
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 221,
				MatchsToWin = 11,
				ThreeStarsLimit = 23,
				TwoStarsLimit = 28,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 65, PosY = 130, X = 0, Y = 0, Top = 3, Right = 6, Bottom = 4, Left = 7, CorrectRotate = 270 },
					new Block { PosX = 65, PosY = 0, X = 0, Y = -1, Top = 4, Right = 1, Bottom = -2, Left = 9, CorrectRotate = 90 },
					new Block { PosX = -65, PosY = 130, X = -1, Y = 0, Top = 2, Right = 2, Bottom = 1, Left = 3, CorrectRotate = 180 },
					new Block { PosX = 195, PosY = 0, X = 1, Y = -1, Top = 6, Right = 7, Bottom = 9, Left = 7, CorrectRotate = 270 },
					new Block { PosX = 65, PosY = -130, X = 0, Y = -2, Top = -2, Right = 3, Bottom = -2, Left = 9, CorrectRotate = 180 },
					new Block { PosX = -65, PosY = 0, X = -1, Y = -1, Top = 9, Right = 1, Bottom = 5, Left = 3, CorrectRotate = 180 },
					new Block { PosX = -65, PosY = 260, X = -1, Y = 1, Top = 9, Right = 1, Bottom = 7, Left = 6, CorrectRotate = 90 },
					new Block { PosX = -195, PosY = 130, X = -2, Y = 0, Top = 6, Right = 1, Bottom = 5, Left = 5, CorrectRotate = 180 },
					new Block { PosX = 65, PosY = -260, X = 0, Y = -3, Top = 4, Right = 0, Bottom = 9, Left = 1, CorrectRotate = 180 },
					new Block { PosX = -65, PosY = -130, X = -1, Y = -2, Top = 5, Right = -2, Bottom = 4, Left = -1, CorrectRotate = 90 },
				}
			};
		}
	}
}