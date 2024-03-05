using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Easy
{
	public abstract class Level011
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 11,
				MatchsToWin = 8,
				ThreeStarsLimit = 18,
				TwoStarsLimit = 22,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = -130, PosY = -130, X = 0, Y = 0, Top = 6, Right = 1, Bottom = 5, Left = 2, CorrectRotate = 270 },
					new Block { PosX =    0, PosY = -130, X = 1, Y = 0, Top = 4, Right = 1, Bottom = 5, Left = 3, CorrectRotate = 180 },
					new Block { PosX =  130, PosY = -130, X = 2, Y = 0, Top = 3, Right = 1, Bottom = 4, Left = 2, CorrectRotate = 270 },

					new Block { PosX = -130, PosY =    0, X = 0, Y = 1, Top = 5, Right = 6, Bottom = 1, Left = 2, CorrectRotate = 180 },
					new Block { PosX =  130, PosY =    0, X = 2, Y = 1, Top = 5, Right = 1, Bottom = 3, Left = 4, CorrectRotate = 180 },

					new Block { PosX = -130, PosY =  130, X = 0, Y = 2, Top = 6, Right = 5, Bottom = 6, Left = 3, CorrectRotate = 180 },
					new Block { PosX =    0, PosY =  130, X = 1, Y = 2, Top = 4, Right = 2, Bottom = 0, Left = 4, CorrectRotate =   0 },
					new Block { PosX =  130, PosY =  130, X = 2, Y = 2, Top = 5, Right = 7, Bottom = 6, Left = 4, CorrectRotate =  90 },
				}
			};
		}
	}
}