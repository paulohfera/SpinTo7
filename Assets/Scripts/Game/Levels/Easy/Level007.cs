using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Easy
{
	public abstract class Level007
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 7,
				MatchsToWin = 6,
				ThreeStarsLimit = 17,
				TwoStarsLimit = 21,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = -130, PosY = -130, X = 0, Y = 0, Top = 3, Right = 1, Bottom = 7, Left = 6, CorrectRotate = 180 },
					new Block { PosX =  130, PosY = -130, X = 2, Y = 0, Top = 5, Right = 7, Bottom = 3, Left = 1, CorrectRotate = 180 },
					new Block { PosX = -130, PosY =    0, X = 0, Y = 1, Top = 0, Right = 5, Bottom = 2, Left = 4, CorrectRotate = 180 },
					new Block { PosX =    0, PosY =    0, X = 1, Y = 1, Top = 1, Right = 5, Bottom = 3, Left = 4, CorrectRotate = 270 },
					new Block { PosX =  130, PosY =    0, X = 2, Y = 1, Top = 4, Right = 6, Bottom = 2, Left = 7, CorrectRotate = 180 },
					new Block { PosX = -130, PosY =  130, X = 0, Y = 2, Top = 1, Right = 2, Bottom = 5, Left = 6, CorrectRotate =   0 },
					new Block { PosX =  130, PosY =  130, X = 2, Y = 2, Top = 0, Right = 7, Bottom = 6, Left = 5, CorrectRotate =  90 },
				}
			};
		}
	}
}