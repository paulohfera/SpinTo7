using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Moderate
{
	public abstract class Level127
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 127,
				MatchsToWin = 17,
				ThreeStarsLimit = 37,
				TwoStarsLimit = 44,
				BlockSizes = 115,
				Blocks = new List<Block>
				{
					new Block { PosX = -172, PosY = 230, X = 0, Y = 0, Top = 5, Right = 6, Bottom = -2, Left = 0, CorrectRotate = 90 },
					new Block { PosX = -172, PosY = 115, X = 0, Y = -1, Top = -1, Right = 4, Bottom = 7, Left = 2, CorrectRotate = 180 },
					new Block { PosX = -287, PosY = 230, X = -1, Y = 0, Top = 2, Right = 0, Bottom = 2, Left = 5, CorrectRotate = 90 },
					new Block { PosX = -57, PosY = 115, X = 1, Y = -1, Top = 2, Right = 5, Bottom = 8, Left = 1, CorrectRotate = 180 },
					new Block { PosX = -57, PosY = 0, X = 1, Y = -2, Top = 6, Right = 0, Bottom = 5, Left = 6, CorrectRotate = 180 },
					new Block { PosX = 58, PosY = 0, X = 2, Y = -2, Top = 3, Right = 1, Bottom = 6, Left = 7, CorrectRotate = 180 },
					new Block { PosX = -57, PosY = -115, X = 1, Y = -3, Top = 1, Right = 2, Bottom = 4, Left = 1, CorrectRotate = 270 },
					new Block { PosX = -172, PosY = 0, X = 0, Y = -2, Top = 3, Right = 7, Bottom = 8, Left = 7, CorrectRotate = 180 },
					new Block { PosX = 173, PosY = 0, X = 3, Y = -2, Top = 4, Right = 0, Bottom = 4, Left = -2, CorrectRotate = 180 },
					new Block { PosX = 173, PosY = -115, X = 3, Y = -3, Top = 7, Right = 1, Bottom = 3, Left = 3, CorrectRotate = 180 },
					new Block { PosX = 288, PosY = -115, X = 4, Y = -3, Top = 2, Right = 9, Bottom = 4, Left = 7, CorrectRotate = 270 },
					new Block { PosX = 173, PosY = -230, X = 3, Y = -4, Top = 2, Right = 2, Bottom = 8, Left = 0, CorrectRotate = 270 },
					new Block { PosX = 288, PosY = 0, X = 4, Y = -2, Top = 9, Right = 6, Bottom = 9, Left = 0, CorrectRotate = 90 },
					new Block { PosX = 58, PosY = -115, X = 2, Y = -3, Top = 6, Right = 9, Bottom = 6, Left = 4, CorrectRotate = 270 },
				}
			};
		}
	}
}