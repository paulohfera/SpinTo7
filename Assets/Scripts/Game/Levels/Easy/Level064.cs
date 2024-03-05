using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Easy
{
	public abstract class Level064
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 64,
				MatchsToWin = 38,
				ThreeStarsLimit = 63,
				TwoStarsLimit = 75,
				BlockSizes = 115,
				Blocks = new List<Block>
				{
					new Block { PosX = 288, PosY = -115, X = 0, Y = 0, Top = 4, Right = 3, Bottom = 2, Left = 4, CorrectRotate = 90 },
					new Block { PosX = 288, PosY = -230, X = 0, Y = -1, Top = 7, Right = 3, Bottom = 2, Left = 6, CorrectRotate = 90 },
					new Block { PosX = 173, PosY = -230, X = -1, Y = -1, Top = 0, Right = 7, Bottom = 3, Left = 5, CorrectRotate = 270 },
					new Block { PosX = 173, PosY = -345, X = -1, Y = -2, Top = 7, Right = 4, Bottom = 3, Left = 0, CorrectRotate = 270 },
					new Block { PosX = 58, PosY = -230, X = -2, Y = -1, Top = 1, Right = 6, Bottom = 5, Left = 4, CorrectRotate = 180 },
					new Block { PosX = -57, PosY = -230, X = -3, Y = -1, Top = 7, Right = 0, Bottom = 1, Left = 6, CorrectRotate = 90 },
					new Block { PosX = -57, PosY = -115, X = -3, Y = 0, Top = 7, Right = 0, Bottom = 2, Left = 7, CorrectRotate = 180 },
					new Block { PosX = -172, PosY = -115, X = -4, Y = 0, Top = 5, Right = 3, Bottom = 7, Left = 7, CorrectRotate = 180 },
					new Block { PosX = -172, PosY = 0, X = -4, Y = 1, Top = 2, Right = 7, Bottom = 3, Left = 0, CorrectRotate = 90 },
					new Block { PosX = -57, PosY = 0, X = -3, Y = 1, Top = 4, Right = 7, Bottom = 4, Left = 5, CorrectRotate = 90 },
					new Block { PosX = -57, PosY = 115, X = -3, Y = 2, Top = 2, Right = 7, Bottom = 7, Left = 0, CorrectRotate = 90 },
					new Block { PosX = 58, PosY = 0, X = -2, Y = 1, Top = 5, Right = 3, Bottom = 3, Left = 6, CorrectRotate = 270 },
					new Block { PosX = -57, PosY = 230, X = -3, Y = 3, Top = 1, Right = 0, Bottom = 1, Left = 1, CorrectRotate = 270 },
					new Block { PosX = 58, PosY = 115, X = -2, Y = 2, Top = 1, Right = 0, Bottom = 1, Left = 3, CorrectRotate = 180 },
					new Block { PosX = -172, PosY = 115, X = -4, Y = 2, Top = 5, Right = 0, Bottom = 1, Left = 1, CorrectRotate = 270 },
					new Block { PosX = 58, PosY = -115, X = -2, Y = 0, Top = 2, Right = 0, Bottom = 4, Left = 1, CorrectRotate = 180 },
					new Block { PosX = -172, PosY = 230, X = -4, Y = 3, Top = 7, Right = 7, Bottom = 6, Left = 6, CorrectRotate = 90 },
					new Block { PosX = 58, PosY = 230, X = -2, Y = 3, Top = 1, Right = 6, Bottom = 6, Left = 6, CorrectRotate = 270 },
					new Block { PosX = -287, PosY = 115, X = -5, Y = 2, Top = 6, Right = 0, Bottom = 2, Left = 5, CorrectRotate = 270 },
					new Block { PosX = 173, PosY = -115, X = -1, Y = 0, Top = 6, Right = 1, Bottom = 3, Left = 2, CorrectRotate = 90 },
					new Block { PosX = 58, PosY = 345, X = -2, Y = 4, Top = 0, Right = 1, Bottom = 5, Left = 3, CorrectRotate = 270 },
					new Block { PosX = 173, PosY = 230, X = -1, Y = 3, Top = 6, Right = 0, Bottom = 6, Left = 5, CorrectRotate = 90 },
					new Block { PosX = -287, PosY = 230, X = -5, Y = 3, Top = 2, Right = 6, Bottom = 0, Left = 2, CorrectRotate = 90 },
					new Block { PosX = 173, PosY = 115, X = -1, Y = 2, Top = 4, Right = 2, Bottom = 6, Left = 1, CorrectRotate = 90 },
					new Block { PosX = -172, PosY = 345, X = -4, Y = 4, Top = 1, Right = 4, Bottom = 1, Left = 0, CorrectRotate = 90 },
					new Block { PosX = -57, PosY = 345, X = -3, Y = 4, Top = 6, Right = 6, Bottom = 4, Left = 2, CorrectRotate = 180 },
				}
			};
		}
	}
}