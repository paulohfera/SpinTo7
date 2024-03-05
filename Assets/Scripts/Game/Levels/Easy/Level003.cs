using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Easy
{
	public abstract class Level003
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 3,
				MatchsToWin = 4,
				ThreeStarsLimit = 4,
				TwoStarsLimit = 5,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX =    0, PosY = -130, X = 1, Y = 0, Top = 1, Right = 4, Bottom = 6, Left = 2, CorrectRotate = 0 },
					new Block { PosX = -130, PosY =    0, X = 0, Y = 1, Top = 5, Right = 0, Bottom = 2, Left = 1, CorrectRotate = 0 },
					new Block { PosX =    0, PosY =    0, X = 1, Y = 1, Top = 6, Right = 7, Bottom = 4, Left = 2, CorrectRotate = 180 },
					new Block { PosX =  130, PosY =    0, X = 2, Y = 1, Top = 5, Right = 4, Bottom = 0, Left = 3, CorrectRotate = 90 },
					new Block { PosX =    0, PosY =  130, X = 1, Y = 2, Top = 7, Right = 4, Bottom = 3, Left = 2, CorrectRotate = 0 },
				}
			};
		}
	}
}