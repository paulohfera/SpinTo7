using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hard
{
	public abstract class Level213
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 213,
				MatchsToWin = 9,
				ThreeStarsLimit = 15,
				TwoStarsLimit = 18,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = -130, PosY = -65, X = 0, Y = 0, Top = 6, Right = 1, Bottom = 0, Left = 7, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = -65, X = 1, Y = 0, Top = -1, Right = -2, Bottom = 7, Left = 9, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = 65, X = 1, Y = 1, Top = 2, Right = -1, Bottom = -2, Left = -2, CorrectRotate = 90 },
					new Block { PosX = 130, PosY = -65, X = 2, Y = 0, Top = 6, Right = 8, Bottom = -1, Left = 3, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = -195, X = 1, Y = -1, Top = -2, Right = 9, Bottom = 4, Left = 2, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = 195, X = 1, Y = 2, Top = 9, Right = -2, Bottom = 8, Left = 8, CorrectRotate = 90 },
					new Block { PosX = 130, PosY = 65, X = 2, Y = 1, Top = 9, Right = 3, Bottom = 6, Left = 8, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = 65, X = 0, Y = 1, Top = 6, Right = 5, Bottom = 4, Left = 5, CorrectRotate = 180 },
				}
			};
		}
	}
}