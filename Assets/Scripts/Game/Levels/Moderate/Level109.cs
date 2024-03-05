using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Moderate
{
	public abstract class Level109
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 109,
				MatchsToWin = 9,
				ThreeStarsLimit = 22,
				TwoStarsLimit = 26,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 65, PosY = -130, X = 0, Y = 0, Top = 2, Right = 0, Bottom = 2, Left = 3, CorrectRotate = 180 },
					new Block { PosX = 65, PosY = 0, X = 0, Y = 1, Top = 5, Right = -2, Bottom = 8, Left = 0, CorrectRotate = 180 },
					new Block { PosX = -65, PosY = 0, X = -1, Y = 1, Top = 9, Right = 3, Bottom = 6, Left = 4, CorrectRotate = 270 },
					new Block { PosX = -65, PosY = 130, X = -1, Y = 2, Top = 3, Right = 8, Bottom = 3, Left = 2, CorrectRotate = 180 },
					new Block { PosX = -65, PosY = -130, X = -1, Y = 0, Top = 7, Right = 1, Bottom = 4, Left = 4, CorrectRotate = 270 },
					new Block { PosX = -65, PosY = 260, X = -1, Y = 3, Top = 9, Right = 7, Bottom = 1, Left = 4, CorrectRotate = 90 },
					new Block { PosX = 65, PosY = 130, X = 0, Y = 2, Top = -1, Right = -1, Bottom = 5, Left = 7, CorrectRotate = 270 },
					new Block { PosX = -65, PosY = -260, X = -1, Y = -1, Top = 6, Right = 6, Bottom = 3, Left = 7, CorrectRotate = 90 },
				}
			};
		}
	}
}