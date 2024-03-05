using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hard
{
	public abstract class Level211
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 211,
				MatchsToWin = 8,
				ThreeStarsLimit = 21,
				TwoStarsLimit = 25,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = -130, PosY = 0, X = 0, Y = 0, Top = 7, Right = -2, Bottom = 7, Left = 4, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = 0, X = 1, Y = 0, Top = 6, Right = 0, Bottom = 5, Left = 6, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = -130, X = 0, Y = -1, Top = 9, Right = 2, Bottom = 9, Left = 3, CorrectRotate = 180 },
					new Block { PosX = -260, PosY = 0, X = -1, Y = 0, Top = 8, Right = 9, Bottom = 0, Left = -2, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = 130, X = 1, Y = 1, Top = 8, Right = 2, Bottom = 4, Left = 0, CorrectRotate = 270 },
					new Block { PosX = 130, PosY = 0, X = 2, Y = 0, Top = 9, Right = 1, Bottom = 0, Left = 0, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = -130, X = 1, Y = -1, Top = -2, Right = 4, Bottom = 1, Left = 7, CorrectRotate = 180 },
					new Block { PosX = 260, PosY = 0, X = 3, Y = 0, Top = 1, Right = 7, Bottom = 7, Left = 5, CorrectRotate = 180 },
				}
			};
		}
	}
}