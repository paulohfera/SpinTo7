using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Corner
{
	public abstract class Level407
	{
		public static LevelCorner GetLevel()
		{
			return new LevelCorner
			{
				Number = 407,
				MatchsToWin = 20,
				ThreeStarsLimit = 15,
				TwoStarsLimit = 18,
				BlockSizes = 130,
				Blocks = new List<BlockCorner>
				{
					new BlockCorner { PosX = 0, PosY = -65, X = 0, Y = 0, Corner1 = 8, Corner2 = 2, Corner3 = 7, Corner4 = -2, CorrectRotate = 90 },
					new BlockCorner { PosX = 0, PosY = 65, X = 0, Y = 1, Corner1 = 5, Corner2 = -2, Corner3 = 8, Corner4 = 0, CorrectRotate = 90 },
					new BlockCorner { PosX = 130, PosY = -65, X = 1, Y = 0, Corner1 = 9, Corner2 = 0, Corner3 = 7, Corner4 = 8, CorrectRotate = 90 },
					new BlockCorner { PosX = 0, PosY = -195, X = 0, Y = -1, Corner1 = 0, Corner2 = 6, Corner3 = -1, Corner4 = 9, CorrectRotate = 180 },
					new BlockCorner { PosX = -130, PosY = -65, X = -1, Y = 0, Corner1 = 5, Corner2 = -1, Corner3 = 4, Corner4 = 7, CorrectRotate = 270 },
					new BlockCorner { PosX = 0, PosY = 195, X = 0, Y = 2, Corner1 = 9, Corner2 = -1, Corner3 = 9, Corner4 = 6, CorrectRotate = 270 },
					new BlockCorner { PosX = 130, PosY = 65, X = 1, Y = 1, Corner1 = 7, Corner2 = -1, Corner3 = -2, Corner4 = 0, CorrectRotate = 90 },
				}
			};
		}
	}
}