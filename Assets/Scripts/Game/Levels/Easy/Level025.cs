using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Easy
{
	public abstract class Level025
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 25,
				MatchsToWin = 18,
				ThreeStarsLimit = 38,
				TwoStarsLimit = 45,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = -65, PosY = -195, X = 0, Y = 0, Top = 7, Right = 0, Bottom = 4, Left = 0, CorrectRotate = 180 },
					new Block { PosX = -195, PosY = -195, X = -1, Y = 0, Top = 2, Right = 7, Bottom = 5, Left = 1, CorrectRotate = 0 },
					new Block { PosX = -195, PosY = -65, X = -1, Y = 1, Top = 7, Right = 5, Bottom = 6, Left = 4, CorrectRotate = 270 },
					new Block { PosX = -65, PosY = -65, X = 0, Y = 1, Top = 5, Right = 3, Bottom = 0, Left = 1, CorrectRotate = 270 },
					new Block { PosX = -65, PosY = 65, X = 0, Y = 2, Top = 4, Right = 0, Bottom = 6, Left = 5, CorrectRotate = 0 },
					new Block { PosX = 65, PosY = -65, X = 1, Y = 1, Top = 3, Right = 6, Bottom = 2, Left = 5, CorrectRotate = 270 },
					new Block { PosX = -65, PosY = 195, X = 0, Y = 3, Top = 3, Right = 3, Bottom = 2, Left = 1, CorrectRotate = 270 },
					new Block { PosX = 65, PosY = 65, X = 1, Y = 2, Top = 2, Right = 7, Bottom = 3, Left = 4, CorrectRotate = 180 },
					new Block { PosX = -195, PosY = 65, X = -1, Y = 2, Top = 2, Right = 3, Bottom = 0, Left = 4, CorrectRotate = 270 },
					new Block { PosX = 65, PosY = -195, X = 1, Y = 0, Top = 6, Right = 6, Bottom = 7, Left = 1, CorrectRotate = 270 },
					new Block { PosX = 65, PosY = 195, X = 1, Y = 3, Top = 4, Right = 4, Bottom = 2, Left = 1, CorrectRotate = 180 },
					new Block { PosX = -195, PosY = 195, X = -1, Y = 3, Top = 3, Right = 4, Bottom = 3, Left = 5, CorrectRotate = 180 },
					new Block { PosX = 195, PosY = 65, X = 2, Y = 2, Top = 0, Right = 2, Bottom = 3, Left = 7, CorrectRotate = 270 },
				}
			};
		}
	}
}