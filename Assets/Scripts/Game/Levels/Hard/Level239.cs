using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hard
{
	public abstract class Level239
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 239,
				MatchsToWin = 15,
				ThreeStarsLimit = 36,
				TwoStarsLimit = 44,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 65, PosY = 65, X = 0, Y = 0, Top = 6, Right = 5, Bottom = 3, Left = 0, CorrectRotate = 90 },
					new Block { PosX = 65, PosY = 195, X = 0, Y = 1, Top = -2, Right = 2, Bottom = 0, Left = 7, CorrectRotate = 270 },
					new Block { PosX = 195, PosY = 65, X = 1, Y = 0, Top = 4, Right = 7, Bottom = 4, Left = 0, CorrectRotate = 270 },
					new Block { PosX = 65, PosY = -65, X = 0, Y = -1, Top = 4, Right = 2, Bottom = 7, Left = 1, CorrectRotate = 180 },
					new Block { PosX = -65, PosY = 65, X = -1, Y = 0, Top = 5, Right = 1, Bottom = 3, Left = 1, CorrectRotate = 180 },
					new Block { PosX = 65, PosY = 325, X = 0, Y = 2, Top = 0, Right = 9, Bottom = -1, Left = -1, CorrectRotate = 180 },
					new Block { PosX = 195, PosY = 195, X = 1, Y = 1, Top = 6, Right = 7, Bottom = 9, Left = -2, CorrectRotate = 270 },
					new Block { PosX = 195, PosY = -65, X = 1, Y = -1, Top = 4, Right = 6, Bottom = 0, Left = 8, CorrectRotate = 180 },
					new Block { PosX = 65, PosY = -195, X = 0, Y = -2, Top = -2, Right = 0, Bottom = 0, Left = 3, CorrectRotate = 270 },
					new Block { PosX = -65, PosY = -195, X = -1, Y = -2, Top = 7, Right = 3, Bottom = 8, Left = 7, CorrectRotate = 270 },
					new Block { PosX = -65, PosY = -325, X = -1, Y = -3, Top = 9, Right = 9, Bottom = 7, Left = 4, CorrectRotate = 270 },
					new Block { PosX = -195, PosY = -195, X = -2, Y = -2, Top = 6, Right = 4, Bottom = 8, Left = -1, CorrectRotate = 180 },
					new Block { PosX = 65, PosY = -325, X = 0, Y = -3, Top = -2, Right = 7, Bottom = -2, Left = 8, CorrectRotate = 90 },
				}
			};
		}
	}
}