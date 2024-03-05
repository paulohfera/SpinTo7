using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Corner
{
	public abstract class Level401
	{
		public static LevelCorner GetLevel()
		{
			return new LevelCorner
			{
				Number = 401,
				MatchsToWin = 12,
				ThreeStarsLimit = 15,
				TwoStarsLimit = 18,
				BlockSizes = 130,
				Blocks = new List<BlockCorner>
				{
					new BlockCorner { PosX = 0, PosY = 0, X = 0, Y = 0, Corner1 = 8, Corner2 = 2, Corner3 = -1, Corner4 = 6, CorrectRotate = 180 },
					new BlockCorner { PosX = 0, PosY = 130, X = 0, Y = 1, Corner1 = 1, Corner2 = 1, Corner3 = 8, Corner4 = 5, CorrectRotate = 270 },
					new BlockCorner { PosX = 130, PosY = 0, X = 1, Y = 0, Corner1 = -1, Corner2 = 1, Corner3 = 1, Corner4 = 6, CorrectRotate = 90 },
					new BlockCorner { PosX = 0, PosY = -130, X = 0, Y = -1, Corner1 = -1, Corner2 = 2, Corner3 = 2, Corner4 = 5, CorrectRotate = 270 },
					new BlockCorner { PosX = -130, PosY = 0, X = -1, Y = 0, Corner1 = 8, Corner2 = 5, Corner3 = -1, Corner4 = 8, CorrectRotate = 270 },
				}
			};
		}
	}
}