using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Moderate
{
	public abstract class Level138
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 138,
				MatchsToWin = 23,
				ThreeStarsLimit = 47,
				TwoStarsLimit = 56,
				BlockSizes = 115,
				Blocks = new List<Block>
				{
					new Block { PosX = 173, PosY = 58, X = 0, Y = 0, Top = 1, Right = 0, Bottom = 2, Left = 9, CorrectRotate = 180 },
					new Block { PosX = 173, PosY = -57, X = 0, Y = -1, Top = 4, Right = 9, Bottom = 2, Left = 6, CorrectRotate = 270 },
					new Block { PosX = 173, PosY = -172, X = 0, Y = -2, Top = 9, Right = 1, Bottom = -2, Left = -1, CorrectRotate = 180 },
					new Block { PosX = 58, PosY = -57, X = -1, Y = -1, Top = 5, Right = 6, Bottom = 5, Left = 7, CorrectRotate = 90 },
					new Block { PosX = -57, PosY = -57, X = -2, Y = -1, Top = 8, Right = 5, Bottom = 6, Left = 2, CorrectRotate = 180 },
					new Block { PosX = -57, PosY = 58, X = -2, Y = 0, Top = 1, Right = 5, Bottom = 8, Left = -1, CorrectRotate = 180 },
					new Block { PosX = -57, PosY = -172, X = -2, Y = -2, Top = 6, Right = -2, Bottom = 9, Left = -1, CorrectRotate = 270 },
					new Block { PosX = -172, PosY = -57, X = -3, Y = -1, Top = 5, Right = 5, Bottom = 5, Left = 2, CorrectRotate = 180 },
					new Block { PosX = -57, PosY = 173, X = -2, Y = 1, Top = 1, Right = 5, Bottom = 5, Left = -1, CorrectRotate = 90 },
					new Block { PosX = 58, PosY = 58, X = -1, Y = 0, Top = 8, Right = 8, Bottom = 7, Left = 1, CorrectRotate = 90 },
					new Block { PosX = -57, PosY = -287, X = -2, Y = -3, Top = 1, Right = 5, Bottom = 9, Left = -2, CorrectRotate = 180 },
					new Block { PosX = 288, PosY = -172, X = 1, Y = -2, Top = 7, Right = 0, Bottom = 8, Left = 3, CorrectRotate = 270 },
					new Block { PosX = 173, PosY = -287, X = 0, Y = -3, Top = 6, Right = 2, Bottom = -2, Left = 6, CorrectRotate = 180 },
					new Block { PosX = 58, PosY = -172, X = -1, Y = -2, Top = 1, Right = 0, Bottom = 6, Left = -1, CorrectRotate = 90 },
					new Block { PosX = -172, PosY = 58, X = -3, Y = 0, Top = 2, Right = 2, Bottom = 0, Left = 1, CorrectRotate = 270 },
					new Block { PosX = -172, PosY = -172, X = -3, Y = -2, Top = 6, Right = 2, Bottom = -2, Left = 8, CorrectRotate = 90 },
					new Block { PosX = -287, PosY = -57, X = -4, Y = -1, Top = 2, Right = 2, Bottom = 2, Left = 3, CorrectRotate = 270 },
					new Block { PosX = -57, PosY = 288, X = -2, Y = 2, Top = -2, Right = 2, Bottom = 0, Left = 7, CorrectRotate = 270 },
				}
			};
		}
	}
}