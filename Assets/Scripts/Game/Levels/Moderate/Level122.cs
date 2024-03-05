using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Moderate
{
	public abstract class Level122
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 122,
				MatchsToWin = 14,
				ThreeStarsLimit = 30,
				TwoStarsLimit = 36,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 260, PosY = 130, X = 0, Y = 0, Top = 9, Right = 3, Bottom = 2, Left = 4, CorrectRotate = 270 },
					new Block { PosX = 130, PosY = 130, X = -1, Y = 0, Top = 7, Right = 7, Bottom = 5, Left = 3, CorrectRotate = 90 },
					new Block { PosX = 130, PosY = 0, X = -1, Y = -1, Top = 5, Right = 9, Bottom = 4, Left = -1, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = 130, X = -2, Y = 0, Top = -1, Right = -1, Bottom = 0, Left = -1, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = 130, X = -3, Y = 0, Top = 8, Right = 5, Bottom = -1, Left = -1, CorrectRotate = 270 },
					new Block { PosX = -130, PosY = 260, X = -3, Y = 1, Top = 8, Right = 6, Bottom = 6, Left = 7, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = 0, X = -3, Y = -1, Top = 7, Right = 8, Bottom = 7, Left = 2, CorrectRotate = 270 },
					new Block { PosX = -130, PosY = -130, X = -3, Y = -2, Top = 6, Right = 0, Bottom = -1, Left = 9, CorrectRotate = 180 },
					new Block { PosX = -260, PosY = 0, X = -4, Y = -1, Top = 7, Right = -1, Bottom = 7, Left = 0, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = -130, X = -2, Y = -2, Top = -2, Right = 5, Bottom = 9, Left = -2, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = -260, X = -3, Y = -3, Top = 2, Right = 1, Bottom = 2, Left = 6, CorrectRotate = 90 },
					new Block { PosX = -260, PosY = -130, X = -4, Y = -2, Top = 2, Right = 0, Bottom = 7, Left = 7, CorrectRotate = 90 },
					new Block { PosX = -260, PosY = 130, X = -4, Y = 0, Top = 0, Right = 7, Bottom = -2, Left = 8, CorrectRotate = 180 },
				}
			};
		}
	}
}