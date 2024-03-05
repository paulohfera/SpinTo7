using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hard
{
	public abstract class Level238
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 238,
				MatchsToWin = 17,
				ThreeStarsLimit = 30,
				TwoStarsLimit = 37,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 130, PosY = -65, X = 0, Y = 0, Top = 5, Right = 3, Bottom = 9, Left = 2, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = -65, X = -1, Y = 0, Top = 0, Right = 9, Bottom = 2, Left = 5, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = 65, X = -1, Y = 1, Top = -2, Right = 7, Bottom = -2, Left = 9, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = -195, X = -1, Y = -1, Top = -2, Right = 9, Bottom = 4, Left = 2, CorrectRotate = 270 },
					new Block { PosX = -130, PosY = -65, X = -2, Y = 0, Top = 7, Right = 5, Bottom = 7, Left = 5, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = 195, X = -1, Y = 2, Top = 0, Right = 4, Bottom = 8, Left = 9, CorrectRotate = 90 },
					new Block { PosX = 130, PosY = 65, X = 0, Y = 1, Top = 4, Right = -2, Bottom = 9, Left = 4, CorrectRotate = 180 },
					new Block { PosX = 130, PosY = -195, X = 0, Y = -1, Top = 0, Right = 3, Bottom = 9, Left = 5, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = -325, X = -1, Y = -2, Top = 8, Right = 7, Bottom = -2, Left = 8, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = -195, X = -2, Y = -1, Top = 3, Right = 2, Bottom = 3, Left = 6, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = 65, X = -2, Y = 1, Top = 0, Right = 2, Bottom = 2, Left = 6, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = 325, X = -1, Y = 3, Top = 0, Right = 3, Bottom = -1, Left = -2, CorrectRotate = 270 },
					new Block { PosX = 130, PosY = 195, X = 0, Y = 2, Top = -2, Right = -1, Bottom = 7, Left = 6, CorrectRotate = 180 },
				}
			};
		}
	}
}