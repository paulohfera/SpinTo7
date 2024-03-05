using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Easy
{
	public abstract class Level075
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 75,
				MatchsToWin = 42,
				ThreeStarsLimit = 76,
				TwoStarsLimit = 90,
				BlockSizes = 115,
				Blocks = new List<Block>
				{
					new Block { PosX = 288, PosY = -172, X = 0, Y = 0, Top = 4, Right = 0, Bottom = 4, Left = 7, CorrectRotate = 270 },
					new Block { PosX = 173, PosY = -172, X = -1, Y = 0, Top = 3, Right = 2, Bottom = 7, Left = 3, CorrectRotate = 270 },
					new Block { PosX = 58, PosY = -172, X = -2, Y = 0, Top = 0, Right = 0, Bottom = 3, Left = 2, CorrectRotate = 270 },
					new Block { PosX = 58, PosY = -57, X = -2, Y = 1, Top = 0, Right = 5, Bottom = 7, Left = 4, CorrectRotate = 270 },
					new Block { PosX = 58, PosY = -287, X = -2, Y = -1, Top = 7, Right = 4, Bottom = 0, Left = 7, CorrectRotate = 270 },
					new Block { PosX = -57, PosY = -172, X = -3, Y = 0, Top = 7, Right = 7, Bottom = 4, Left = 1, CorrectRotate = 90 },
					new Block { PosX = 58, PosY = 58, X = -2, Y = 2, Top = 1, Right = 3, Bottom = 2, Left = 7, CorrectRotate = 270 },
					new Block { PosX = 173, PosY = -57, X = -1, Y = 1, Top = 7, Right = 4, Bottom = 7, Left = 4, CorrectRotate = 270 },
					new Block { PosX = 173, PosY = -287, X = -1, Y = -1, Top = 5, Right = 0, Bottom = 5, Left = 7, CorrectRotate = 180 },
					new Block { PosX = -57, PosY = -287, X = -3, Y = -1, Top = 0, Right = 6, Bottom = 7, Left = 6, CorrectRotate = 90 },
					new Block { PosX = -57, PosY = -57, X = -3, Y = 1, Top = 3, Right = 4, Bottom = 0, Left = 0, CorrectRotate = 90 },
					new Block { PosX = 58, PosY = 173, X = -2, Y = 3, Top = 3, Right = 4, Bottom = 4, Left = 0, CorrectRotate = 90 },
					new Block { PosX = 173, PosY = 58, X = -1, Y = 2, Top = 6, Right = 0, Bottom = 4, Left = 3, CorrectRotate = 90 },
					new Block { PosX = -57, PosY = 58, X = -3, Y = 2, Top = 3, Right = 2, Bottom = 2, Left = 5, CorrectRotate = 180 },
					new Block { PosX = 288, PosY = -57, X = 0, Y = 1, Top = 0, Right = 0, Bottom = 7, Left = 1, CorrectRotate = 180 },
					new Block { PosX = 173, PosY = -402, X = -1, Y = -2, Top = 0, Right = 2, Bottom = 1, Left = 3, CorrectRotate = 90 },
					new Block { PosX = -57, PosY = -402, X = -3, Y = -2, Top = 6, Right = 0, Bottom = 6, Left = 1, CorrectRotate = 270 },
					new Block { PosX = -172, PosY = -287, X = -4, Y = -1, Top = 7, Right = 4, Bottom = 0, Left = 1, CorrectRotate = 270 },
					new Block { PosX = -172, PosY = -57, X = -4, Y = 1, Top = 6, Right = 0, Bottom = 4, Left = 3, CorrectRotate = 90 },
					new Block { PosX = 58, PosY = 288, X = -2, Y = 4, Top = 6, Right = 3, Bottom = 5, Left = 7, CorrectRotate = 270 },
					new Block { PosX = 173, PosY = 173, X = -1, Y = 3, Top = 7, Right = 7, Bottom = 3, Left = 0, CorrectRotate = 270 },
					new Block { PosX = -57, PosY = 173, X = -3, Y = 3, Top = 5, Right = 1, Bottom = 0, Left = 4, CorrectRotate = 180 },
					new Block { PosX = 58, PosY = -402, X = -2, Y = -2, Top = 1, Right = 3, Bottom = 7, Left = 5, CorrectRotate = 90 },
					new Block { PosX = -172, PosY = -172, X = -4, Y = 0, Top = 6, Right = 5, Bottom = 4, Left = 0, CorrectRotate = 180 },
					new Block { PosX = -287, PosY = -287, X = -5, Y = -1, Top = 4, Right = 3, Bottom = 7, Left = 4, CorrectRotate = 90 },
					new Block { PosX = -172, PosY = 58, X = -4, Y = 2, Top = 7, Right = 1, Bottom = 5, Left = 5, CorrectRotate = 180 },
					new Block { PosX = 58, PosY = 403, X = -2, Y = 5, Top = 0, Right = 1, Bottom = 7, Left = 4, CorrectRotate = 180 },
					new Block { PosX = 173, PosY = 288, X = -1, Y = 4, Top = 7, Right = 1, Bottom = 2, Left = 2, CorrectRotate = 180 },
				}
			};
		}
	}
}