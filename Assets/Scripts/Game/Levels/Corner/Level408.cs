using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Corner
{
	public abstract class Level408
	{
		public static LevelCorner GetLevel()
		{
			return new LevelCorner
			{
				Number = 408,
				MatchsToWin = 23,
				ThreeStarsLimit = 21,
				TwoStarsLimit = 25,
				BlockSizes = 130,
				Blocks = new List<BlockCorner>
				{
					new BlockCorner { PosX = -65, PosY = 65, X = 0, Y = 0, Corner1 = 1, Corner2 = 5, Corner3 = -2, Corner4 = 1, CorrectRotate = 270 },
					new BlockCorner { PosX = 65, PosY = 65, X = 1, Y = 0, Corner1 = 2, Corner2 = 6, Corner3 = 4, Corner4 = 5, CorrectRotate = 90 },
					new BlockCorner { PosX = -65, PosY = -65, X = 0, Y = -1, Corner1 = 3, Corner2 = 9, Corner3 = 2, Corner4 = 6, CorrectRotate = 90 },
					new BlockCorner { PosX = -195, PosY = 65, X = -1, Y = 0, Corner1 = 6, Corner2 = 9, Corner3 = 1, Corner4 = 4, CorrectRotate = 270 },
					new BlockCorner { PosX = 65, PosY = 195, X = 1, Y = 1, Corner1 = 1, Corner2 = -1, Corner3 = 2, Corner4 = 3, CorrectRotate = 90 },
					new BlockCorner { PosX = 195, PosY = 65, X = 2, Y = 0, Corner1 = 0, Corner2 = 2, Corner3 = 3, Corner4 = 6, CorrectRotate = 180 },
					new BlockCorner { PosX = 65, PosY = -65, X = 1, Y = -1, Corner1 = 1, Corner2 = 5, Corner3 = 2, Corner4 = 1, CorrectRotate = 90 },
					new BlockCorner { PosX = -65, PosY = -195, X = 0, Y = -2, Corner1 = 3, Corner2 = 1, Corner3 = 4, Corner4 = 1, CorrectRotate = 180 },
				}
			};
		}
	}
}