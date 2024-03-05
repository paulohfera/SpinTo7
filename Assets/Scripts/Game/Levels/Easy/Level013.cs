using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Easy
{
	public abstract class Level013
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 13,
				MatchsToWin = 14,
				ThreeStarsLimit = 26,
				TwoStarsLimit = 36,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = -195, PosY = -195, X = 0, Y = 0, Top = 2, Right = 3, Bottom = 4, Left = 1, CorrectRotate = 270 },
					new Block { PosX =  -65, PosY = -195, X = 1, Y = 0, Top = 3, Right = 6, Bottom = 4, Left = 5, CorrectRotate =   0 },

					new Block { PosX = -195, PosY =  -65, X = 0, Y = 1, Top = 6, Right = 0, Bottom = 7, Left = 2, CorrectRotate = 180 },
					new Block { PosX =  -65, PosY =  -65, X = 1, Y = 1, Top = 3, Right = 4, Bottom = 5, Left = 1, CorrectRotate = 270 },
					new Block { PosX =   65, PosY =  -65, X = 2, Y = 1, Top = 0, Right = 7, Bottom = 4, Left = 2, CorrectRotate = 270 },
					new Block { PosX =  195, PosY =  -65, X = 3, Y = 1, Top = 0, Right = 7, Bottom = 4, Left = 2, CorrectRotate = 180 },

					new Block { PosX = -195, PosY =   65, X = 0, Y = 2, Top = 4, Right = 0, Bottom = 5, Left = 1, CorrectRotate = 270 },
					new Block { PosX =  -65, PosY =   65, X = 1, Y = 2, Top = 6, Right = 3, Bottom = 2, Left = 4, CorrectRotate = 180 },
					new Block { PosX =   65, PosY =   65, X = 2, Y = 2, Top = 4, Right = 1, Bottom = 5, Left = 3, CorrectRotate =   0 },
					new Block { PosX =  195, PosY =   65, X = 3, Y = 2, Top = 2, Right = 3, Bottom = 6, Left = 3, CorrectRotate = 270 },

					new Block { PosX =  -65, PosY =  195, X = 1, Y = 3, Top = 1, Right = 5, Bottom = 3, Left = 7, CorrectRotate = 270 },
				}
			};
		}
	}
}