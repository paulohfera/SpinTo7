using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hexagon
{
	public abstract class Level330
	{
		public static LevelHexagon GetLevel()
		{
			return new LevelHexagon
			{
				Number = 330,
				MatchsToWin = 29,
				ThreeStarsLimit = 53,
				TwoStarsLimit = 64,
				BlockWidth = 150,
				BlockHeight = 172,
				Blocks = new List<BlockHexagon>
				{
					new BlockHexagon { PosX = -112, PosY = -195, X = 0, Y = 0, Top1 = 2, Top2 = 2, Right = 6, Bottom1 = 2, Bottom2 = 1, Left = 3, CorrectRotate = 120 },
					new BlockHexagon { PosX = -37, PosY = -325, X = 1, Y = -1, Top1 = 7, Top2 = 7, Right = 7, Bottom1 = 4, Bottom2 = 3, Left = 7, CorrectRotate = 180 },
					new BlockHexagon { PosX = -187, PosY = -325, X = -1, Y = -1, Top1 = 5, Top2 = 7, Right = 2, Bottom1 = 3, Bottom2 = 5, Left = 0, CorrectRotate = 180 },
					new BlockHexagon { PosX = -262, PosY = -195, X = -2, Y = 0, Top1 = 7, Top2 = 1, Right = 1, Bottom1 = 3, Bottom2 = 5, Left = 4, CorrectRotate = 120 },
					new BlockHexagon { PosX = 38, PosY = -195, X = 2, Y = 0, Top1 = 7, Top2 = 5, Right = 1, Bottom1 = 4, Bottom2 = 6, Left = 6, CorrectRotate = 300 },
					new BlockHexagon { PosX = -187, PosY = -65, X = -1, Y = 1, Top1 = 1, Top2 = 4, Right = 3, Bottom1 = 7, Bottom2 = 3, Left = 3, CorrectRotate = 180 },
					new BlockHexagon { PosX = -37, PosY = -65, X = 1, Y = 1, Top1 = 2, Top2 = 1, Right = 5, Bottom1 = 4, Bottom2 = 2, Left = 0, CorrectRotate = 240 },
					new BlockHexagon { PosX = 38, PosY = 65, X = 2, Y = 2, Top1 = 6, Top2 = 7, Right = 0, Bottom1 = 6, Bottom2 = 1, Left = 4, CorrectRotate = 180 },
					new BlockHexagon { PosX = 113, PosY = -65, X = 3, Y = 1, Top1 = 3, Top2 = 0, Right = 0, Bottom1 = 5, Bottom2 = 1, Left = 1, CorrectRotate = 240 },
					new BlockHexagon { PosX = 113, PosY = 195, X = 3, Y = 3, Top1 = 6, Top2 = 7, Right = 0, Bottom1 = 5, Bottom2 = 5, Left = 6, CorrectRotate = 60 },
					new BlockHexagon { PosX = 188, PosY = 65, X = 4, Y = 2, Top1 = 7, Top2 = 7, Right = 3, Bottom1 = 6, Bottom2 = 3, Left = 2, CorrectRotate = 300 },
					new BlockHexagon { PosX = -112, PosY = 65, X = 0, Y = 2, Top1 = 5, Top2 = 4, Right = 2, Bottom1 = 5, Bottom2 = 0, Left = 7, CorrectRotate = 180 },
					new BlockHexagon { PosX = 38, PosY = 325, X = 2, Y = 4, Top1 = 6, Top2 = 3, Right = 7, Bottom1 = 2, Bottom2 = 0, Left = 1, CorrectRotate = 60 },
					new BlockHexagon { PosX = 188, PosY = 325, X = 4, Y = 4, Top1 = 1, Top2 = 7, Right = 5, Bottom1 = 0, Bottom2 = 7, Left = 6, CorrectRotate = 180 },
					new BlockHexagon { PosX = 263, PosY = 195, X = 5, Y = 3, Top1 = 0, Top2 = 2, Right = 6, Bottom1 = 7, Bottom2 = 7, Left = 6, CorrectRotate = 120 },
				}
			};
		}
	}
}