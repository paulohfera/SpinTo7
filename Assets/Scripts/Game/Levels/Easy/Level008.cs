using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Easy
{
	public abstract class Level008
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 8,
				MatchsToWin = 7,
				ThreeStarsLimit = 13,
				TwoStarsLimit = 17,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = -130, PosY =  -65, X = 0, Y = 0, Top = 1, Right = 2, Bottom = 3, Left = 4, CorrectRotate = 270 },
					new Block { PosX =    0, PosY =  -65, X = 1, Y = 0, Top = 7, Right = 6, Bottom = 1, Left = 2, CorrectRotate = 180 },
					new Block { PosX =  130, PosY =  -65, X = 2, Y = 0, Top = 1, Right = 5, Bottom = 3, Left = 0, CorrectRotate = 180 },
					new Block { PosX = -130, PosY =   65, X = 0, Y = 1, Top = 4, Right = 1, Bottom = 2, Left = 3, CorrectRotate =  90 },
					new Block { PosX =    0, PosY =   65, X = 1, Y = 1, Top = 4, Right = 6, Bottom = 5, Left = 0, CorrectRotate = 270 },
					new Block { PosX =  130, PosY =   65, X = 2, Y = 1, Top = 2, Right = 7, Bottom = 4, Left = 3, CorrectRotate =   0 },
				}
			};
		}
	}
}