using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Corner
{
	public abstract class Level434
	{
		public static LevelCorner GetLevel()
		{
			return new LevelCorner
			{
				Number = 434,
				MatchsToWin = 57,
				ThreeStarsLimit = 45,
				TwoStarsLimit = 54,
				BlockSizes = 130,
				Blocks = new List<BlockCorner>
				{
					new BlockCorner { PosX = 260, PosY = 195, X = 0, Y = 0, Corner1 = 1, Corner2 = 8, Corner3 = 5, Corner4 = 2, CorrectRotate = 180 },
					new BlockCorner { PosX = 260, PosY = 65, X = 0, Y = -1, Corner1 = 7, Corner2 = -1, Corner3 = 6, Corner4 = -2, CorrectRotate = 90 },
					new BlockCorner { PosX = 130, PosY = 195, X = -1, Y = 0, Corner1 = -1, Corner2 = 5, Corner3 = 0, Corner4 = 2, CorrectRotate = 180 },
					new BlockCorner { PosX = 130, PosY = 65, X = -1, Y = -1, Corner1 = 0, Corner2 = 1, Corner3 = 2, Corner4 = 8, CorrectRotate = 180 },
					new BlockCorner { PosX = 130, PosY = -65, X = -1, Y = -2, Corner1 = 7, Corner2 = 7, Corner3 = 3, Corner4 = 6, CorrectRotate = 270 },
					new BlockCorner { PosX = 130, PosY = -195, X = -1, Y = -3, Corner1 = 0, Corner2 = 6, Corner3 = 1, Corner4 = 4, CorrectRotate = 270 },
					new BlockCorner { PosX = 0, PosY = -65, X = -2, Y = -2, Corner1 = 1, Corner2 = 4, Corner3 = 4, Corner4 = 0, CorrectRotate = 270 },
					new BlockCorner { PosX = -130, PosY = -65, X = -3, Y = -2, Corner1 = 7, Corner2 = 3, Corner3 = 5, Corner4 = 9, CorrectRotate = 270 },
					new BlockCorner { PosX = -130, PosY = 65, X = -3, Y = -1, Corner1 = 0, Corner2 = -2, Corner3 = 7, Corner4 = -2, CorrectRotate = 180 },
					new BlockCorner { PosX = -130, PosY = -195, X = -3, Y = -3, Corner1 = 4, Corner2 = 0, Corner3 = 8, Corner4 = 2, CorrectRotate = 270 },
					new BlockCorner { PosX = -260, PosY = -65, X = -4, Y = -2, Corner1 = -2, Corner2 = 2, Corner3 = 9, Corner4 = -2, CorrectRotate = 270 },
					new BlockCorner { PosX = -130, PosY = 195, X = -3, Y = 0, Corner1 = 0, Corner2 = 0, Corner3 = 4, Corner4 = 9, CorrectRotate = 90 },
					new BlockCorner { PosX = 0, PosY = 65, X = -2, Y = -1, Corner1 = 7, Corner2 = 9, Corner3 = 5, Corner4 = 6, CorrectRotate = 90 },
					new BlockCorner { PosX = -130, PosY = -325, X = -3, Y = -4, Corner1 = 8, Corner2 = 7, Corner3 = -1, Corner4 = 7, CorrectRotate = 180 },
					new BlockCorner { PosX = -260, PosY = -195, X = -4, Y = -3, Corner1 = 3, Corner2 = -2, Corner3 = 5, Corner4 = -1, CorrectRotate = 90 },
					new BlockCorner { PosX = -260, PosY = 65, X = -4, Y = -1, Corner1 = 9, Corner2 = 9, Corner3 = -1, Corner4 = 0, CorrectRotate = 180 },
					new BlockCorner { PosX = -130, PosY = 325, X = -3, Y = 1, Corner1 = -2, Corner2 = 3, Corner3 = 7, Corner4 = 6, CorrectRotate = 270 },
				}
			};
		}
	}
}