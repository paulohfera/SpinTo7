using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hard
{
	public abstract class Level223
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 223,
				MatchsToWin = 12,
				ThreeStarsLimit = 27,
				TwoStarsLimit = 32,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 65, PosY = -65, X = 0, Y = 0, Top = -1, Right = 7, Bottom = 4, Left = -2, CorrectRotate = 180 },
					new Block { PosX = -65, PosY = -65, X = -1, Y = 0, Top = 0, Right = 1, Bottom = -1, Left = 0, CorrectRotate = 180 },
					new Block { PosX = -65, PosY = 65, X = -1, Y = 1, Top = 8, Right = 3, Bottom = 4, Left = 9, CorrectRotate = 180 },
					new Block { PosX = -65, PosY = -195, X = -1, Y = -1, Top = 6, Right = 4, Bottom = -1, Left = 7, CorrectRotate = 270 },
					new Block { PosX = -195, PosY = -65, X = -2, Y = 0, Top = 6, Right = 9, Bottom = 3, Left = 9, CorrectRotate = 270 },
					new Block { PosX = 65, PosY = 65, X = 0, Y = 1, Top = -2, Right = 2, Bottom = 9, Left = 3, CorrectRotate = 90 },
					new Block { PosX = 195, PosY = -65, X = 1, Y = 0, Top = -2, Right = 9, Bottom = 3, Left = 8, CorrectRotate = 180 },
					new Block { PosX = 65, PosY = -195, X = 0, Y = -1, Top = 8, Right = 1, Bottom = 1, Left = 8, CorrectRotate = 270 },
					new Block { PosX = -65, PosY = 195, X = -1, Y = 2, Top = 3, Right = 2, Bottom = 9, Left = 4, CorrectRotate = 180 },
					new Block { PosX = -195, PosY = 65, X = -2, Y = 1, Top = -2, Right = 7, Bottom = 9, Left = 4, CorrectRotate = 180 },
				}
			};
		}
	}
}