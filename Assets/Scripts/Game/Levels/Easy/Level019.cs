using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Easy
{
	public abstract class Level019
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 19,
				MatchsToWin = 14,
				ThreeStarsLimit = 25,
				TwoStarsLimit = 30,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = -130, PosY = 130, X = 0, Y = 0, Top = 4, Right = 0, Bottom = 3, Left = 6, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = 130, X = 1, Y = 0, Top = 1, Right = 4, Bottom = 1, Left = 4, CorrectRotate = 270 },
					new Block { PosX = -130, PosY = 0, X = 0, Y = -1, Top = 3, Right = 2, Bottom = 6, Left = 4, CorrectRotate = 0 },
					new Block { PosX = -260, PosY = 130, X = -1, Y = 0, Top = 2, Right = 7, Bottom = 5, Left = 5, CorrectRotate = 0 },
					new Block { PosX = 0, PosY = 260, X = 1, Y = 1, Top = 3, Right = 0, Bottom = 3, Left = 1, CorrectRotate = 0 },
					new Block { PosX = 130, PosY = 130, X = 2, Y = 0, Top = 3, Right = 6, Bottom = 1, Left = 4, CorrectRotate = 180 },
					new Block { PosX = 130, PosY = 0, X = 2, Y = -1, Top = 2, Right = 6, Bottom = 1, Left = 4, CorrectRotate = 270 },
					new Block { PosX = 260, PosY = 0, X = 3, Y = -1, Top = 4, Right = 1, Bottom = 5, Left = 4, CorrectRotate = 270 },
					new Block { PosX = 130, PosY = -130, X = 2, Y = -2, Top = 4, Right = 0, Bottom = 2, Left = 1, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = 0, X = 1, Y = -1, Top = 5, Right = 5, Bottom = 3, Left = 6, CorrectRotate = 180 },
					new Block { PosX = 260, PosY = -130, X = 3, Y = -2, Top = 3, Right = 6, Bottom = 6, Left = 2, CorrectRotate = 90 },
					new Block { PosX = 130, PosY = -260, X = 2, Y = -3, Top = 7, Right = 0, Bottom = 6, Left = 1, CorrectRotate = 0 },
				}
			};
		}
	}
}