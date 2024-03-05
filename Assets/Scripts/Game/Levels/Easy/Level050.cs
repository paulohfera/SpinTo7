using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Easy
{
	public abstract class Level050
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 50,
				MatchsToWin = 31,
				ThreeStarsLimit = 58,
				TwoStarsLimit = 69,
				BlockSizes = 100,
				Blocks = new List<Block>
				{
					new Block { PosX = 0, PosY = 200, X = 0, Y = 0, Top = 5, Right = 7, Bottom = 3, Left = 2, CorrectRotate = 180 },
					new Block { PosX = -100, PosY = 200, X = -1, Y = 0, Top = 7, Right = 2, Bottom = 0, Left = 7, CorrectRotate = 90 },
					new Block { PosX = -100, PosY = 100, X = -1, Y = -1, Top = 1, Right = 7, Bottom = 0, Left = 0, CorrectRotate = 180 },
					new Block { PosX = -100, PosY = 0, X = -1, Y = -2, Top = 3, Right = 6, Bottom = 3, Left = 7, CorrectRotate = 90 },
					new Block { PosX = -200, PosY = 100, X = -2, Y = -1, Top = 0, Right = 2, Bottom = 6, Left = 3, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = 0, X = 0, Y = -2, Top = 4, Right = 1, Bottom = 4, Left = 6, CorrectRotate = 270 },
					new Block { PosX = -100, PosY = -100, X = -1, Y = -3, Top = 1, Right = 0, Bottom = 0, Left = 4, CorrectRotate = 90 },
					new Block { PosX = -200, PosY = 0, X = -2, Y = -2, Top = 4, Right = 7, Bottom = 5, Left = 5, CorrectRotate = 270 },
					new Block { PosX = -200, PosY = 200, X = -2, Y = 0, Top = 4, Right = 7, Bottom = 1, Left = 0, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = 100, X = 0, Y = -1, Top = 7, Right = 1, Bottom = 7, Left = 2, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = -100, X = 0, Y = -3, Top = 1, Right = 7, Bottom = 6, Left = 5, CorrectRotate = 180 },
					new Block { PosX = -200, PosY = -100, X = -2, Y = -3, Top = 0, Right = 1, Bottom = 0, Left = 6, CorrectRotate = 180 },
					new Block { PosX = -300, PosY = 0, X = -3, Y = -2, Top = 2, Right = 1, Bottom = 1, Left = 0, CorrectRotate = 270 },
					new Block { PosX = -200, PosY = 300, X = -2, Y = 1, Top = 5, Right = 2, Bottom = 1, Left = 6, CorrectRotate = 90 },
					new Block { PosX = -300, PosY = 200, X = -3, Y = 0, Top = 7, Right = 4, Bottom = 3, Left = 0, CorrectRotate = 180 },
					new Block { PosX = 100, PosY = 100, X = 1, Y = -1, Top = 5, Right = 1, Bottom = 0, Left = 4, CorrectRotate = 270 },
					new Block { PosX = 100, PosY = 0, X = 1, Y = -2, Top = 3, Right = 6, Bottom = 7, Left = 1, CorrectRotate = 90 },
					new Block { PosX = 100, PosY = -100, X = 1, Y = -3, Top = 2, Right = 6, Bottom = 3, Left = 5, CorrectRotate = 90 },
					new Block { PosX = 100, PosY = -200, X = 1, Y = -4, Top = 6, Right = 2, Bottom = 6, Left = 2, CorrectRotate = 270 },
					new Block { PosX = 200, PosY = -200, X = 2, Y = -4, Top = 1, Right = 6, Bottom = 5, Left = 0, CorrectRotate = 90 },
					new Block { PosX = 100, PosY = -300, X = 1, Y = -5, Top = 4, Right = 5, Bottom = 7, Left = 6, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = -200, X = 0, Y = -4, Top = 4, Right = 2, Bottom = 6, Left = 1, CorrectRotate = 180 },
					new Block { PosX = 300, PosY = -200, X = 3, Y = -4, Top = 2, Right = 5, Bottom = 2, Left = 1, CorrectRotate = 90 },
				}
			};
		}
	}
}