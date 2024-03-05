using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Moderate
{
	public abstract class Level106
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 106,
				MatchsToWin = 7,
				ThreeStarsLimit = 22,
				TwoStarsLimit = 26,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 65, PosY = 0, X = 0, Y = 0, Top = 9, Right = 8, Bottom = 2, Left = 4, CorrectRotate = 90 },
					new Block { PosX = -65, PosY = 0, X = -1, Y = 0, Top = -2, Right = 0, Bottom = 5, Left = 5, CorrectRotate = 270 },
					new Block { PosX = -65, PosY = -130, X = -1, Y = -1, Top = 8, Right = 8, Bottom = 1, Left = 7, CorrectRotate = 270 },
					new Block { PosX = -195, PosY = 0, X = -2, Y = 0, Top = 8, Right = 8, Bottom = 3, Left = 2, CorrectRotate = 180 },
					new Block { PosX = 65, PosY = -130, X = 0, Y = -1, Top = -1, Right = -1, Bottom = -1, Left = 3, CorrectRotate = 270 },
					new Block { PosX = 65, PosY = 130, X = 0, Y = 1, Top = 1, Right = -1, Bottom = 4, Left = 6, CorrectRotate = 270 },
					new Block { PosX = 195, PosY = 0, X = 1, Y = 0, Top = 6, Right = 5, Bottom = 2, Left = -1, CorrectRotate = 180 },
				}
			};
		}
	}
}