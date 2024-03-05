using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Corner
{
	public abstract class Level435
	{
		public static LevelCorner GetLevel()
		{
			return new LevelCorner
			{
				Number = 435,
				MatchsToWin = 56,
				ThreeStarsLimit = 47,
				TwoStarsLimit = 57,
				BlockSizes = 115,
				Blocks = new List<BlockCorner>
				{
					new BlockCorner { PosX = 173, PosY = -115, X = 0, Y = 0, Corner1 = 3, Corner2 = 1, Corner3 = 8, Corner4 = 7, CorrectRotate = 270 },
					new BlockCorner { PosX = 173, PosY = -230, X = 0, Y = -1, Corner1 = 3, Corner2 = -1, Corner3 = 6, Corner4 = 7, CorrectRotate = 90 },
					new BlockCorner { PosX = 58, PosY = -115, X = -1, Y = 0, Corner1 = -1, Corner2 = 7, Corner3 = -2, Corner4 = 0, CorrectRotate = 180 },
					new BlockCorner { PosX = 288, PosY = -230, X = 1, Y = -1, Corner1 = 9, Corner2 = 5, Corner3 = 0, Corner4 = 1, CorrectRotate = 270 },
					new BlockCorner { PosX = 173, PosY = -345, X = 0, Y = -2, Corner1 = 0, Corner2 = 7, Corner3 = 8, Corner4 = 4, CorrectRotate = 270 },
					new BlockCorner { PosX = 58, PosY = -230, X = -1, Y = -1, Corner1 = 8, Corner2 = 4, Corner3 = 9, Corner4 = 0, CorrectRotate = 270 },
					new BlockCorner { PosX = 58, PosY = 0, X = -1, Y = 1, Corner1 = 1, Corner2 = 7, Corner3 = 9, Corner4 = 7, CorrectRotate = 270 },
					new BlockCorner { PosX = -57, PosY = -115, X = -2, Y = 0, Corner1 = -2, Corner2 = 0, Corner3 = 9, Corner4 = 0, CorrectRotate = 90 },
					new BlockCorner { PosX = -172, PosY = -115, X = -3, Y = 0, Corner1 = 9, Corner2 = 1, Corner3 = 9, Corner4 = 7, CorrectRotate = 180 },
					new BlockCorner { PosX = -172, PosY = 0, X = -3, Y = 1, Corner1 = 9, Corner2 = 0, Corner3 = -2, Corner4 = 0, CorrectRotate = 270 },
					new BlockCorner { PosX = -57, PosY = 0, X = -2, Y = 1, Corner1 = 7, Corner2 = -2, Corner3 = 0, Corner4 = -2, CorrectRotate = 90 },
					new BlockCorner { PosX = -172, PosY = 115, X = -3, Y = 2, Corner1 = -2, Corner2 = 7, Corner3 = 7, Corner4 = 3, CorrectRotate = 180 },
					new BlockCorner { PosX = -57, PosY = 115, X = -2, Y = 2, Corner1 = 4, Corner2 = 7, Corner3 = 9, Corner4 = 4, CorrectRotate = 270 },
					new BlockCorner { PosX = -57, PosY = 230, X = -2, Y = 3, Corner1 = -2, Corner2 = 3, Corner3 = 3, Corner4 = 7, CorrectRotate = 270 },
					new BlockCorner { PosX = -172, PosY = 230, X = -3, Y = 3, Corner1 = 0, Corner2 = 4, Corner3 = 0, Corner4 = 3, CorrectRotate = 270 },
					new BlockCorner { PosX = -287, PosY = 230, X = -4, Y = 3, Corner1 = 7, Corner2 = 1, Corner3 = 4, Corner4 = 7, CorrectRotate = 90 },
					new BlockCorner { PosX = -287, PosY = 345, X = -4, Y = 4, Corner1 = 3, Corner2 = 6, Corner3 = 3, Corner4 = -1, CorrectRotate = 180 },
				}
			};
		}
	}
}