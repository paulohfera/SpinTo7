using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hard
{
	public abstract class Level233
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 233,
				MatchsToWin = 15,
				ThreeStarsLimit = 24,
				TwoStarsLimit = 29,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = -260, PosY = -65, X = 0, Y = 0, Top = -1, Right = -2, Bottom = 4, Left = -1, CorrectRotate = 90 },
					new Block { PosX = -260, PosY = 65, X = 0, Y = 1, Top = -2, Right = -1, Bottom = 3, Left = 9, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = 65, X = 1, Y = 1, Top = 8, Right = 4, Bottom = 4, Left = 3, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = 65, X = 2, Y = 1, Top = -1, Right = 3, Bottom = 3, Left = 8, CorrectRotate = 90 },
					new Block { PosX = 130, PosY = 65, X = 3, Y = 1, Top = 4, Right = 8, Bottom = 5, Left = 4, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = -65, X = 2, Y = 0, Top = 5, Right = 6, Bottom = -2, Left = -1, CorrectRotate = 270 },
					new Block { PosX = 130, PosY = 195, X = 3, Y = 2, Top = -1, Right = 6, Bottom = 1, Left = -1, CorrectRotate = 180 },
					new Block { PosX = 260, PosY = 65, X = 4, Y = 1, Top = 0, Right = 2, Bottom = 3, Left = 0, CorrectRotate = 180 },
					new Block { PosX = 130, PosY = -65, X = 3, Y = 0, Top = -2, Right = 2, Bottom = 3, Left = 0, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = -195, X = 2, Y = -1, Top = 6, Right = 1, Bottom = 2, Left = 3, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = -65, X = 1, Y = 0, Top = -2, Right = 3, Bottom = 3, Left = 9, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = 195, X = 2, Y = 2, Top = -2, Right = 1, Bottom = 1, Left = 4, CorrectRotate = 90 },
				}
			};
		}
	}
}