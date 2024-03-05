using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Easy
{
	public abstract class Level024
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 24,
				MatchsToWin = 17,
				ThreeStarsLimit = 28,
				TwoStarsLimit = 33,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 65, PosY = 130, X = 0, Y = 0, Top = 3, Right = 4, Bottom = 0, Left = 3, CorrectRotate = 270 },
					new Block { PosX = 65, PosY = 0, X = 0, Y = -1, Top = 7, Right = 3, Bottom = 3, Left = 6, CorrectRotate = 180 },
					new Block { PosX = -65, PosY = 130, X = -1, Y = 0, Top = 7, Right = 6, Bottom = 3, Left = 2, CorrectRotate = 270 },
					new Block { PosX = 195, PosY = 0, X = 1, Y = -1, Top = 6, Right = 5, Bottom = 3, Left = 1, CorrectRotate = 0 },
					new Block { PosX = 65, PosY = -130, X = 0, Y = -2, Top = 1, Right = 0, Bottom = 0, Left = 4, CorrectRotate = 180 },
					new Block { PosX = -65, PosY = 0, X = -1, Y = -1, Top = 4, Right = 5, Bottom = 6, Left = 1, CorrectRotate = 270 },
					new Block { PosX = -65, PosY = 260, X = -1, Y = 1, Top = 6, Right = 5, Bottom = 2, Left = 1, CorrectRotate = 270 },
					new Block { PosX = -195, PosY = 130, X = -2, Y = 0, Top = 6, Right = 4, Bottom = 2, Left = 7, CorrectRotate = 0 },
					new Block { PosX = 195, PosY = 130, X = 1, Y = 0, Top = 1, Right = 4, Bottom = 2, Left = 5, CorrectRotate = 180 },
					new Block { PosX = 195, PosY = -130, X = 1, Y = -2, Top = 4, Right = 5, Bottom = 1, Left = 3, CorrectRotate = 0 },
					new Block { PosX = 65, PosY = -260, X = 0, Y = -3, Top = 6, Right = 0, Bottom = 7, Left = 1, CorrectRotate = 0 },
					new Block { PosX = -65, PosY = -130, X = -1, Y = -2, Top = 7, Right = 5, Bottom = 6, Left = 2, CorrectRotate = 270 },
					new Block { PosX = -195, PosY = 0, X = -2, Y = -1, Top = 5, Right = 1, Bottom = 6, Left = 6, CorrectRotate = 0 },
				}
			};
		}
	}
}