using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hard
{
	public abstract class Level207
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 207,
				MatchsToWin = 7,
				ThreeStarsLimit = 16,
				TwoStarsLimit = 19,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 130, PosY = -65, X = 0, Y = 0, Top = 3, Right = -1, Bottom = 4, Left = 6, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = -65, X = -1, Y = 0, Top = 6, Right = 6, Bottom = 3, Left = 5, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = 65, X = -1, Y = 1, Top = -2, Right = 0, Bottom = 3, Left = 1, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = -195, X = -1, Y = -1, Top = 0, Right = 6, Bottom = 8, Left = 2, CorrectRotate = 270 },
					new Block { PosX = -130, PosY = -65, X = -2, Y = 0, Top = 5, Right = -1, Bottom = 1, Left = 1, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = 195, X = -1, Y = 2, Top = 7, Right = -2, Bottom = 5, Left = 8, CorrectRotate = 180 },
					new Block { PosX = 130, PosY = 65, X = 0, Y = 1, Top = 1, Right = 4, Bottom = -2, Left = 1, CorrectRotate = 180 },
				}
			};
		}
	}
}