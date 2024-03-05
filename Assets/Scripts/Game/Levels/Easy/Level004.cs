using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Easy
{
	public abstract class Level004
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 4,
				MatchsToWin = 4,
				ThreeStarsLimit = 10,
				TwoStarsLimit = 15,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = -130, PosY =  -65, X = 0, Y = 0, Top = 7, Right = 3, Bottom = 1, Left = 0, CorrectRotate = 180 },
					new Block { PosX =    0, PosY =  -65, X = 1, Y = 0, Top = 7, Right = 2, Bottom = 1, Left = 3, CorrectRotate =  90 },
					new Block { PosX =  130, PosY =  -65, X = 2, Y = 0, Top = 6, Right = 3, Bottom = 6, Left = 5, CorrectRotate = 270 },
					new Block { PosX = -130, PosY =   65, X = 0, Y = 1, Top = 3, Right = 2, Bottom = 6, Left = 1, CorrectRotate =   0 },
					new Block { PosX =  130, PosY =   65, X = 2, Y = 1, Top = 2, Right = 5, Bottom = 0, Left = 6, CorrectRotate = 180 },
				}
			};
		}
	}
}