using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Corner
{
	public abstract class Level490
	{
		public static LevelCorner GetLevel()
		{
			return new LevelCorner
			{
				Number = 490,
				MatchsToWin = 110,
				ThreeStarsLimit = 77,
				TwoStarsLimit = 93,
				BlockSizes = 100,
				Blocks = new List<BlockCorner>
				{
					new BlockCorner { PosX = 0, PosY = 150, X = 0, Y = 0, Corner1 = 1, Corner2 = 8, Corner3 = 2, Corner4 = -1, CorrectRotate = 270 },
					new BlockCorner { PosX = 100, PosY = 150, X = 1, Y = 0, Corner1 = -1, Corner2 = 6, Corner3 = -1, Corner4 = -1, CorrectRotate = 90 },
					new BlockCorner { PosX = 0, PosY = 50, X = 0, Y = -1, Corner1 = 0, Corner2 = 2, Corner3 = 5, Corner4 = -1, CorrectRotate = 180 },
					new BlockCorner { PosX = 0, PosY = -50, X = 0, Y = -2, Corner1 = 7, Corner2 = 7, Corner3 = 2, Corner4 = 5, CorrectRotate = 270 },
					new BlockCorner { PosX = -100, PosY = 50, X = -1, Y = -1, Corner1 = 5, Corner2 = 2, Corner3 = 2, Corner4 = 5, CorrectRotate = 90 },
					new BlockCorner { PosX = 100, PosY = -50, X = 1, Y = -2, Corner1 = 3, Corner2 = -1, Corner3 = 0, Corner4 = 0, CorrectRotate = 270 },
					new BlockCorner { PosX = 0, PosY = -150, X = 0, Y = -3, Corner1 = -1, Corner2 = -2, Corner3 = 5, Corner4 = 0, CorrectRotate = 180 },
					new BlockCorner { PosX = -100, PosY = -50, X = -1, Y = -2, Corner1 = 2, Corner2 = 5, Corner3 = -2, Corner4 = 2, CorrectRotate = 270 },
					new BlockCorner { PosX = -100, PosY = 150, X = -1, Y = 0, Corner1 = 8, Corner2 = 5, Corner3 = 5, Corner4 = 2, CorrectRotate = 270 },
					new BlockCorner { PosX = 100, PosY = 50, X = 1, Y = -1, Corner1 = 8, Corner2 = 4, Corner3 = 7, Corner4 = 8, CorrectRotate = 270 },
					new BlockCorner { PosX = 100, PosY = -150, X = 1, Y = -3, Corner1 = 8, Corner2 = 7, Corner3 = 8, Corner4 = 9, CorrectRotate = 90 },
					new BlockCorner { PosX = -100, PosY = -150, X = -1, Y = -3, Corner1 = 5, Corner2 = 9, Corner3 = 2, Corner4 = 9, CorrectRotate = 90 },
					new BlockCorner { PosX = -200, PosY = -50, X = -2, Y = -2, Corner1 = -1, Corner2 = 6, Corner3 = 5, Corner4 = 9, CorrectRotate = 90 },
					new BlockCorner { PosX = -100, PosY = 250, X = -1, Y = 1, Corner1 = 5, Corner2 = -2, Corner3 = 2, Corner4 = -1, CorrectRotate = 90 },
					new BlockCorner { PosX = -200, PosY = 150, X = -2, Y = 0, Corner1 = 2, Corner2 = 6, Corner3 = 9, Corner4 = 5, CorrectRotate = 180 },
					new BlockCorner { PosX = 200, PosY = 50, X = 2, Y = -1, Corner1 = 5, Corner2 = 3, Corner3 = -1, Corner4 = 6, CorrectRotate = 180 },
					new BlockCorner { PosX = 200, PosY = -150, X = 2, Y = -3, Corner1 = 5, Corner2 = -2, Corner3 = -1, Corner4 = 5, CorrectRotate = 180 },
					new BlockCorner { PosX = 100, PosY = -250, X = 1, Y = -4, Corner1 = -2, Corner2 = -1, Corner3 = 5, Corner4 = -1, CorrectRotate = 270 },
					new BlockCorner { PosX = 0, PosY = -250, X = 0, Y = -4, Corner1 = 8, Corner2 = 2, Corner3 = 5, Corner4 = 9, CorrectRotate = 270 },
					new BlockCorner { PosX = -100, PosY = -250, X = -1, Y = -4, Corner1 = 9, Corner2 = 2, Corner3 = -2, Corner4 = 2, CorrectRotate = 90 },
					new BlockCorner { PosX = -200, PosY = 250, X = -2, Y = 1, Corner1 = 9, Corner2 = 2, Corner3 = -2, Corner4 = 4, CorrectRotate = 270 },
					new BlockCorner { PosX = -200, PosY = 50, X = -2, Y = -1, Corner1 = 2, Corner2 = 1, Corner3 = 1, Corner4 = 5, CorrectRotate = 180 },
					new BlockCorner { PosX = 300, PosY = 50, X = 3, Y = -1, Corner1 = -2, Corner2 = 2, Corner3 = 1, Corner4 = 8, CorrectRotate = 180 },
					new BlockCorner { PosX = 200, PosY = -50, X = 2, Y = -2, Corner1 = 2, Corner2 = 2, Corner3 = 8, Corner4 = 4, CorrectRotate = 270 },
					new BlockCorner { PosX = 200, PosY = -250, X = 2, Y = -4, Corner1 = 2, Corner2 = 4, Corner3 = 8, Corner4 = 9, CorrectRotate = 270 },
					new BlockCorner { PosX = 100, PosY = -350, X = 1, Y = -5, Corner1 = 6, Corner2 = 2, Corner3 = 8, Corner4 = 1, CorrectRotate = 90 },
					new BlockCorner { PosX = 0, PosY = -350, X = 0, Y = -5, Corner1 = 1, Corner2 = -1, Corner3 = 2, Corner4 = 5, CorrectRotate = 180 },
					new BlockCorner { PosX = -100, PosY = -350, X = -1, Y = -5, Corner1 = 8, Corner2 = 8, Corner3 = -2, Corner4 = 5, CorrectRotate = 180 },
					new BlockCorner { PosX = -200, PosY = -250, X = -2, Y = -4, Corner1 = 5, Corner2 = -2, Corner3 = -1, Corner4 = 5, CorrectRotate = 270 },
					new BlockCorner { PosX = -200, PosY = 350, X = -2, Y = 2, Corner1 = 3, Corner2 = 8, Corner3 = -1, Corner4 = -2, CorrectRotate = 90 },
					new BlockCorner { PosX = -300, PosY = 250, X = -3, Y = 1, Corner1 = 9, Corner2 = 1, Corner3 = 3, Corner4 = 9, CorrectRotate = 90 },
				}
			};
		}
	}
}