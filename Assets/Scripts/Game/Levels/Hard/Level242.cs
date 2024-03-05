using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hard
{
	public abstract class Level242
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 242,
				MatchsToWin = 18,
				ThreeStarsLimit = 33,
				TwoStarsLimit = 40,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = -130, PosY = 130, X = 0, Y = 0, Top = 8, Right = 2, Bottom = 8, Left = 4, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = 130, X = 1, Y = 0, Top = 3, Right = 4, Bottom = 7, Left = 3, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = 0, X = 0, Y = -1, Top = 2, Right = -2, Bottom = 5, Left = -1, CorrectRotate = 270 },
					new Block { PosX = -260, PosY = 130, X = -1, Y = 0, Top = 5, Right = 6, Bottom = 3, Left = 3, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = 260, X = 1, Y = 1, Top = 4, Right = 3, Bottom = 0, Left = 3, CorrectRotate = 270 },
					new Block { PosX = 130, PosY = 130, X = 2, Y = 0, Top = 2, Right = -2, Bottom = 0, Left = 4, CorrectRotate = 270 },
					new Block { PosX = 130, PosY = 0, X = 2, Y = -1, Top = 0, Right = 9, Bottom = 7, Left = -2, CorrectRotate = 90 },
					new Block { PosX = 260, PosY = 0, X = 3, Y = -1, Top = 0, Right = 0, Bottom = 1, Left = 8, CorrectRotate = 90 },
					new Block { PosX = 130, PosY = -130, X = 2, Y = -2, Top = 9, Right = 1, Bottom = 9, Left = 8, CorrectRotate = 180 },
					new Block { PosX = 130, PosY = 260, X = 2, Y = 1, Top = 3, Right = 2, Bottom = 4, Left = 3, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = 260, X = 0, Y = 1, Top = -2, Right = 5, Bottom = 7, Left = -1, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = 0, X = 1, Y = -1, Top = 5, Right = 4, Bottom = 7, Left = 2, CorrectRotate = 90 },
					new Block { PosX = 260, PosY = -130, X = 3, Y = -2, Top = 0, Right = 0, Bottom = -1, Left = -1, CorrectRotate = 270 },
					new Block { PosX = 130, PosY = -260, X = 2, Y = -3, Top = 4, Right = 8, Bottom = -2, Left = 0, CorrectRotate = 180 },
				}
			};
		}
	}
}