using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Moderate
{
	public abstract class Level111
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 111,
				MatchsToWin = 12,
				ThreeStarsLimit = 24,
				TwoStarsLimit = 29,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 65, PosY = 65, X = 0, Y = 0, Top = 2, Right = 9, Bottom = 7, Left = 3, CorrectRotate = 270 },
					new Block { PosX = 65, PosY = 195, X = 0, Y = 1, Top = 0, Right = 1, Bottom = -2, Left = 4, CorrectRotate = 90 },
					new Block { PosX = 195, PosY = 65, X = 1, Y = 0, Top = 5, Right = 4, Bottom = -1, Left = 1, CorrectRotate = 90 },
					new Block { PosX = 65, PosY = -65, X = 0, Y = -1, Top = 1, Right = 8, Bottom = -2, Left = 5, CorrectRotate = 180 },
					new Block { PosX = -65, PosY = -65, X = -1, Y = -1, Top = 0, Right = 8, Bottom = -1, Left = 6, CorrectRotate = 90 },
					new Block { PosX = -65, PosY = 65, X = -1, Y = 0, Top = 0, Right = -1, Bottom = 2, Left = 9, CorrectRotate = 270 },
					new Block { PosX = -195, PosY = -65, X = -2, Y = -1, Top = 3, Right = 0, Bottom = 7, Left = 5, CorrectRotate = 90 },
					new Block { PosX = -65, PosY = -195, X = -1, Y = -2, Top = 8, Right = 0, Bottom = 1, Left = 6, CorrectRotate = 180 },
					new Block { PosX = -65, PosY = 195, X = -1, Y = 1, Top = 7, Right = -2, Bottom = -1, Left = 8, CorrectRotate = 270 },
					new Block { PosX = -195, PosY = 65, X = -2, Y = 0, Top = 7, Right = 9, Bottom = 9, Left = 5, CorrectRotate = 180 },
				}
			};
		}
	}
}