using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Easy
{
	public abstract class Level009
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 9,
				MatchsToWin = 7,
				ThreeStarsLimit = 17,
				TwoStarsLimit = 22,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX =    0, PosY = -195, X = 1, Y = 0, Top = 3, Right = 1, Bottom = 7, Left = 6, CorrectRotate = 180 },
					new Block { PosX =    0, PosY =  -65, X = 1, Y = 1, Top = 4, Right = 0, Bottom = 5, Left = 2, CorrectRotate = 270 },
					new Block { PosX =  130, PosY =  -65, X = 2, Y = 1, Top = 5, Right = 7, Bottom = 3, Left = 1, CorrectRotate = 270 },
					new Block { PosX = -130, PosY =   65, X = 0, Y = 2, Top = 5, Right = 3, Bottom = 4, Left = 1, CorrectRotate = 180 },
					new Block { PosX =    0, PosY =   65, X = 1, Y = 2, Top = 1, Right = 2, Bottom = 5, Left = 6, CorrectRotate =   0 },
					new Block { PosX =  130, PosY =   65, X = 2, Y = 2, Top = 5, Right = 2, Bottom = 7, Left = 6, CorrectRotate =  90 },
					new Block { PosX =  130, PosY =  195, X = 2, Y = 3, Top = 0, Right = 7, Bottom = 6, Left = 5, CorrectRotate =  90 },
				}
			};
		}
	}
}