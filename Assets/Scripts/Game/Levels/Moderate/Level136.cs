using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Moderate
{
	public abstract class Level136
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 136,
				MatchsToWin = 22,
				ThreeStarsLimit = 45,
				TwoStarsLimit = 54,
				BlockSizes = 115,
				Blocks = new List<Block>
				{
					new Block { PosX = 288, PosY = -57, X = 0, Y = 0, Top = 4, Right = 8, Bottom = 9, Left = 1, CorrectRotate = 180 },
					new Block { PosX = 288, PosY = 58, X = 0, Y = 1, Top = 3, Right = -2, Bottom = 7, Left = 4, CorrectRotate = 270 },
					new Block { PosX = 173, PosY = 58, X = -1, Y = 1, Top = 0, Right = -1, Bottom = 0, Left = 8, CorrectRotate = 90 },
					new Block { PosX = 58, PosY = 58, X = -2, Y = 1, Top = 8, Right = 8, Bottom = 7, Left = 2, CorrectRotate = 90 },
					new Block { PosX = 58, PosY = 173, X = -2, Y = 2, Top = -1, Right = 5, Bottom = 7, Left = 6, CorrectRotate = 180 },
					new Block { PosX = 58, PosY = -57, X = -2, Y = 0, Top = 0, Right = 0, Bottom = 5, Left = 5, CorrectRotate = 270 },
					new Block { PosX = -57, PosY = 58, X = -3, Y = 1, Top = -1, Right = 9, Bottom = 7, Left = -1, CorrectRotate = 180 },
					new Block { PosX = -172, PosY = 58, X = -4, Y = 1, Top = -2, Right = 3, Bottom = 6, Left = -2, CorrectRotate = 270 },
					new Block { PosX = 58, PosY = -172, X = -2, Y = -1, Top = 8, Right = 7, Bottom = 6, Left = 7, CorrectRotate = 90 },
					new Block { PosX = -57, PosY = -57, X = -3, Y = 0, Top = 2, Right = 1, Bottom = 3, Left = 8, CorrectRotate = 270 },
					new Block { PosX = -57, PosY = 173, X = -3, Y = 2, Top = -2, Right = 2, Bottom = 2, Left = 0, CorrectRotate = 90 },
					new Block { PosX = -172, PosY = -57, X = -4, Y = 0, Top = 4, Right = 9, Bottom = 8, Left = 4, CorrectRotate = 270 },
					new Block { PosX = -287, PosY = 58, X = -5, Y = 1, Top = 4, Right = 7, Bottom = 1, Left = 7, CorrectRotate = 90 },
					new Block { PosX = 173, PosY = -172, X = -1, Y = -1, Top = 1, Right = 3, Bottom = 1, Left = 4, CorrectRotate = 270 },
					new Block { PosX = 58, PosY = -287, X = -2, Y = -2, Top = 7, Right = 5, Bottom = 0, Left = 3, CorrectRotate = 180 },
					new Block { PosX = -57, PosY = -172, X = -3, Y = -1, Top = 8, Right = 6, Bottom = -1, Left = 8, CorrectRotate = 90 },
					new Block { PosX = -57, PosY = 288, X = -3, Y = 3, Top = 6, Right = 5, Bottom = 8, Left = 2, CorrectRotate = 270 },
					new Block { PosX = -172, PosY = 173, X = -4, Y = 2, Top = 8, Right = 6, Bottom = 9, Left = 9, CorrectRotate = 90 },
				}
			};
		}
	}
}