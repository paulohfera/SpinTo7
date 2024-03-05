using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Corner
{
	public abstract class Level403
	{
		public static LevelCorner GetLevel()
		{
			return new LevelCorner
			{
				Number = 403,
				MatchsToWin = 13,
				ThreeStarsLimit = 14,
				TwoStarsLimit = 16,
				BlockSizes = 130,
				Blocks = new List<BlockCorner>
				{
					new BlockCorner { PosX = 0, PosY = 130, X = 0, Y = 0, Corner1 = 7, Corner2 = 0, Corner3 = 9, Corner4 = 4, CorrectRotate = 270 },
					new BlockCorner { PosX = 0, PosY = 0, X = 0, Y = -1, Corner1 = 2, Corner2 = -1, Corner3 = -2, Corner4 = 7, CorrectRotate = 180 },
					new BlockCorner { PosX = 0, PosY = -130, X = 0, Y = -2, Corner1 = 5, Corner2 = 6, Corner3 = 3, Corner4 = 8, CorrectRotate = 270 },
					new BlockCorner { PosX = -130, PosY = 0, X = -1, Y = -1, Corner1 = 8, Corner2 = 3, Corner3 = 2, Corner4 = 9, CorrectRotate = 180 },
					new BlockCorner { PosX = 130, PosY = -130, X = 1, Y = -2, Corner1 = 1, Corner2 = 2, Corner3 = 4, Corner4 = 1, CorrectRotate = 90 },
				}
			};
		}
	}
}