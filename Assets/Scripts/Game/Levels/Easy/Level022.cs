using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Easy
{
	public abstract class Level022
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 22,
				MatchsToWin = 15,
				ThreeStarsLimit = 32,
				TwoStarsLimit = 38,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = -195, PosY = 195, X = 0, Y = 0, Top = 3, Right = 7, Bottom = 3, Left = 2, CorrectRotate = 0 },
					new Block { PosX = -195, PosY = 325, X = 0, Y = 1, Top = 4, Right = 1, Bottom = 3, Left = 5, CorrectRotate = 180 },
					new Block { PosX = -65, PosY = 195, X = 1, Y = 0, Top = 0, Right = 3, Bottom = 0, Left = 1, CorrectRotate = 270 },
					new Block { PosX = -65, PosY = 65, X = 1, Y = -1, Top = 3, Right = 2, Bottom = 4, Left = 3, CorrectRotate = 180 },
					new Block { PosX = 65, PosY = 65, X = 2, Y = -1, Top = 7, Right = 4, Bottom = 4, Left = 6, CorrectRotate = 180 },
					new Block { PosX = -65, PosY = -65, X = 1, Y = -2, Top = 4, Right = 3, Bottom = 0, Left = 1, CorrectRotate = 0 },
					new Block { PosX = -65, PosY = -195, X = 1, Y = -3, Top = 1, Right = 5, Bottom = 7, Left = 6, CorrectRotate = 180 },
					new Block { PosX = -195, PosY = -65, X = 0, Y = -2, Top = 6, Right = 1, Bottom = 3, Left = 6, CorrectRotate = 270 },
					new Block { PosX = 65, PosY = -195, X = 2, Y = -3, Top = 2, Right = 2, Bottom = 0, Left = 1, CorrectRotate = 0 },
					new Block { PosX = -65, PosY = -325, X = 1, Y = -4, Top = 0, Right = 2, Bottom = 6, Left = 1, CorrectRotate = 180 },
					new Block { PosX = -195, PosY = -195, X = 0, Y = -3, Top = 2, Right = 4, Bottom = 6, Left = 2, CorrectRotate = 180 },
					new Block { PosX = -195, PosY = 65, X = 0, Y = -1, Top = 5, Right = 1, Bottom = 7, Left = 4, CorrectRotate = 270 },
					new Block { PosX = 195, PosY = -195, X = 3, Y = -3, Top = 0, Right = 6, Bottom = 5, Left = 5, CorrectRotate = 270 },
				}
			};
		}
	}
}