using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hard
{
	public abstract class Level209
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 209,
				MatchsToWin = 7,
				ThreeStarsLimit = 20,
				TwoStarsLimit = 24,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 130, PosY = -65, X = 0, Y = 0, Top = -2, Right = 9, Bottom = 8, Left = 1, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = -65, X = -1, Y = 0, Top = 4, Right = 3, Bottom = 4, Left = -1, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = 65, X = -1, Y = 1, Top = 3, Right = 5, Bottom = 3, Left = 0, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = -195, X = -1, Y = -1, Top = 3, Right = 9, Bottom = 3, Left = 2, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = -65, X = -2, Y = 0, Top = -2, Right = -2, Bottom = 5, Left = 4, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = 195, X = -1, Y = 2, Top = 4, Right = 7, Bottom = 2, Left = 4, CorrectRotate = 180 },
					new Block { PosX = 130, PosY = 65, X = 0, Y = 1, Top = 5, Right = 6, Bottom = 7, Left = 0, CorrectRotate = 270 },
				}
			};
		}
	}
}