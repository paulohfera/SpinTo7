using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hard
{
	public abstract class Level215
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 215,
				MatchsToWin = 7,
				ThreeStarsLimit = 20,
				TwoStarsLimit = 24,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 130, PosY = -130, X = 0, Y = 0, Top = 7, Right = -2, Bottom = 6, Left = 6, CorrectRotate = 180 },
					new Block { PosX = 0, PosY = -130, X = -1, Y = 0, Top = 9, Right = -1, Bottom = -1, Left = 8, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = 0, X = -1, Y = 1, Top = 9, Right = -2, Bottom = 4, Left = -1, CorrectRotate = 90 },
					new Block { PosX = 0, PosY = -260, X = -1, Y = -1, Top = -2, Right = 8, Bottom = 7, Left = -2, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = -130, X = -2, Y = 0, Top = 8, Right = 4, Bottom = 2, Left = 9, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = 130, X = -1, Y = 2, Top = 9, Right = 8, Bottom = 4, Left = 2, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = 130, X = -2, Y = 2, Top = 4, Right = 2, Bottom = 1, Left = -1, CorrectRotate = 180 },
					new Block { PosX = -130, PosY = 260, X = -2, Y = 3, Top = 6, Right = -2, Bottom = 6, Left = -1, CorrectRotate = 180 },
				}
			};
		}
	}
}