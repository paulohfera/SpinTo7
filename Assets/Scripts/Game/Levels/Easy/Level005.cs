using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Easy
{
	public abstract class Level005
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 5,
				MatchsToWin = 4,
				ThreeStarsLimit = 10,
				TwoStarsLimit = 15,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX =  -65, PosY =  -65, X = 0, Y = 0, Top = 2, Right = 0, Bottom = 3, Left = 5, CorrectRotate = 180 },
					new Block { PosX =   65, PosY =  -65, X = 1, Y = 0, Top = 2, Right = 1, Bottom = 3, Left = 0, CorrectRotate =  90 },
					new Block { PosX =  -65, PosY =   65, X = 0, Y = 1, Top = 4, Right = 2, Bottom = 6, Left = 4, CorrectRotate = 180 },
					new Block { PosX =   65, PosY =   65, X = 1, Y = 1, Top = 1, Right = 6, Bottom = 3, Left = 4, CorrectRotate = 270 },
				}
			};
		}
	}
}