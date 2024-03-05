using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hard
{
	public abstract class Level255
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 255,
				MatchsToWin = 21,
				ThreeStarsLimit = 42,
				TwoStarsLimit = 51,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 0, PosY = 130, X = 0, Y = 0, Top = 3, Right = 9, Bottom = 0, Left = 1, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = 0, X = 0, Y = -1, Top = -2, Right = -2, Bottom = -2, Left = 1, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = 130, X = -1, Y = 0, Top = -1, Right = 4, Bottom = 7, Left = -1, CorrectRotate = 90 },
					new Block { PosX = 130, PosY = 0, X = 1, Y = -1, Top = 4, Right = 8, Bottom = 9, Left = 0, CorrectRotate = 270 },
					new Block { PosX = 130, PosY = -130, X = 1, Y = -2, Top = 5, Right = 2, Bottom = 8, Left = -1, CorrectRotate = 270 },
					new Block { PosX = 130, PosY = 130, X = 1, Y = 0, Top = 7, Right = 4, Bottom = 0, Left = -2, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = -130, X = 0, Y = -2, Top = -2, Right = 2, Bottom = 6, Left = -1, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = 0, X = -1, Y = -1, Top = 9, Right = 8, Bottom = 9, Left = -1, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = 260, X = -1, Y = 1, Top = 2, Right = 3, Bottom = 2, Left = 0, CorrectRotate = 270 },
					new Block { PosX = -260, PosY = 130, X = -2, Y = 0, Top = 3, Right = 2, Bottom = 7, Left = 8, CorrectRotate = 180 },
					new Block { PosX = 260, PosY = 0, X = 2, Y = -1, Top = 2, Right = 6, Bottom = 3, Left = 2, CorrectRotate = 270 },
					new Block { PosX = 260, PosY = -130, X = 2, Y = -2, Top = 2, Right = 1, Bottom = 2, Left = 0, CorrectRotate = 90 },
					new Block { PosX = 130, PosY = -260, X = 1, Y = -3, Top = 0, Right = 9, Bottom = 0, Left = 5, CorrectRotate = 270 },
					new Block { PosX = 130, PosY = 260, X = 1, Y = 1, Top = 2, Right = 7, Bottom = 6, Left = 5, CorrectRotate = 270 },
					new Block { PosX = 260, PosY = 130, X = 2, Y = 0, Top = 6, Right = 5, Bottom = 9, Left = 0, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = -260, X = 0, Y = -3, Top = 3, Right = 9, Bottom = 7, Left = -2, CorrectRotate = 90 },
				}
			};
		}
	}
}