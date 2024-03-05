using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hard
{
	public abstract class Level243
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 243,
				MatchsToWin = 17,
				ThreeStarsLimit = 34,
				TwoStarsLimit = 41,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 0, PosY = -65, X = 0, Y = 0, Top = 5, Right = 5, Bottom = 5, Left = 6, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = 65, X = 0, Y = 1, Top = 3, Right = 1, Bottom = 1, Left = 1, CorrectRotate = 90 },
					new Block { PosX = 130, PosY = -65, X = 1, Y = 0, Top = 3, Right = 2, Bottom = 7, Left = 4, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = -195, X = 0, Y = -1, Top = -2, Right = 1, Bottom = 2, Left = -2, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = -65, X = -1, Y = 0, Top = 2, Right = 8, Bottom = 4, Left = 8, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = 195, X = 0, Y = 2, Top = 9, Right = 6, Bottom = 5, Left = 9, CorrectRotate = 270 },
					new Block { PosX = 130, PosY = 65, X = 1, Y = 1, Top = 6, Right = 8, Bottom = -1, Left = 0, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = 65, X = -1, Y = 1, Top = 1, Right = 8, Bottom = 4, Left = -1, CorrectRotate = 90 },
					new Block { PosX = 260, PosY = -65, X = 2, Y = 0, Top = -2, Right = 3, Bottom = 3, Left = 9, CorrectRotate = 270 },
					new Block { PosX = 130, PosY = -195, X = 1, Y = -1, Top = 9, Right = 4, Bottom = 9, Left = 8, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = -325, X = 0, Y = -2, Top = 0, Right = 8, Bottom = 9, Left = 8, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = -195, X = -1, Y = -1, Top = 6, Right = -1, Bottom = 6, Left = 2, CorrectRotate = 90 },
					new Block { PosX = -260, PosY = -65, X = -2, Y = 0, Top = 3, Right = 6, Bottom = 1, Left = 3, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = 325, X = 0, Y = 3, Top = 8, Right = -2, Bottom = 8, Left = -1, CorrectRotate = 270 },
				}
			};
		}
	}
}