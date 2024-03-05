using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Easy
{
	public abstract class Level020
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 20,
				MatchsToWin = 16,
				ThreeStarsLimit = 34,
				TwoStarsLimit = 41,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = -65, PosY = 130, X = 0, Y = 0, Top = 5, Right = 3, Bottom = 7, Left = 0, CorrectRotate = 0 },
					new Block { PosX = -65, PosY = 260, X = 0, Y = 1, Top = 2, Right = 3, Bottom = 1, Left = 5, CorrectRotate = 180 },
					new Block { PosX = 65, PosY = 130, X = 1, Y = 0, Top = 7, Right = 4, Bottom = 4, Left = 7, CorrectRotate = 180 },
					new Block { PosX = -65, PosY = 0, X = 0, Y = -1, Top = 5, Right = 7, Bottom = 2, Left = 0, CorrectRotate = 270 },
					new Block { PosX = -65, PosY = -130, X = 0, Y = -2, Top = 0, Right = 2, Bottom = 0, Left = 0, CorrectRotate = 270 },
					new Block { PosX = -195, PosY = 0, X = -1, Y = -1, Top = 6, Right = 5, Bottom = 2, Left = 1, CorrectRotate = 0 },
					new Block { PosX = 65, PosY = -130, X = 1, Y = -2, Top = 5, Right = 1, Bottom = 7, Left = 6, CorrectRotate = 270 },
					new Block { PosX = 65, PosY = 260, X = 1, Y = 1, Top = 3, Right = 3, Bottom = 2, Left = 0, CorrectRotate = 270 },
					new Block { PosX = -195, PosY = 260, X = -1, Y = 1, Top = 5, Right = 4, Bottom = 4, Left = 2, CorrectRotate = 0 },
					new Block { PosX = 195, PosY = 130, X = 2, Y = 0, Top = 3, Right = 1, Bottom = 0, Left = 4, CorrectRotate = 270 },
					new Block { PosX = 65, PosY = 0, X = 1, Y = -1, Top = 1, Right = 2, Bottom = 0, Left = 1, CorrectRotate = 180 },
					new Block { PosX = -65, PosY = -260, X = 0, Y = -3, Top = 6, Right = 4, Bottom = 5, Left = 7, CorrectRotate = 180 },
					new Block { PosX = -195, PosY = -130, X = -1, Y = -2, Top = 7, Right = 2, Bottom = 4, Left = 5, CorrectRotate = 270 },
				}
			};
		}
	}
}