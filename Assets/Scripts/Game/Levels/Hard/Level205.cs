using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hard
{
	public abstract class Level205
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 205,
				MatchsToWin = 6,
				ThreeStarsLimit = 15,
				TwoStarsLimit = 18,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 0, PosY = 0, X = 0, Y = 0, Top = 1, Right = 6, Bottom = 0, Left = 7, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = 130, X = 0, Y = 1, Top = 3, Right = 0, Bottom = 0, Left = 7, CorrectRotate = 90 },
					new Block { PosX = 130, PosY = 0, X = 1, Y = 0, Top = 0, Right = 9, Bottom = 3, Left = 6, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = 130, X = -1, Y = 1, Top = 4, Right = 7, Bottom = 5, Left = 7, CorrectRotate = 270 },
					new Block { PosX = 130, PosY = 130, X = 1, Y = 1, Top = -2, Right = 7, Bottom = -1, Left = 4, CorrectRotate = 180 },
					new Block { PosX = 130, PosY = -130, X = 1, Y = -1, Top = 2, Right = 3, Bottom = -1, Left = 1, CorrectRotate = 270 },
				}
			};
		}
	}
}