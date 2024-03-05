using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Easy
{
	public abstract class Level006
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 6,
				MatchsToWin = 6,
				ThreeStarsLimit = 10,
				TwoStarsLimit = 14,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX =    0, PosY = -130, X = 1, Y = 0, Top = 0, Right = 5, Bottom = 1, Left = 6, CorrectRotate =  90 },
					new Block { PosX = -130, PosY =    0, X = 0, Y = 1, Top = 3, Right = 2, Bottom = 5, Left = 6, CorrectRotate = 180 },
					new Block { PosX =    0, PosY =    0, X = 1, Y = 1, Top = 2, Right = 1, Bottom = 4, Left = 7, CorrectRotate = 180 },
					new Block { PosX =  130, PosY =    0, X = 2, Y = 1, Top = 3, Right = 2, Bottom = 1, Left = 0, CorrectRotate =   0 },
					new Block { PosX =    0, PosY =  130, X = 1, Y = 2, Top = 4, Right = 1, Bottom = 2, Left = 3, CorrectRotate =  90 },
					new Block { PosX =  130, PosY =  130, X = 2, Y = 2, Top = 4, Right = 5, Bottom = 6, Left = 0, CorrectRotate = 180 },
				}
			};
		}
	}
}