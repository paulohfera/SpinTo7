using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Moderate
{
	public abstract class Level178
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 178,
				MatchsToWin = 41,
				ThreeStarsLimit = 74,
				TwoStarsLimit = 89,
				BlockSizes = 115,
				Blocks = new List<Block>
				{
					new Block { PosX = 288, PosY = 230, X = 0, Y = 0, Top = 8, Right = 5, Bottom = 9, Left = -2, CorrectRotate = 90 },
					new Block { PosX = 288, PosY = 345, X = 0, Y = 1, Top = 6, Right = 2, Bottom = 0, Left = 3, CorrectRotate = 270 },
					new Block { PosX = 173, PosY = 345, X = -1, Y = 1, Top = 8, Right = 6, Bottom = 2, Left = 7, CorrectRotate = 180 },
					new Block { PosX = 173, PosY = 230, X = -1, Y = 0, Top = 0, Right = -1, Bottom = -1, Left = -1, CorrectRotate = 90 },
					new Block { PosX = 173, PosY = 115, X = -1, Y = -1, Top = 5, Right = 4, Bottom = 4, Left = 8, CorrectRotate = 270 },
					new Block { PosX = 58, PosY = 230, X = -2, Y = 0, Top = -2, Right = 1, Bottom = 7, Left = 1, CorrectRotate = 90 },
					new Block { PosX = 58, PosY = 115, X = -2, Y = -1, Top = 7, Right = 5, Bottom = 6, Left = 3, CorrectRotate = 180 },
					new Block { PosX = 58, PosY = 0, X = -2, Y = -2, Top = 4, Right = 0, Bottom = -2, Left = 2, CorrectRotate = 90 },
					new Block { PosX = 58, PosY = -115, X = -2, Y = -3, Top = 2, Right = 8, Bottom = 5, Left = 7, CorrectRotate = 180 },
					new Block { PosX = -57, PosY = 0, X = -3, Y = -2, Top = -2, Right = 9, Bottom = 3, Left = 7, CorrectRotate = 90 },
					new Block { PosX = -57, PosY = -115, X = -3, Y = -3, Top = 3, Right = 7, Bottom = 0, Left = -1, CorrectRotate = 180 },
					new Block { PosX = 173, PosY = -115, X = -1, Y = -3, Top = -1, Right = 0, Bottom = 0, Left = 8, CorrectRotate = 270 },
					new Block { PosX = 58, PosY = -230, X = -2, Y = -4, Top = -2, Right = -2, Bottom = 6, Left = 5, CorrectRotate = 270 },
					new Block { PosX = -57, PosY = 115, X = -3, Y = -1, Top = 2, Right = -2, Bottom = 1, Left = 6, CorrectRotate = 270 },
					new Block { PosX = -57, PosY = -230, X = -3, Y = -4, Top = 2, Right = 4, Bottom = 1, Left = 8, CorrectRotate = 90 },
					new Block { PosX = -172, PosY = -115, X = -4, Y = -3, Top = 0, Right = 9, Bottom = 6, Left = -2, CorrectRotate = 270 },
					new Block { PosX = 173, PosY = 0, X = -1, Y = -2, Top = 6, Right = -1, Bottom = 9, Left = 3, CorrectRotate = 270 },
					new Block { PosX = 173, PosY = -230, X = -1, Y = -4, Top = 4, Right = 2, Bottom = 9, Left = 7, CorrectRotate = 270 },
					new Block { PosX = -57, PosY = 230, X = -3, Y = 0, Top = 1, Right = 9, Bottom = 9, Left = 9, CorrectRotate = 180 },
					new Block { PosX = -57, PosY = -345, X = -3, Y = -5, Top = 9, Right = 6, Bottom = -2, Left = -1, CorrectRotate = 270 },
					new Block { PosX = -172, PosY = -230, X = -4, Y = -4, Top = 5, Right = 6, Bottom = -1, Left = -2, CorrectRotate = 270 },
					new Block { PosX = -172, PosY = 0, X = -4, Y = -2, Top = 3, Right = 1, Bottom = 9, Left = 9, CorrectRotate = 90 },
					new Block { PosX = 288, PosY = 0, X = 0, Y = -2, Top = 1, Right = 9, Bottom = 1, Left = 0, CorrectRotate = 90 },
					new Block { PosX = 288, PosY = -230, X = 0, Y = -4, Top = 7, Right = 5, Bottom = 3, Left = 0, CorrectRotate = 270 },
					new Block { PosX = -57, PosY = 345, X = -3, Y = 1, Top = 5, Right = 2, Bottom = 3, Left = -2, CorrectRotate = 90 },
					new Block { PosX = -172, PosY = 230, X = -4, Y = 0, Top = 9, Right = 4, Bottom = -2, Left = 0, CorrectRotate = 90 },
					new Block { PosX = 58, PosY = -345, X = -2, Y = -5, Top = 5, Right = 1, Bottom = -2, Left = 9, CorrectRotate = 270 },
					new Block { PosX = -172, PosY = -345, X = -4, Y = -5, Top = -2, Right = 6, Bottom = 1, Left = 9, CorrectRotate = 180 },
					new Block { PosX = -287, PosY = -230, X = -5, Y = -4, Top = 2, Right = 1, Bottom = 8, Left = -2, CorrectRotate = 90 },
				}
			};
		}
	}
}