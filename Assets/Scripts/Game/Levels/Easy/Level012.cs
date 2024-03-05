using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Easy
{
	public abstract class Level012
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 12,
				MatchsToWin = 11,
				ThreeStarsLimit = 25,
				TwoStarsLimit = 35,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = -195, PosY = -195, X = 0, Y = 0, Top = 4, Right = 1, Bottom = 5, Left = 0, CorrectRotate =  90 },
					new Block { PosX =  -65, PosY = -195, X = 1, Y = 0, Top = 3, Right = 2, Bottom = 1, Left = 5, CorrectRotate = 180 },
					new Block { PosX =   65, PosY = -195, X = 2, Y = 0, Top = 2, Right = 3, Bottom = 1, Left = 4, CorrectRotate =  90 },
					new Block { PosX =  195, PosY = -195, X = 3, Y = 0, Top = 5, Right = 7, Bottom = 6, Left = 2, CorrectRotate = 270 },

					new Block { PosX = -195, PosY =  -65, X = 0, Y = 1, Top = 1, Right = 3, Bottom = 5, Left = 6, CorrectRotate =  90 },
					new Block { PosX =  195, PosY =  -65, X = 3, Y = 1, Top = 5, Right = 5, Bottom = 0, Left = 4, CorrectRotate = 180 },

					new Block { PosX = -195, PosY =   65, X = 0, Y = 2, Top = 4, Right = 0, Bottom = 2, Left = 6, CorrectRotate = 180 },
					new Block { PosX =   65, PosY =   65, X = 2, Y = 2, Top = 0, Right = 4, Bottom = 2, Left = 6, CorrectRotate = 270 },
					new Block { PosX =  195, PosY =   65, X = 3, Y = 2, Top = 1, Right = 2, Bottom = 5, Left = 7, CorrectRotate =  90 },

					new Block { PosX = -195, PosY =  195, X = 0, Y = 3, Top = 2, Right = 7, Bottom = 6, Left = 5, CorrectRotate =  90 },
					new Block { PosX =  -65, PosY =  195, X = 1, Y = 3, Top = 3, Right = 1, Bottom = 4, Left = 2, CorrectRotate = 180 },
					new Block { PosX =  195, PosY =  195, X = 3, Y = 3, Top = 5, Right = 6, Bottom = 3, Left = 4, CorrectRotate = 180 },
				}
			};
		}
	}
}