using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hard
{
	public abstract class Level203
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 203,
				MatchsToWin = 4,
				ThreeStarsLimit = 9,
				TwoStarsLimit = 11,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 130, PosY = 0, X = 0, Y = 0, Top = 9, Right = 8, Bottom = 6, Left = 4, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = 0, X = -1, Y = 0, Top = 8, Right = 8, Bottom = 6, Left = -1, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = 130, X = -1, Y = 1, Top = 3, Right = 7, Bottom = 7, Left = 1, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = -130, X = -1, Y = -1, Top = -2, Right = -1, Bottom = 1, Left = 5, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = 0, X = -2, Y = 0, Top = 5, Right = 1, Bottom = -1, Left = -2, CorrectRotate = 90 },
				}
			};
		}
	}
}