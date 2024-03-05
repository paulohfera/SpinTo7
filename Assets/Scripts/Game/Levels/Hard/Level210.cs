using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hard
{
	public abstract class Level210
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 210,
				MatchsToWin = 7,
				ThreeStarsLimit = 15,
				TwoStarsLimit = 18,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 130, PosY = -65, X = 0, Y = 0, Top = 8, Right = 5, Bottom = -1, Left = 3, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = -65, X = -1, Y = 0, Top = 6, Right = 0, Bottom = 3, Left = 8, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = 65, X = -1, Y = 1, Top = 7, Right = 9, Bottom = 6, Left = 4, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = -195, X = -1, Y = -1, Top = 6, Right = 1, Bottom = 0, Left = -2, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = -65, X = -2, Y = 0, Top = 6, Right = 7, Bottom = 7, Left = 7, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = 195, X = -1, Y = 2, Top = -2, Right = 8, Bottom = 9, Left = 5, CorrectRotate = 180 },
					new Block { PosX = 130, PosY = 65, X = 0, Y = 1, Top = 1, Right = 2, Bottom = 6, Left = 4, CorrectRotate = 90 },
				}
			};
		}
	}
}