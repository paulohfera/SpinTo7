using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Corner
{
	public abstract class Level404
	{
		public static LevelCorner GetLevel()
		{
			return new LevelCorner
			{
				Number = 404,
				MatchsToWin = 18,
				ThreeStarsLimit = 15,
				TwoStarsLimit = 18,
				BlockSizes = 130,
				Blocks = new List<BlockCorner>
				{
					new BlockCorner { PosX = 130, PosY = 130, X = 0, Y = 0, Corner1 = 5, Corner2 = 1, Corner3 = 9, Corner4 = 0, CorrectRotate = 90 },
					new BlockCorner { PosX = 130, PosY = 0, X = 0, Y = -1, Corner1 = 6, Corner2 = 2, Corner3 = 7, Corner4 = -2, CorrectRotate = 90 },
					new BlockCorner { PosX = 130, PosY = -130, X = 0, Y = -2, Corner1 = 9, Corner2 = 7, Corner3 = 6, Corner4 = 1, CorrectRotate = 270 },
					new BlockCorner { PosX = 0, PosY = -130, X = -1, Y = -2, Corner1 = 6, Corner2 = 1, Corner3 = -2, Corner4 = 7, CorrectRotate = 270 },
					new BlockCorner { PosX = 0, PosY = 0, X = -1, Y = -1, Corner1 = 0, Corner2 = 4, Corner3 = 5, Corner4 = 1, CorrectRotate = 90 },
					new BlockCorner { PosX = -130, PosY = -130, X = -2, Y = -2, Corner1 = 0, Corner2 = 9, Corner3 = -1, Corner4 = 7, CorrectRotate = 270 },
				}
			};
		}
	}
}