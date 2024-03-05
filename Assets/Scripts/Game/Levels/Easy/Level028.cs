using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Easy
{
	public abstract class Level028
	{
		public static Level GetLevel()
		{
			return new Level
			{
				Number = 28,
				MatchsToWin = 17,
				ThreeStarsLimit = 29,
				TwoStarsLimit = 35,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 65, PosY = -195, Fixed = false,X = 0,Y = 0,Top = 5,Right = 6,Bottom = 1,Left = 4,CorrectRotate = 180 },
					new Block { PosX = 65, PosY = -65, Fixed = false,X = 0,Y = 1,Top = 2,Right = 6,Bottom = 6,Left = 4,CorrectRotate = 0 },
					new Block { PosX = 195, PosY = -195, Fixed = false,X = 1,Y = 0,Top = 6,Right = 2,Bottom = 3,Left = 3,CorrectRotate = 0 },
					new Block { PosX = 65, PosY = -325, Fixed = false,X = 0,Y = -1,Top = 6,Right = 4,Bottom = 2,Left = 0,CorrectRotate = 180 },
					new Block { PosX = -65, PosY = -195, Fixed = false,X = -1,Y = 0,Top = 1,Right = 1,Bottom = 7,Left = 7,CorrectRotate = 0 },
					new Block { PosX = 65, PosY = 65, Fixed = false,X = 0,Y = 2,Top = 5,Right = 3,Bottom = 6,Left = 2,CorrectRotate = 180 },
					new Block { PosX = -65, PosY = 65, Fixed = false,X = -1,Y = 2,Top = 4,Right = 6,Bottom = 6,Left = 2,CorrectRotate = 270 },
					new Block { PosX = -65, PosY = 195, Fixed = false,X = -1,Y = 3,Top = 4,Right = 1,Bottom = 5,Left = 0,CorrectRotate = 0 },
					new Block { PosX = -65, PosY = -65, Fixed = false,X = -1,Y = 1,Top = 3,Right = 6,Bottom = 3,Left = 1,CorrectRotate = 270 },
					new Block { PosX = 65, PosY = 195, Fixed = false,X = 0,Y = 3,Top = 3,Right = 1,Bottom = 6,Left = 6,CorrectRotate = 270 },
					new Block { PosX = -195, PosY = -65, Fixed = false,X = -2,Y = 1,Top = 1,Right = 4,Bottom = 3,Left = 6,CorrectRotate = 0 },
					new Block { PosX = 65, PosY = 325, Fixed = false,X = 0,Y = 4,Top = 1,Right = 6,Bottom = 4,Left = 5,CorrectRotate = 180 },
					new Block { PosX = 195, PosY = 195, Fixed = false,X = 1,Y = 3,Top = 6,Right = 4,Bottom = 3,Left = 3,CorrectRotate = 180 },
					new Block { PosX = -195, PosY = 65, Fixed = false,X = -2,Y = 2,Top = 1,Right = 6,Bottom = 6,Left = 0,CorrectRotate = 270 },
				}
			};
		}
	}
}