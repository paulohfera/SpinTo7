using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hard
{
	public abstract class Level257
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 257,
				MatchsToWin = 22,
				ThreeStarsLimit = 46,
				TwoStarsLimit = 56,
				BlockSizes = 115,
				Blocks = new List<Block>
				{
					new Block { PosX = 173, PosY = 0, X = 0, Y = 0, Top = 5, Right = 5, Bottom = -2, Left = -2, CorrectRotate = 270 },
					new Block { PosX = 173, PosY = 115, X = 0, Y = 1, Top = 9, Right = 9, Bottom = 0, Left = 7, CorrectRotate = 180 },
					new Block { PosX = 288, PosY = 0, X = 1, Y = 0, Top = 2, Right = 2, Bottom = -1, Left = 2, CorrectRotate = 90 },
					new Block { PosX = 288, PosY = 115, X = 1, Y = 1, Top = 5, Right = 5, Bottom = 0, Left = 3, CorrectRotate = 270 },
					new Block { PosX = 288, PosY = -115, X = 1, Y = -1, Top = 2, Right = 4, Bottom = 5, Left = 5, CorrectRotate = 270 },
					new Block { PosX = 173, PosY = -115, X = 0, Y = -1, Top = 2, Right = 1, Bottom = 4, Left = 2, CorrectRotate = 270 },
					new Block { PosX = 58, PosY = -115, X = -1, Y = -1, Top = 3, Right = 9, Bottom = 6, Left = 4, CorrectRotate = 270 },
					new Block { PosX = 58, PosY = 0, X = -1, Y = 0, Top = 3, Right = 1, Bottom = 8, Left = 9, CorrectRotate = 180 },
					new Block { PosX = -57, PosY = -115, X = -2, Y = -1, Top = 1, Right = 8, Bottom = 3, Left = 3, CorrectRotate = 270 },
					new Block { PosX = 58, PosY = 115, X = -1, Y = 1, Top = -2, Right = -1, Bottom = 6, Left = 5, CorrectRotate = 270 },
					new Block { PosX = -57, PosY = 0, X = -2, Y = 0, Top = -1, Right = -1, Bottom = 6, Left = 4, CorrectRotate = 90 },
					new Block { PosX = -172, PosY = -115, X = -3, Y = -1, Top = 6, Right = 6, Bottom = 6, Left = 4, CorrectRotate = 180 },
					new Block { PosX = -287, PosY = -115, X = -4, Y = -1, Top = 9, Right = 6, Bottom = 1, Left = -2, CorrectRotate = 90 },
					new Block { PosX = -287, PosY = 0, X = -4, Y = 0, Top = 6, Right = 1, Bottom = 9, Left = 5, CorrectRotate = 270 },
					new Block { PosX = 58, PosY = -230, X = -1, Y = -2, Top = 6, Right = -2, Bottom = 1, Left = 0, CorrectRotate = 90 },
					new Block { PosX = -57, PosY = -230, X = -2, Y = -2, Top = 1, Right = 4, Bottom = 6, Left = -1, CorrectRotate = 270 },
					new Block { PosX = 58, PosY = 230, X = -1, Y = 2, Top = 2, Right = 6, Bottom = 4, Left = 2, CorrectRotate = 90 },
				}
			};
		}
	}
}