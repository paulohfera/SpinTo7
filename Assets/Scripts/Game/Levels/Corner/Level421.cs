using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Corner
{
	public abstract class Level421
	{
		public static LevelCorner GetLevel()
		{
			return new LevelCorner
			{
				Number = 421,
				MatchsToWin = 40,
				ThreeStarsLimit = 26,
				TwoStarsLimit = 31,
				BlockSizes = 130,
				Blocks = new List<BlockCorner>
				{
					new BlockCorner { PosX = 195, PosY = -195, X = 0, Y = 0, Corner1 = 7, Corner2 = 1, Corner3 = 2, Corner4 = 0, CorrectRotate = 270 },
					new BlockCorner { PosX = 65, PosY = -195, X = -1, Y = 0, Corner1 = 6, Corner2 = 6, Corner3 = 7, Corner4 = 5, CorrectRotate = 90 },
					new BlockCorner { PosX = 65, PosY = -65, X = -1, Y = 1, Corner1 = 1, Corner2 = 0, Corner3 = -1, Corner4 = 0, CorrectRotate = 90 },
					new BlockCorner { PosX = 65, PosY = -325, X = -1, Y = -1, Corner1 = 9, Corner2 = 6, Corner3 = 1, Corner4 = 2, CorrectRotate = 180 },
					new BlockCorner { PosX = -65, PosY = -195, X = -2, Y = 0, Corner1 = 1, Corner2 = 1, Corner3 = 4, Corner4 = 3, CorrectRotate = 270 },
					new BlockCorner { PosX = 65, PosY = 65, X = -1, Y = 2, Corner1 = 8, Corner2 = 7, Corner3 = 0, Corner4 = 3, CorrectRotate = 180 },
					new BlockCorner { PosX = -65, PosY = 65, X = -2, Y = 2, Corner1 = 0, Corner2 = 4, Corner3 = 1, Corner4 = 7, CorrectRotate = 180 },
					new BlockCorner { PosX = -65, PosY = 195, X = -2, Y = 3, Corner1 = 6, Corner2 = 2, Corner3 = 7, Corner4 = 0, CorrectRotate = 90 },
					new BlockCorner { PosX = -65, PosY = -65, X = -2, Y = 1, Corner1 = 4, Corner2 = 3, Corner3 = 7, Corner4 = 6, CorrectRotate = 90 },
					new BlockCorner { PosX = 65, PosY = 195, X = -1, Y = 3, Corner1 = 7, Corner2 = 0, Corner3 = 2, Corner4 = 4, CorrectRotate = 90 },
					new BlockCorner { PosX = -195, PosY = -65, X = -3, Y = 1, Corner1 = 9, Corner2 = 2, Corner3 = 4, Corner4 = 3, CorrectRotate = 90 },
					new BlockCorner { PosX = 65, PosY = 325, X = -1, Y = 4, Corner1 = 7, Corner2 = 2, Corner3 = 5, Corner4 = 5, CorrectRotate = 90 },
					new BlockCorner { PosX = 195, PosY = 195, X = 0, Y = 3, Corner1 = 8, Corner2 = 3, Corner3 = 5, Corner4 = 5, CorrectRotate = 180 },
				}
			};
		}
	}
}