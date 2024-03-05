using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Moderate
{
	public abstract class Level140
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 140,
				MatchsToWin = 25,
				ThreeStarsLimit = 42,
				TwoStarsLimit = 50,
				BlockSizes = 115,
				Blocks = new List<Block>
				{
					new Block { PosX = 173, PosY = 115, X = 0, Y = 0, Top = 7, Right = 5, Bottom = 8, Left = 5, CorrectRotate = 90 },
					new Block { PosX = 58, PosY = 115, X = -1, Y = 0, Top = 5, Right = 9, Bottom = 0, Left = 2, CorrectRotate = 90 },
					new Block { PosX = 58, PosY = 0, X = -1, Y = -1, Top = -1, Right = 2, Bottom = 5, Left = 6, CorrectRotate = 180 },
					new Block { PosX = -57, PosY = 115, X = -2, Y = 0, Top = 8, Right = 2, Bottom = 0, Left = 2, CorrectRotate = 180 },
					new Block { PosX = 173, PosY = 0, X = 0, Y = -1, Top = 7, Right = 1, Bottom = 2, Left = 0, CorrectRotate = 180 },
					new Block { PosX = -57, PosY = 0, X = -2, Y = -1, Top = 5, Right = -1, Bottom = 9, Left = -1, CorrectRotate = 270 },
					new Block { PosX = -57, PosY = 230, X = -2, Y = 1, Top = -1, Right = 2, Bottom = 6, Left = 7, CorrectRotate = 90 },
					new Block { PosX = 173, PosY = -115, X = 0, Y = -2, Top = 6, Right = 6, Bottom = 0, Left = 4, CorrectRotate = 180 },
					new Block { PosX = -57, PosY = -115, X = -2, Y = -2, Top = 4, Right = 8, Bottom = 0, Left = 3, CorrectRotate = 90 },
					new Block { PosX = -172, PosY = 0, X = -3, Y = -1, Top = -2, Right = 9, Bottom = 4, Left = 1, CorrectRotate = 270 },
					new Block { PosX = -57, PosY = 345, X = -2, Y = 2, Top = 1, Right = -2, Bottom = 2, Left = 5, CorrectRotate = 90 },
					new Block { PosX = 58, PosY = 230, X = -1, Y = 1, Top = -2, Right = 1, Bottom = 6, Left = 9, CorrectRotate = 180 },
					new Block { PosX = 288, PosY = -115, X = 1, Y = -2, Top = 3, Right = 7, Bottom = 2, Left = 8, CorrectRotate = 90 },
					new Block { PosX = 173, PosY = -230, X = 0, Y = -3, Top = 6, Right = 9, Bottom = 1, Left = 2, CorrectRotate = 180 },
					new Block { PosX = 58, PosY = -115, X = -1, Y = -2, Top = 1, Right = 4, Bottom = 7, Left = 8, CorrectRotate = 270 },
					new Block { PosX = -172, PosY = -115, X = -3, Y = -2, Top = 9, Right = -2, Bottom = 3, Left = 0, CorrectRotate = 90 },
					new Block { PosX = 58, PosY = -230, X = -1, Y = -3, Top = 1, Right = 3, Bottom = -2, Left = 3, CorrectRotate = 90 },
					new Block { PosX = -287, PosY = -115, X = -4, Y = -2, Top = -1, Right = 5, Bottom = 0, Left = -2, CorrectRotate = 180 },
					new Block { PosX = 58, PosY = -345, X = -1, Y = -4, Top = 7, Right = 4, Bottom = 4, Left = 9, CorrectRotate = 180 },
				}
			};
		}
	}
}