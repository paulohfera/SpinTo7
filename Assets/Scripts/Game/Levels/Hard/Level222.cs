using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hard
{
	public abstract class Level222
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 222,
				MatchsToWin = 9,
				ThreeStarsLimit = 27,
				TwoStarsLimit = 32,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 130, PosY = -65, X = 0, Y = 0, Top = 7, Right = 4, Bottom = 8, Left = 7, CorrectRotate = 90 },
					new Block { PosX = 130, PosY = 65, X = 0, Y = 1, Top = 8, Right = 3, Bottom = 1, Left = 3, CorrectRotate = 270 },
					new Block { PosX = 260, PosY = -65, X = 1, Y = 0, Top = 1, Right = -1, Bottom = -1, Left = 8, CorrectRotate = 180 },
					new Block { PosX = 130, PosY = -195, X = 0, Y = -1, Top = -2, Right = 8, Bottom = 0, Left = 1, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = -65, X = -1, Y = 0, Top = 0, Right = 9, Bottom = 3, Left = 0, CorrectRotate = 270 },
					new Block { PosX = -130, PosY = -65, X = -2, Y = 0, Top = 1, Right = 9, Bottom = 9, Left = 4, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = 65, X = -2, Y = 1, Top = -2, Right = 1, Bottom = 2, Left = 5, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = -195, X = -2, Y = -1, Top = 5, Right = 5, Bottom = 5, Left = 6, CorrectRotate = 270 },
					new Block { PosX = -260, PosY = -65, X = -3, Y = 0, Top = 4, Right = 3, Bottom = -2, Left = 0, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = 195, X = -2, Y = 2, Top = 1, Right = 5, Bottom = 8, Left = -1, CorrectRotate = 270 },
				}
			};
		}
	}
}