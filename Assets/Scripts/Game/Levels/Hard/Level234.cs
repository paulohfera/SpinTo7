using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hard
{
	public abstract class Level234
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 234,
				MatchsToWin = 15,
				ThreeStarsLimit = 22,
				TwoStarsLimit = 27,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = -130, PosY = 65, X = 0, Y = 0, Top = 9, Right = 1, Bottom = 7, Left = 0, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = 195, X = 0, Y = 1, Top = 1, Right = 0, Bottom = 8, Left = -1, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = 65, X = 1, Y = 0, Top = 7, Right = -2, Bottom = 8, Left = 5, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = -65, X = 1, Y = -1, Top = 5, Right = 6, Bottom = 2, Left = 0, CorrectRotate = 180 },
					new Block { PosX = 130, PosY = -65, X = 2, Y = -1, Top = 7, Right = 3, Bottom = 5, Left = 9, CorrectRotate = 90 },
					new Block { PosX = 130, PosY = -195, X = 2, Y = -2, Top = 7, Right = -2, Bottom = -1, Left = 4, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = 195, X = 1, Y = 1, Top = 6, Right = 6, Bottom = 5, Left = 9, CorrectRotate = 90 },
					new Block { PosX = -260, PosY = 195, X = -1, Y = 1, Top = 9, Right = -1, Bottom = -1, Left = 7, CorrectRotate = 90 },
					new Block { PosX = 130, PosY = 65, X = 2, Y = 0, Top = -1, Right = 1, Bottom = 2, Left = 4, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = -195, X = 1, Y = -2, Top = 0, Right = 9, Bottom = 7, Left = 2, CorrectRotate = 270 },
					new Block { PosX = -130, PosY = -65, X = 0, Y = -1, Top = 2, Right = -2, Bottom = 1, Left = 4, CorrectRotate = 90 },
					new Block { PosX = 260, PosY = -195, X = 3, Y = -2, Top = 8, Right = 1, Bottom = 6, Left = 3, CorrectRotate = 90 },
				}
			};
		}
	}
}