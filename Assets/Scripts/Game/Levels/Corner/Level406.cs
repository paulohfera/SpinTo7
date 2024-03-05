using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Corner
{
	public abstract class Level406
	{
		public static LevelCorner GetLevel()
		{
			return new LevelCorner
			{
				Number = 406,
				MatchsToWin = 21,
				ThreeStarsLimit = 15,
				TwoStarsLimit = 18,
				BlockSizes = 130,
				Blocks = new List<BlockCorner>
				{
					new BlockCorner { PosX = 65, PosY = 130, X = 0, Y = 0, Corner1 = 8, Corner2 = -2, Corner3 = 8, Corner4 = 3, CorrectRotate = 90 },
					new BlockCorner { PosX = 65, PosY = 0, X = 0, Y = -1, Corner1 = 7, Corner2 = -1, Corner3 = 4, Corner4 = 7, CorrectRotate = 90 },
					new BlockCorner { PosX = -65, PosY = 0, X = -1, Y = -1, Corner1 = 0, Corner2 = 0, Corner3 = 8, Corner4 = 8, CorrectRotate = 180 },
					new BlockCorner { PosX = -65, PosY = 130, X = -1, Y = 0, Corner1 = -1, Corner2 = 2, Corner3 = 9, Corner4 = -1, CorrectRotate = 90 },
					new BlockCorner { PosX = -195, PosY = 0, X = -2, Y = -1, Corner1 = 7, Corner2 = 5, Corner3 = 5, Corner4 = -1, CorrectRotate = 180 },
					new BlockCorner { PosX = -195, PosY = -130, X = -2, Y = -2, Corner1 = 0, Corner2 = 7, Corner3 = 4, Corner4 = 2, CorrectRotate = 270 },
					new BlockCorner { PosX = 195, PosY = 130, X = 1, Y = 0, Corner1 = 0, Corner2 = 4, Corner3 = -1, Corner4 = -2, CorrectRotate = 180 },
				}
			};
		}
	}
}