using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Easy
{
	public abstract class Level017
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 17,
				MatchsToWin = 13,
				ThreeStarsLimit = 32,
				TwoStarsLimit = 38,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 195, PosY = -130, X = 0, Y = 0, Top = 7, Right = 6, Bottom = 1, Left = 0, CorrectRotate = 270 },
					new Block { PosX = 195, PosY = -260, X = 0, Y = -1, Top = 0, Right = 7, Bottom = 0, Left = 1, CorrectRotate = 270 },
					new Block { PosX = 65, PosY = -130, X = -1, Y = 0, Top = 6, Right = 6, Bottom = 1, Left = 1, CorrectRotate = 270 },
					new Block { PosX = -65, PosY = -130, X = -2, Y = 0, Top = 0, Right = 2, Bottom = 2, Left = 6, CorrectRotate = 180 },
					new Block { PosX = -65, PosY = 0, X = -2, Y = 1, Top = 5, Right = 4, Bottom = 0, Left = 0, CorrectRotate = 180 },
					new Block { PosX = -65, PosY = -260, X = -2, Y = -1, Top = 1, Right = 0, Bottom = 6, Left = 7, CorrectRotate = 270 },
					new Block { PosX = -195, PosY = -130, X = -3, Y = 0, Top = 3, Right = 5, Bottom = 6, Left = 3, CorrectRotate = 0 },
					new Block { PosX = -65, PosY = 130, X = -2, Y = 2, Top = 2, Right = 2, Bottom = 7, Left = 1, CorrectRotate = 0 },
					new Block { PosX = 65, PosY = 130, X = -1, Y = 2, Top = 3, Right = 5, Bottom = 0, Left = 6, CorrectRotate = 180 },
					new Block { PosX = 65, PosY = 260, X = -1, Y = 3, Top = 2, Right = 1, Bottom = 7, Left = 2, CorrectRotate = 0 },
					new Block { PosX = 195, PosY = 130, X = 0, Y = 2, Top = 7, Right = 4, Bottom = 1, Left = 6, CorrectRotate = 270 },
					new Block { PosX = 65, PosY = 0, X = -1, Y = 1, Top = 1, Right = 6, Bottom = 7, Left = 4, CorrectRotate = 270 },
				}
			};
		}
	}
}