using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Easy
{
	public abstract class Level027
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 27,
				MatchsToWin = 17,
				ThreeStarsLimit = 39,
				TwoStarsLimit = 47,
				BlockSizes = 115,
				Blocks = new List<Block>
				{
					new Block { PosX = 58, PosY = 0, X = 0, Y = 0, Top = 5, Right = 2, Bottom = 6, Left = 4, CorrectRotate = 180 },
					new Block { PosX = 58, PosY = 115, X = 0, Y = 1, Top = 1, Right = 5, Bottom = 5, Left = 7, CorrectRotate = 180 },
					new Block { PosX = 173, PosY = 0, X = 1, Y = 0, Top = 1, Right = 3, Bottom = 1, Left = 1, CorrectRotate = 180 },
					new Block { PosX = 58, PosY = -115, X = 0, Y = -1, Top = 0, Right = 7, Bottom = 2, Left = 2, CorrectRotate = 270 },
					new Block { PosX = -57, PosY = 0, X = -1, Y = 0, Top = 5, Right = 0, Bottom = 1, Left = 5, CorrectRotate = 180 },
					new Block { PosX = 58, PosY = 230, X = 0, Y = 2, Top = 2, Right = 4, Bottom = 1, Left = 4, CorrectRotate = 180 },
					new Block { PosX = 173, PosY = 115, X = 1, Y = 1, Top = 4, Right = 6, Bottom = 0, Left = 7, CorrectRotate = 270 },
					new Block { PosX = -57, PosY = 115, X = -1, Y = 1, Top = 0, Right = 2, Bottom = 6, Left = 3, CorrectRotate = 0 },
					new Block { PosX = 288, PosY = 0, X = 2, Y = 0, Top = 2, Right = 3, Bottom = 6, Left = 0, CorrectRotate = 270 },
					new Block { PosX = 173, PosY = -115, X = 1, Y = -1, Top = 3, Right = 7, Bottom = 6, Left = 2, CorrectRotate = 180 },
					new Block { PosX = 58, PosY = -230, X = 0, Y = -2, Top = 2, Right = 2, Bottom = 5, Left = 0, CorrectRotate = 270 },
					new Block { PosX = -57, PosY = -115, X = -1, Y = -1, Top = 1, Right = 5, Bottom = 2, Left = 5, CorrectRotate = 180 },
					new Block { PosX = -172, PosY = 0, X = -2, Y = 0, Top = 6, Right = 7, Bottom = 6, Left = 7, CorrectRotate = 180 },
					new Block { PosX = -287, PosY = 0, X = -3, Y = 0, Top = 0, Right = 6, Bottom = 1, Left = 0, CorrectRotate = 180 },
				}
			};
		}
	}
}