using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hard
{
	public abstract class Level214
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 214,
				MatchsToWin = 9,
				ThreeStarsLimit = 20,
				TwoStarsLimit = 24,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 0, PosY = 195, X = 0, Y = 0, Top = -2, Right = 7, Bottom = 9, Left = 2, CorrectRotate = 270 },
					new Block { PosX = 130, PosY = 195, X = 1, Y = 0, Top = 8, Right = 3, Bottom = 9, Left = 4, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = 65, X = 0, Y = -1, Top = 1, Right = 0, Bottom = 7, Left = 7, CorrectRotate = 90 },
					new Block { PosX = 130, PosY = 65, X = 1, Y = -1, Top = 0, Right = 2, Bottom = 0, Left = 4, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = -65, X = 0, Y = -2, Top = 6, Right = -1, Bottom = -2, Left = 0, CorrectRotate = 270 },
					new Block { PosX = -130, PosY = 65, X = -1, Y = -1, Top = 4, Right = 8, Bottom = 6, Left = -1, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = -65, X = -1, Y = -2, Top = 2, Right = 8, Bottom = 9, Left = -1, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = -195, X = -1, Y = -3, Top = 8, Right = 8, Bottom = 0, Left = 4, CorrectRotate = 90 },
				}
			};
		}
	}
}