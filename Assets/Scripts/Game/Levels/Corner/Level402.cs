using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Corner
{
	public abstract class Level402
	{
		public static LevelCorner GetLevel()
		{
			return new LevelCorner
			{
				Number = 402,
				MatchsToWin = 13,
				ThreeStarsLimit = 14,
				TwoStarsLimit = 16,
				BlockSizes = 130,
				Blocks = new List<BlockCorner>
				{
					new BlockCorner { PosX = 0, PosY = 130, X = 0, Y = 0, Corner1 = 4, Corner2 = -1, Corner3 = 2, Corner4 = 9, CorrectRotate = 180 },
					new BlockCorner { PosX = 0, PosY = 0, X = 0, Y = -1, Corner1 = 3, Corner2 = 6, Corner3 = -1, Corner4 = 8, CorrectRotate = 270 },
					new BlockCorner { PosX = -130, PosY = 130, X = -1, Y = 0, Corner1 = 8, Corner2 = 2, Corner3 = 5, Corner4 = 8, CorrectRotate = 90 },
					new BlockCorner { PosX = 130, PosY = 0, X = 1, Y = -1, Corner1 = 0, Corner2 = 1, Corner3 = 4, Corner4 = 7, CorrectRotate = 180 },
					new BlockCorner { PosX = 0, PosY = -130, X = 0, Y = -2, Corner1 = 1, Corner2 = 4, Corner3 = 8, Corner4 = 8, CorrectRotate = 270 },
				}
			};
		}
	}
}