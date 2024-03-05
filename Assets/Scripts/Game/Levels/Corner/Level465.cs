using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Corner
{
	public abstract class Level465
	{
		public static LevelCorner GetLevel()
		{
			return new LevelCorner
			{
				Number = 465,
				MatchsToWin = 87,
				ThreeStarsLimit = 59,
				TwoStarsLimit = 72,
				BlockSizes = 110,
				Blocks = new List<BlockCorner>
				{
					new BlockCorner { PosX = 0, PosY = 220, X = 0, Y = 0, Corner1 = -1, Corner2 = 1, Corner3 = -1, Corner4 = -2, CorrectRotate = 180 },
					new BlockCorner { PosX = 110, PosY = 220, X = 1, Y = 0, Corner1 = 1, Corner2 = 8, Corner3 = 9, Corner4 = 7, CorrectRotate = 180 },
					new BlockCorner { PosX = 0, PosY = 110, X = 0, Y = -1, Corner1 = 8, Corner2 = 3, Corner3 = -2, Corner4 = 6, CorrectRotate = 270 },
					new BlockCorner { PosX = -110, PosY = 220, X = -1, Y = 0, Corner1 = 8, Corner2 = 9, Corner3 = 8, Corner4 = 6, CorrectRotate = 90 },
					new BlockCorner { PosX = 110, PosY = 330, X = 1, Y = 1, Corner1 = 0, Corner2 = -2, Corner3 = -2, Corner4 = 4, CorrectRotate = 180 },
					new BlockCorner { PosX = 220, PosY = 220, X = 2, Y = 0, Corner1 = 6, Corner2 = 0, Corner3 = 1, Corner4 = 4, CorrectRotate = 90 },
					new BlockCorner { PosX = 110, PosY = 110, X = 1, Y = -1, Corner1 = 6, Corner2 = 6, Corner3 = 4, Corner4 = -1, CorrectRotate = 270 },
					new BlockCorner { PosX = 0, PosY = 0, X = 0, Y = -2, Corner1 = 5, Corner2 = 9, Corner3 = 4, Corner4 = 1, CorrectRotate = 90 },
					new BlockCorner { PosX = -110, PosY = 110, X = -1, Y = -1, Corner1 = 9, Corner2 = 3, Corner3 = -1, Corner4 = 1, CorrectRotate = 180 },
					new BlockCorner { PosX = -110, PosY = 330, X = -1, Y = 1, Corner1 = -1, Corner2 = -2, Corner3 = 4, Corner4 = 7, CorrectRotate = 180 },
					new BlockCorner { PosX = -220, PosY = 220, X = -2, Y = 0, Corner1 = 2, Corner2 = 0, Corner3 = -2, Corner4 = -1, CorrectRotate = 90 },
					new BlockCorner { PosX = 110, PosY = 440, X = 1, Y = 2, Corner1 = 3, Corner2 = 9, Corner3 = 0, Corner4 = -2, CorrectRotate = 180 },
					new BlockCorner { PosX = 220, PosY = 330, X = 2, Y = 1, Corner1 = 3, Corner2 = 6, Corner3 = 7, Corner4 = 3, CorrectRotate = 270 },
					new BlockCorner { PosX = 0, PosY = 330, X = 0, Y = 1, Corner1 = 9, Corner2 = 8, Corner3 = 0, Corner4 = 9, CorrectRotate = 180 },
					new BlockCorner { PosX = 220, PosY = 110, X = 2, Y = -1, Corner1 = 3, Corner2 = 0, Corner3 = 1, Corner4 = 1, CorrectRotate = 270 },
					new BlockCorner { PosX = 110, PosY = 0, X = 1, Y = -2, Corner1 = 2, Corner2 = 6, Corner3 = 3, Corner4 = 1, CorrectRotate = 180 },
					new BlockCorner { PosX = 0, PosY = -110, X = 0, Y = -3, Corner1 = 9, Corner2 = 4, Corner3 = 2, Corner4 = 6, CorrectRotate = 180 },
					new BlockCorner { PosX = -110, PosY = 0, X = -1, Y = -2, Corner1 = 2, Corner2 = 9, Corner3 = 4, Corner4 = -2, CorrectRotate = 180 },
					new BlockCorner { PosX = -110, PosY = -110, X = -1, Y = -3, Corner1 = 7, Corner2 = -2, Corner3 = 5, Corner4 = 3, CorrectRotate = 90 },
					new BlockCorner { PosX = -220, PosY = 0, X = -2, Y = -2, Corner1 = 9, Corner2 = 6, Corner3 = 3, Corner4 = -2, CorrectRotate = 90 },
					new BlockCorner { PosX = -110, PosY = -220, X = -1, Y = -4, Corner1 = 2, Corner2 = -2, Corner3 = 0, Corner4 = 4, CorrectRotate = 180 },
					new BlockCorner { PosX = -110, PosY = -330, X = -1, Y = -5, Corner1 = 5, Corner2 = -2, Corner3 = 9, Corner4 = 9, CorrectRotate = 270 },
					new BlockCorner { PosX = -220, PosY = -220, X = -2, Y = -4, Corner1 = 7, Corner2 = 4, Corner3 = 7, Corner4 = 9, CorrectRotate = 90 },
					new BlockCorner { PosX = 0, PosY = -330, X = 0, Y = -5, Corner1 = 6, Corner2 = 9, Corner3 = 2, Corner4 = 4, CorrectRotate = 180 },
					new BlockCorner { PosX = -110, PosY = -440, X = -1, Y = -6, Corner1 = 6, Corner2 = 3, Corner3 = -2, Corner4 = 9, CorrectRotate = 180 },
					new BlockCorner { PosX = -220, PosY = -330, X = -2, Y = -5, Corner1 = 1, Corner2 = 0, Corner3 = -2, Corner4 = -2, CorrectRotate = 90 },
				}
			};
		}
	}
}