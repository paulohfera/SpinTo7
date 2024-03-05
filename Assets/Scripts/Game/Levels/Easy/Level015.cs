using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Easy
{
	public abstract class Level015
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 15,
				MatchsToWin = 13,
				ThreeStarsLimit = 36,
				TwoStarsLimit = 46,
				BlockSizes = 115,
				Blocks = new List<Block>
				{
					new Block { PosX = 287.5f, PosY = 0, X = 0, Y = 0, Top = 3, Right = 3, Bottom = 2, Left = 5, CorrectRotate = 270 },
					new Block { PosX = 287.5f, PosY = -115, X = 0, Y = -1, Top = 5, Right = 1, Bottom = 1, Left = 4, CorrectRotate = 270 },
					new Block { PosX = 172.5f, PosY = 0, X = -1, Y = 0, Top = 5, Right = 6, Bottom = 5, Left = 3, CorrectRotate = 270 },
					new Block { PosX = 57.5f, PosY = 0, X = -2, Y = 0, Top = 2, Right = 4, Bottom = 0, Left = 4, CorrectRotate = 270 },
					new Block { PosX = -57.5f, PosY = 0, X = -3, Y = 0, Top = 3, Right = 6, Bottom = 6, Left = 7, CorrectRotate = 180 },
					new Block { PosX = -57.5f, PosY = -115, X = -3, Y = -1, Top = 4, Right = 3, Bottom = 1, Left = 3, CorrectRotate = 0 },
					new Block { PosX = -172.5f, PosY = 0, X = -4, Y = 0, Top = 1, Right = 5, Bottom = 4, Left = 5, CorrectRotate = 270 },
					new Block { PosX = 57.5f, PosY = -115, X = -2, Y = -1, Top = 6, Right = 4, Bottom = 3, Left = 7, CorrectRotate = 180 },
					new Block { PosX = -172.5f, PosY = -115, X = -4, Y = -1, Top = 4, Right = 4, Bottom = 4, Left = 2, CorrectRotate = 270 },
					new Block { PosX = -172.5f, PosY = 115, X = -4, Y = 1, Top = 2, Right = 7, Bottom = 0, Left = 2, CorrectRotate = 180 },
					new Block { PosX = -287.5f, PosY = 115, X = -5, Y = 1, Top = 6, Right = 4, Bottom = 7, Left = 0, CorrectRotate = 180 },
					new Block { PosX = 172.5f, PosY = 115, X = -1, Y = 1, Top = 0, Right = 1, Bottom = 5, Left = 4, CorrectRotate = 90 },
				}
			};
		}
	}
}