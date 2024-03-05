using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hard
{
	public abstract class Level201
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 201,
				MatchsToWin = 4,
				ThreeStarsLimit = 13,
				TwoStarsLimit = 15,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 0, PosY = 130, X = 0, Y = 0, Top = -2, Right = 0, Bottom = 7, Left = -1, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = 0, X = 0, Y = -1, Top = 8, Right = 9, Bottom = 2, Left = 3, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = 130, X = -1, Y = 0, Top = 1, Right = 1, Bottom = -2, Left = 7, CorrectRotate = 180 },
					new Block { PosX = 130, PosY = 0, X = 1, Y = -1, Top = 1, Right = 5, Bottom = 5, Left = 4, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = -130, X = 0, Y = -2, Top = 8, Right = 1, Bottom = 3, Left = 4, CorrectRotate = 270 },
				}
			};
		}
	}
}