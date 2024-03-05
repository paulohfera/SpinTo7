using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hexagon
{
	public abstract class Level316
	{
		public static LevelHexagon GetLevel()
		{
			return new LevelHexagon
			{
				Number = 316,
				MatchsToWin = 19,
				ThreeStarsLimit = 35,
				TwoStarsLimit = 43,
				BlockWidth = 141,
				BlockHeight = 162,
				Blocks = new List<BlockHexagon>
				{
					new BlockHexagon { PosX = 141, PosY = 183, X = 0, Y = 0, Top1 = 7, Top2 = 0, Right = 3, Bottom1 = 2, Bottom2 = 7, Left = 7, CorrectRotate = 180 },
					new BlockHexagon { PosX = 211, PosY = 61, X = 1, Y = -1, Top1 = 6, Top2 = 0, Right = 5, Bottom1 = 4, Bottom2 = 5, Left = 3, CorrectRotate = 60 },
					new BlockHexagon { PosX = 71, PosY = 61, X = -1, Y = -1, Top1 = 1, Top2 = 2, Right = 7, Bottom1 = 2, Bottom2 = 4, Left = 7, CorrectRotate = 240 },
					new BlockHexagon { PosX = 1, PosY = 183, X = -2, Y = 0, Top1 = 1, Top2 = 7, Right = 3, Bottom1 = 4, Bottom2 = 3, Left = 1, CorrectRotate = 60 },
					new BlockHexagon { PosX = 281, PosY = 183, X = 2, Y = 0, Top1 = 7, Top2 = 2, Right = 0, Bottom1 = 5, Bottom2 = 1, Left = 1, CorrectRotate = 180 },
					new BlockHexagon { PosX = 281, PosY = -61, X = 2, Y = -2, Top1 = 2, Top2 = 5, Right = 4, Bottom1 = 1, Bottom2 = 3, Left = 5, CorrectRotate = 0 },
					new BlockHexagon { PosX = 141, PosY = -61, X = 0, Y = -2, Top1 = 7, Top2 = 5, Right = 4, Bottom1 = 2, Bottom2 = 3, Left = 4, CorrectRotate = 60 },
					new BlockHexagon { PosX = 1, PosY = -61, X = -2, Y = -2, Top1 = 6, Top2 = 6, Right = 0, Bottom1 = 0, Bottom2 = 3, Left = 2, CorrectRotate = 60 },
					new BlockHexagon { PosX = 71, PosY = -183, X = -1, Y = -3, Top1 = 6, Top2 = 7, Right = 7, Bottom1 = 4, Bottom2 = 3, Left = 0, CorrectRotate = 180 },
					new BlockHexagon { PosX = -139, PosY = -61, X = -4, Y = -2, Top1 = 6, Top2 = 0, Right = 7, Bottom1 = 7, Bottom2 = 1, Left = 4, CorrectRotate = 120 },
					new BlockHexagon { PosX = -209, PosY = -183, X = -5, Y = -3, Top1 = 1, Top2 = 3, Right = 4, Bottom1 = 1, Bottom2 = 5, Left = 3, CorrectRotate = 300 },
					new BlockHexagon { PosX = -279, PosY = -61, X = -6, Y = -2, Top1 = 7, Top2 = 7, Right = 4, Bottom1 = 6, Bottom2 = 5, Left = 7, CorrectRotate = 300 },
				}
			};
		}
	}
}