using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hard
{
	public abstract class Level212
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 212,
				MatchsToWin = 8,
				ThreeStarsLimit = 18,
				TwoStarsLimit = 22,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 130, PosY = -65, X = 0, Y = 0, Top = 6, Right = 6, Bottom = 8, Left = 4, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = -65, X = -1, Y = 0, Top = 7, Right = 1, Bottom = -2, Left = 1, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = 65, X = -1, Y = 1, Top = -1, Right = -1, Bottom = 9, Left = 9, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = -195, X = -1, Y = -1, Top = 9, Right = 0, Bottom = -2, Left = 1, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = -65, X = -2, Y = 0, Top = 6, Right = 0, Bottom = 2, Left = 3, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = 195, X = -1, Y = 2, Top = 8, Right = -2, Bottom = 7, Left = 5, CorrectRotate = 180 },
					new Block { PosX = 130, PosY = 65, X = 0, Y = 1, Top = 5, Right = 1, Bottom = -2, Left = 9, CorrectRotate = 270 },
					new Block { PosX = -130, PosY = 195, X = -2, Y = 2, Top = -2, Right = 6, Bottom = -1, Left = 9, CorrectRotate = 180 },
				}
			};
		}
	}
}