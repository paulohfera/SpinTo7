using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hard
{
	public abstract class Level216
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 216,
				MatchsToWin = 11,
				ThreeStarsLimit = 18,
				TwoStarsLimit = 22,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 195, PosY = 0, X = 0, Y = 0, Top = 0, Right = 9, Bottom = 0, Left = 0, CorrectRotate = 270 },
					new Block { PosX = 65, PosY = 0, X = -1, Y = 0, Top = 7, Right = 0, Bottom = 7, Left = 2, CorrectRotate = 90 },
					new Block { PosX = 65, PosY = 130, X = -1, Y = 1, Top = 7, Right = 9, Bottom = 6, Left = 1, CorrectRotate = 180 },
					new Block { PosX = 65, PosY = -130, X = -1, Y = -1, Top = -2, Right = 5, Bottom = 5, Left = 0, CorrectRotate = 180 },
					new Block { PosX = -65, PosY = -130, X = -2, Y = -1, Top = -1, Right = 1, Bottom = 2, Left = 7, CorrectRotate = 90 },
					new Block { PosX = -65, PosY = 0, X = -2, Y = 0, Top = 5, Right = 9, Bottom = 0, Left = 6, CorrectRotate = 90 },
					new Block { PosX = -195, PosY = -130, X = -3, Y = -1, Top = 5, Right = -2, Bottom = 8, Left = 7, CorrectRotate = 90 },
					new Block { PosX = -65, PosY = 130, X = -2, Y = 1, Top = -2, Right = 4, Bottom = 1, Left = -2, CorrectRotate = 180 },
					new Block { PosX = -195, PosY = 0, X = -3, Y = 0, Top = 9, Right = 3, Bottom = -1, Left = 2, CorrectRotate = 180 },
				}
			};
		}
	}
}