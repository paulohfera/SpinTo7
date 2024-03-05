using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hard
{
	public abstract class Level208
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 208,
				MatchsToWin = 8,
				ThreeStarsLimit = 21,
				TwoStarsLimit = 25,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = -130, PosY = 0, X = 0, Y = 0, Top = 3, Right = 6, Bottom = 2, Left = 8, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = 0, X = 1, Y = 0, Top = 4, Right = 3, Bottom = 5, Left = 2, CorrectRotate = 270 },
					new Block { PosX = 130, PosY = 0, X = 2, Y = 0, Top = 3, Right = 7, Bottom = 1, Left = 7, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = -130, X = 1, Y = -1, Top = 0, Right = 1, Bottom = 8, Left = 4, CorrectRotate = 270 },
					new Block { PosX = 130, PosY = 130, X = 2, Y = 1, Top = 4, Right = 0, Bottom = 2, Left = 4, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = 130, X = 1, Y = 1, Top = 5, Right = 5, Bottom = 3, Left = 3, CorrectRotate = 270 },
					new Block { PosX = -130, PosY = 130, X = 0, Y = 1, Top = 4, Right = 1, Bottom = -1, Left = 0, CorrectRotate = 270 },
				}
			};
		}
	}
}