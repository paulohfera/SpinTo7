using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Corner
{
	public abstract class Level422
	{
		public static LevelCorner GetLevel()
		{
			return new LevelCorner
			{
				Number = 422,
				MatchsToWin = 42,
				ThreeStarsLimit = 28,
				TwoStarsLimit = 34,
				BlockSizes = 130,
				Blocks = new List<BlockCorner>
				{
					new BlockCorner { PosX = -260, PosY = 0, X = 0, Y = 0, Corner1 = 5, Corner2 = 6, Corner3 = -1, Corner4 = 2, CorrectRotate = 270 },
					new BlockCorner { PosX = -260, PosY = 130, X = 0, Y = 1, Corner1 = 5, Corner2 = 1, Corner3 = 9, Corner4 = 2, CorrectRotate = 90 },
					new BlockCorner { PosX = -130, PosY = 130, X = 1, Y = 1, Corner1 = -2, Corner2 = 9, Corner3 = 5, Corner4 = -2, CorrectRotate = 270 },
					new BlockCorner { PosX = 0, PosY = 130, X = 2, Y = 1, Corner1 = 2, Corner2 = 9, Corner3 = -2, Corner4 = 9, CorrectRotate = 270 },
					new BlockCorner { PosX = -130, PosY = 0, X = 1, Y = 0, Corner1 = 3, Corner2 = 1, Corner3 = 2, Corner4 = -2, CorrectRotate = 180 },
					new BlockCorner { PosX = 130, PosY = 130, X = 3, Y = 1, Corner1 = -2, Corner2 = 5, Corner3 = 5, Corner4 = -2, CorrectRotate = 90 },
					new BlockCorner { PosX = 0, PosY = 0, X = 2, Y = 0, Corner1 = -1, Corner2 = 4, Corner3 = 9, Corner4 = -2, CorrectRotate = 180 },
					new BlockCorner { PosX = -130, PosY = -130, X = 1, Y = -1, Corner1 = 5, Corner2 = 0, Corner3 = 6, Corner4 = 4, CorrectRotate = 180 },
					new BlockCorner { PosX = 130, PosY = 260, X = 3, Y = 2, Corner1 = 2, Corner2 = 8, Corner3 = -1, Corner4 = 2, CorrectRotate = 90 },
					new BlockCorner { PosX = 260, PosY = 130, X = 4, Y = 1, Corner1 = -2, Corner2 = 9, Corner3 = 2, Corner4 = 6, CorrectRotate = 180 },
					new BlockCorner { PosX = 130, PosY = 0, X = 3, Y = 0, Corner1 = 8, Corner2 = 9, Corner3 = 9, Corner4 = 9, CorrectRotate = 90 },
					new BlockCorner { PosX = 0, PosY = -130, X = 2, Y = -1, Corner1 = 2, Corner2 = 3, Corner3 = 8, Corner4 = 6, CorrectRotate = 90 },
					new BlockCorner { PosX = -130, PosY = -260, X = 1, Y = -2, Corner1 = 1, Corner2 = 7, Corner3 = 2, Corner4 = 6, CorrectRotate = 90 },
				}
			};
		}
	}
}