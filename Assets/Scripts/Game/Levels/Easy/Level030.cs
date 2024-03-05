using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Easy
{
	public abstract class Level030
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 30,
				MatchsToWin = 19,
				ThreeStarsLimit = 32,
				TwoStarsLimit = 38,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = -130, PosY = 130, Fixed = false, X = 0, Y = 0,Top = 2,Right = 2,Bottom = 1,Left = 5,CorrectRotate = 0 },
					new Block { PosX = -130, PosY = 260, Fixed = false, X = 0, Y = 1,Top = 5,Right = 1,Bottom = 4,Left = 1,CorrectRotate = 180 },
					new Block { PosX = 0, PosY = 130, Fixed = false, X = 1, Y = 0,Top = 4,Right = 5,Bottom = 0,Left = 5,CorrectRotate = 0 },
					new Block { PosX = 130, PosY = 130, Fixed = false, X = 2, Y = 0,Top = 0,Right = 2,Bottom = 0,Left = 0,CorrectRotate = 180 },
					new Block { PosX = 0, PosY = 0, Fixed = false, X = 1, Y = -1,Top = 2,Right = 1,Bottom = 0,Left = 7,CorrectRotate = 270 },
					new Block { PosX = 130, PosY = 260, Fixed = false, X = 2, Y = 1,Top = 7,Right = 2,Bottom = 7,Left = 5,CorrectRotate = 180 },
					new Block { PosX = 260, PosY = 130, Fixed = false, X = 3, Y = 0,Top = 1,Right = 3,Bottom = 7,Left = 1,CorrectRotate = 270 },
					new Block { PosX = 130, PosY = 0, Fixed = false, X = 2, Y = -1,Top = 7,Right = 5,Bottom = 1,Left = 5,CorrectRotate = 0 },
					new Block { PosX = 0, PosY = -130, Fixed = false, X = 1, Y = -2,Top = 4,Right = 1,Bottom = 6,Left = 1,CorrectRotate = 180 },
					new Block { PosX = -130, PosY = 0, Fixed = false, X = 0, Y = -1,Top = 7,Right = 4,Bottom = 0,Left = 6,CorrectRotate = 270 },
					new Block { PosX = 0, PosY = -260, Fixed = false, X = 1, Y = -3,Top = 3,Right = 0,Bottom = 1,Left = 5,CorrectRotate = 0 },
					new Block { PosX = -130, PosY = -260, Fixed = false, X = 0, Y = -3,Top = 5,Right = 3,Bottom = 3,Left = 2,CorrectRotate = 180 },
					new Block { PosX = -130, PosY = -130, Fixed = false, X = 0, Y = -2,Top = 4,Right = 5,Bottom = 3,Left = 6,CorrectRotate = 180 },
					new Block { PosX = -260, PosY = -130, Fixed = false, X = -1, Y = -2,Top = 0,Right = 2,Bottom = 0,Left = 5,CorrectRotate = 0 },
					new Block { PosX = -260, PosY = 0, Fixed = false, X = -1, Y = -1,Top = 7,Right = 7,Bottom = 5,Left = 1,CorrectRotate = 270}
				}
			};
		}
	}
}