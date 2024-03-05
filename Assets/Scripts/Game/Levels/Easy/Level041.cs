using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Easy
{
	public abstract class Level041
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 41,
				MatchsToWin = 28,
				ThreeStarsLimit = 54,
				TwoStarsLimit = 64,
				BlockSizes = 115,
				Blocks = new List<Block>
				{
					new Block { PosX = 58, PosY = 173, X = 0, Y = 0, Top = 7, Right = 2, Bottom = 6, Left = 4, CorrectRotate = 270 },
					new Block { PosX = -57, PosY = 173, X = -1, Y = 0, Top = 1, Right = 3, Bottom = 4, Left = 0, CorrectRotate = 270 },
					new Block { PosX = -57, PosY = 288, X = -1, Y = 1, Top = 2, Right = 7, Bottom = 0, Left = 6, CorrectRotate = 270 },
					new Block { PosX = -57, PosY = 58, X = -1, Y = -1, Top = 2, Right = 6, Bottom = 4, Left = 2, CorrectRotate = 180 },
					new Block { PosX = -57, PosY = -57, X = -1, Y = -2, Top = 4, Right = 2, Bottom = 5, Left = 1, CorrectRotate = 180 },
					new Block { PosX = -172, PosY = 58, X = -2, Y = -1, Top = 1, Right = 5, Bottom = 5, Left = 2, CorrectRotate = 270 },
					new Block { PosX = 58, PosY = -57, X = 0, Y = -2, Top = 0, Right = 6, Bottom = 4, Left = 6, CorrectRotate = 180 },
					new Block { PosX = -57, PosY = -172, X = -1, Y = -3, Top = 4, Right = 3, Bottom = 2, Left = 6, CorrectRotate = 90 },
					new Block { PosX = -172, PosY = -57, X = -2, Y = -2, Top = 1, Right = 2, Bottom = 5, Left = 6, CorrectRotate = 90 },
					new Block { PosX = -172, PosY = 173, X = -2, Y = 0, Top = 5, Right = 1, Bottom = 2, Left = 3, CorrectRotate = 180 },
					new Block { PosX = 58, PosY = 58, X = 0, Y = -1, Top = 4, Right = 3, Bottom = 5, Left = 5, CorrectRotate = 270 },
					new Block { PosX = 58, PosY = -172, X = 0, Y = -3, Top = 5, Right = 7, Bottom = 7, Left = 0, CorrectRotate = 90 },
					new Block { PosX = -172, PosY = -172, X = -2, Y = -3, Top = 0, Right = 0, Bottom = 1, Left = 3, CorrectRotate = 180 },
					new Block { PosX = -287, PosY = -57, X = -3, Y = -2, Top = 6, Right = 2, Bottom = 5, Left = 1, CorrectRotate = 270 },
					new Block { PosX = -172, PosY = 288, X = -2, Y = 1, Top = 7, Right = 5, Bottom = 5, Left = 4, CorrectRotate = 270 },
					new Block { PosX = 173, PosY = 58, X = 1, Y = -1, Top = 3, Right = 4, Bottom = 1, Left = 3, CorrectRotate = 90 },
					new Block { PosX = 173, PosY = -172, X = 1, Y = -3, Top = 0, Right = 7, Bottom = 6, Left = 1, CorrectRotate = 90 },
					new Block { PosX = 288, PosY = 58, X = 2, Y = -1, Top = 6, Right = 0, Bottom = 5, Left = 4, CorrectRotate = 90 },
					new Block { PosX = 173, PosY = -57, X = 1, Y = -2, Top = 1, Right = 4, Bottom = 1, Left = 0, CorrectRotate = 90 },
					new Block { PosX = 173, PosY = -287, X = 1, Y = -4, Top = 7, Right = 1, Bottom = 0, Left = 6, CorrectRotate = 270 },
				}
			};
		}
	}
}