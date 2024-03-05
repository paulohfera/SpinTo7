using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Corner
{
	public abstract class Level426
	{
		public static LevelCorner GetLevel()
		{
			return new LevelCorner
			{
				Number = 426,
				MatchsToWin = 46,
				ThreeStarsLimit = 36,
				TwoStarsLimit = 44,
				BlockSizes = 130,
				Blocks = new List<BlockCorner>
				{
					new BlockCorner { PosX = -65, PosY = 325, X = 0, Y = 0, Corner1 = 2, Corner2 = 8, Corner3 = 7, Corner4 = 2, CorrectRotate = 180 },
					new BlockCorner { PosX = -65, PosY = 195, X = 0, Y = -1, Corner1 = 0, Corner2 = -2, Corner3 = -1, Corner4 = 5, CorrectRotate = 180 },
					new BlockCorner { PosX = -195, PosY = 325, X = -1, Y = 0, Corner1 = 0, Corner2 = -1, Corner3 = 6, Corner4 = -2, CorrectRotate = 270 },
					new BlockCorner { PosX = 65, PosY = 195, X = 1, Y = -1, Corner1 = 7, Corner2 = 2, Corner3 = 1, Corner4 = 8, CorrectRotate = 90 },
					new BlockCorner { PosX = -65, PosY = 65, X = 0, Y = -2, Corner1 = 8, Corner2 = -1, Corner3 = 9, Corner4 = 7, CorrectRotate = 180 },
					new BlockCorner { PosX = -65, PosY = -65, X = 0, Y = -3, Corner1 = 6, Corner2 = 8, Corner3 = -1, Corner4 = 1, CorrectRotate = 90 },
					new BlockCorner { PosX = -195, PosY = 65, X = -1, Y = -2, Corner1 = 8, Corner2 = -1, Corner3 = 3, Corner4 = -2, CorrectRotate = 180 },
					new BlockCorner { PosX = 65, PosY = -65, X = 1, Y = -3, Corner1 = -1, Corner2 = 6, Corner3 = 8, Corner4 = 3, CorrectRotate = 180 },
					new BlockCorner { PosX = -65, PosY = -195, X = 0, Y = -4, Corner1 = 5, Corner2 = 1, Corner3 = 1, Corner4 = 6, CorrectRotate = 180 },
					new BlockCorner { PosX = -195, PosY = -65, X = -1, Y = -3, Corner1 = -1, Corner2 = 1, Corner3 = 5, Corner4 = 8, CorrectRotate = 270 },
					new BlockCorner { PosX = -195, PosY = 195, X = -1, Y = -1, Corner1 = 8, Corner2 = 9, Corner3 = 4, Corner4 = 1, CorrectRotate = 270 },
					new BlockCorner { PosX = 195, PosY = -65, X = 2, Y = -3, Corner1 = 3, Corner2 = 3, Corner3 = 8, Corner4 = 4, CorrectRotate = 270 },
					new BlockCorner { PosX = 65, PosY = -195, X = 1, Y = -4, Corner1 = 2, Corner2 = 1, Corner3 = 8, Corner4 = 1, CorrectRotate = 90 },
					new BlockCorner { PosX = -65, PosY = -325, X = 0, Y = -5, Corner1 = 2, Corner2 = 0, Corner3 = -1, Corner4 = 6, CorrectRotate = 270 },
				}
			};
		}
	}
}