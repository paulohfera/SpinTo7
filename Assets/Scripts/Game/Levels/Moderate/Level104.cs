using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Moderate
{
	public abstract class Level104
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 104,
				MatchsToWin = 6,
				ThreeStarsLimit = 18,
				TwoStarsLimit = 21,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 0, PosY = -130, X = 0, Y = 0, Top = -1, Right = 5, Bottom = -2, Left = 2, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = 0, X = 0, Y = 1, Top = 5, Right = -1, Bottom = 5, Left = 9, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = 130, X = 0, Y = 2, Top = 2, Right = 3, Bottom = -2, Left = -1, CorrectRotate = 180 },
					new Block { PosX = 130, PosY = 0, X = 1, Y = 1, Top = 5, Right = 4, Bottom = -2, Left = 0, CorrectRotate = 270 },
					new Block { PosX = -130, PosY = 0, X = -1, Y = 1, Top = 5, Right = 5, Bottom = -2, Left = 8, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = -130, X = -1, Y = 0, Top = 8, Right = 3, Bottom = 2, Left = 9, CorrectRotate = 180 },
				}
			};
		}
	}
}