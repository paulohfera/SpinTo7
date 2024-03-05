using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hard
{
	public abstract class Level224
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 224,
				MatchsToWin = 11,
				ThreeStarsLimit = 20,
				TwoStarsLimit = 24,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 130, PosY = 65, X = 0, Y = 0, Top = 5, Right = 3, Bottom = 8, Left = -1, CorrectRotate = 90 },
					new Block { PosX = 260, PosY = 65, X = 1, Y = 0, Top = -1, Right = 8, Bottom = 5, Left = 8, CorrectRotate = 90 },
					new Block { PosX = 130, PosY = -65, X = 0, Y = -1, Top = 9, Right = 6, Bottom = 8, Left = 4, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = -65, X = -1, Y = -1, Top = 1, Right = 7, Bottom = 4, Left = 6, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = 65, X = -1, Y = 0, Top = -1, Right = -1, Bottom = 2, Left = 1, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = -65, X = -2, Y = -1, Top = 0, Right = 1, Bottom = 3, Left = -1, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = 195, X = -1, Y = 1, Top = 8, Right = 0, Bottom = 9, Left = 9, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = 65, X = -2, Y = 0, Top = 9, Right = 0, Bottom = 8, Left = 6, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = -195, X = -2, Y = -2, Top = 1, Right = 8, Bottom = 3, Left = 2, CorrectRotate = 90 },
					new Block { PosX = -260, PosY = -65, X = -3, Y = -1, Top = 7, Right = 9, Bottom = 5, Left = 2, CorrectRotate = 270 },
				}
			};
		}
	}
}