using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hard
{
	public abstract class Level225
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 225,
				MatchsToWin = 11,
				ThreeStarsLimit = 24,
				TwoStarsLimit = 29,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 65, PosY = -130, X = 0, Y = 0, Top = 8, Right = 2, Bottom = 9, Left = 2, CorrectRotate = 270 },
					new Block { PosX = 65, PosY = 0, X = 0, Y = 1, Top = 3, Right = 9, Bottom = 3, Left = 5, CorrectRotate = 90 },
					new Block { PosX = -65, PosY = -130, X = -1, Y = 0, Top = 1, Right = -1, Bottom = -2, Left = -2, CorrectRotate = 180 },
					new Block { PosX = 65, PosY = 130, X = 0, Y = 2, Top = 5, Right = -2, Bottom = 5, Left = 5, CorrectRotate = 270 },
					new Block { PosX = 195, PosY = 0, X = 1, Y = 1, Top = 8, Right = 8, Bottom = 4, Left = 9, CorrectRotate = 270 },
					new Block { PosX = -65, PosY = 0, X = -1, Y = 1, Top = 2, Right = 4, Bottom = 4, Left = 9, CorrectRotate = 90 },
					new Block { PosX = -65, PosY = -260, X = -1, Y = -1, Top = 3, Right = 6, Bottom = 6, Left = -1, CorrectRotate = 90 },
					new Block { PosX = -195, PosY = -130, X = -2, Y = 0, Top = 5, Right = 2, Bottom = -1, Left = 8, CorrectRotate = 180 },
					new Block { PosX = 65, PosY = 260, X = 0, Y = 3, Top = 7, Right = -2, Bottom = 7, Left = 2, CorrectRotate = 90 },
					new Block { PosX = 195, PosY = 130, X = 1, Y = 2, Top = 9, Right = -2, Bottom = 2, Left = 6, CorrectRotate = 270 },
				}
			};
		}
	}
}