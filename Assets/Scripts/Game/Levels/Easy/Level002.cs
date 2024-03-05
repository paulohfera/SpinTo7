using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Easy
{
	public abstract class Level002
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 2,
				MatchsToWin = 2,
				ThreeStarsLimit = 4,
				TwoStarsLimit = 5,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = -130, PosY = 0, X = 0, Y = 0, Top = 5, Right = 2, Bottom = 7, Left = 1, CorrectRotate = 0 },
					new Block { PosX =    0, PosY = 0, X = 1, Y = 0, Top = 1, Right = 5, Bottom = 2, Left = 4, CorrectRotate = 180 },
					new Block { PosX =  130, PosY = 0, X = 2, Y = 0, Top = 2, Right = 4, Bottom = 6, Left = 3, CorrectRotate = 0 }
				}
			};
		}
	}
}