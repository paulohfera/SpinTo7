using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Moderate
{
	public abstract class Level102
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 102,
				MatchsToWin = 4,
				ThreeStarsLimit = 15,
				TwoStarsLimit = 18,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 0, PosY = 130, X = 0, Y = 0, Top = 6, Right = 2, Bottom = 5, Left = 8, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = 0, X = 0, Y = -1, Top = 4, Right = 6, Bottom = 2, Left = -1, CorrectRotate = 270 },
					new Block { PosX = -130, PosY = 130, X = -1, Y = 0, Top = 1, Right = -2, Bottom = -2, Left = 1, CorrectRotate = 270 },
					new Block { PosX = 130, PosY = 0, X = 1, Y = -1, Top = 0, Right = 3, Bottom = 8, Left = -2, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = -130, X = 0, Y = -2, Top = 0, Right = 6, Bottom = 4, Left = 1, CorrectRotate = 270 },
				}
			};
		}
	}
}