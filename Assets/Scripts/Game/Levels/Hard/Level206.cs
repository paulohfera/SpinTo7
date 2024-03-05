using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hard
{
	public abstract class Level206
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 206,
				MatchsToWin = 7,
				ThreeStarsLimit = 14,
				TwoStarsLimit = 16,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 195, PosY = 0, X = 0, Y = 0, Top = 9, Right = 1, Bottom = -2, Left = 8, CorrectRotate = 180 },
					new Block { PosX = 65, PosY = 0, X = -1, Y = 0, Top = 5, Right = 3, Bottom = 5, Left = 6, CorrectRotate = 180 },
					new Block { PosX = 65, PosY = 130, X = -1, Y = 1, Top = 7, Right = 9, Bottom = 7, Left = 2, CorrectRotate = 90 },
					new Block { PosX = 65, PosY = -130, X = -1, Y = -1, Top = 7, Right = 2, Bottom = -1, Left = -2, CorrectRotate = 90 },
					new Block { PosX = -65, PosY = -130, X = -2, Y = -1, Top = 8, Right = 4, Bottom = 7, Left = 0, CorrectRotate = 180 },
					new Block { PosX = -65, PosY = 0, X = -2, Y = 0, Top = 0, Right = 4, Bottom = 2, Left = 4, CorrectRotate = 180 },
					new Block { PosX = -195, PosY = -130, X = -3, Y = -1, Top = -1, Right = 1, Bottom = 3, Left = 1, CorrectRotate = 90 },
				}
			};
		}
	}
}