using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hard
{
	public abstract class Level202
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 202,
				MatchsToWin = 5,
				ThreeStarsLimit = 15,
				TwoStarsLimit = 18,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 0, PosY = 65, X = 0, Y = 0, Top = 6, Right = 7, Bottom = 0, Left = -1, CorrectRotate = 180 },
					new Block { PosX = 130, PosY = 65, X = 1, Y = 0, Top = 0, Right = 7, Bottom = 8, Left = 8, CorrectRotate = 270 },
					new Block { PosX = 0, PosY = -65, X = 0, Y = -1, Top = 0, Right = 1, Bottom = 3, Left = 4, CorrectRotate = 90 },
					new Block { PosX = -130, PosY = 65, X = -1, Y = 0, Top = 0, Right = 3, Bottom = 9, Left = 1, CorrectRotate = 270 },
					new Block { PosX = -130, PosY = -65, X = -1, Y = -1, Top = 7, Right = 5, Bottom = 7, Left = 4, CorrectRotate = 270 },
				}
			};
		}
	}
}