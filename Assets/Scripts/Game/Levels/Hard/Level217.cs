using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hard
{
	public abstract class Level217
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 217,
				MatchsToWin = 10,
				ThreeStarsLimit = 22,
				TwoStarsLimit = 27,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = -65, PosY = -65, X = 0, Y = 0, Top = -1, Right = 3, Bottom = -2, Left = 0, CorrectRotate = 180 },
					new Block { PosX = -65, PosY = 65, X = 0, Y = 1, Top = 9, Right = -1, Bottom = 3, Left = -1, CorrectRotate = 180 },
					new Block { PosX = 65, PosY = -65, X = 1, Y = 0, Top = 7, Right = 7, Bottom = 7, Left = 0, CorrectRotate = 270 },
					new Block { PosX = -65, PosY = -195, X = 0, Y = -1, Top = -2, Right = 8, Bottom = -1, Left = 9, CorrectRotate = 90 },
					new Block { PosX = -195, PosY = -65, X = -1, Y = 0, Top = 2, Right = 7, Bottom = 4, Left = 2, CorrectRotate = 90 },
					new Block { PosX = -65, PosY = 195, X = 0, Y = 2, Top = 4, Right = -2, Bottom = 8, Left = 6, CorrectRotate = 180 },
					new Block { PosX = 65, PosY = 65, X = 1, Y = 1, Top = -2, Right = 7, Bottom = 8, Left = 9, CorrectRotate = 270 },
					new Block { PosX = -195, PosY = 65, X = -1, Y = 1, Top = 8, Right = 0, Bottom = 7, Left = 0, CorrectRotate = 270 },
					new Block { PosX = 195, PosY = -65, X = 2, Y = 0, Top = 0, Right = 8, Bottom = -1, Left = 9, CorrectRotate = 90 },
				}
			};
		}
	}
}