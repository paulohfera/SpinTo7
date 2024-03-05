using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hexagon
{
	public abstract class Level320
	{
		public static LevelHexagon GetLevel()
		{
			return new LevelHexagon
			{
				Number = 320,
				MatchsToWin = 22,
				ThreeStarsLimit = 45,
				TwoStarsLimit = 54,
				BlockWidth = 150,
				BlockHeight = 172,
				Blocks = new List<BlockHexagon>
				{
					new BlockHexagon { PosX = 188, PosY = 65, X = 0, Y = 0, Top1 = 5, Top2 = 0, Right = 2, Bottom1 = 5, Bottom2 = 7, Left = 2, CorrectRotate = 60 },
					new BlockHexagon { PosX = 113, PosY = 195, X = -1, Y = 1, Top1 = 3, Top2 = 7, Right = 6, Bottom1 = 7, Bottom2 = 0, Left = 1, CorrectRotate = 240 },
					new BlockHexagon { PosX = 38, PosY = 65, X = -2, Y = 0, Top1 = 2, Top2 = 2, Right = 6, Bottom1 = 5, Bottom2 = 2, Left = 1, CorrectRotate = 240 },
					new BlockHexagon { PosX = -37, PosY = 195, X = -3, Y = 1, Top1 = 0, Top2 = 5, Right = 4, Bottom1 = 2, Bottom2 = 1, Left = 7, CorrectRotate = 240 },
					new BlockHexagon { PosX = -37, PosY = -65, X = -3, Y = -1, Top1 = 0, Top2 = 3, Right = 4, Bottom1 = 0, Bottom2 = 6, Left = 1, CorrectRotate = 240 },
					new BlockHexagon { PosX = -112, PosY = 65, X = -4, Y = 0, Top1 = 1, Top2 = 0, Right = 2, Bottom1 = 2, Bottom2 = 3, Left = 2, CorrectRotate = 180 },
					new BlockHexagon { PosX = -112, PosY = 325, X = -4, Y = 2, Top1 = 4, Top2 = 6, Right = 4, Bottom1 = 1, Bottom2 = 4, Left = 2, CorrectRotate = 240 },
					new BlockHexagon { PosX = 113, PosY = -65, X = -1, Y = -1, Top1 = 7, Top2 = 5, Right = 5, Bottom1 = 5, Bottom2 = 0, Left = 7, CorrectRotate = 60 },
					new BlockHexagon { PosX = -187, PosY = 195, X = -5, Y = 1, Top1 = 0, Top2 = 2, Right = 3, Bottom1 = 3, Bottom2 = 5, Left = 5, CorrectRotate = 120 },
					new BlockHexagon { PosX = 38, PosY = -195, X = -2, Y = -2, Top1 = 6, Top2 = 5, Right = 1, Bottom1 = 0, Bottom2 = 4, Left = 0, CorrectRotate = 240 },
					new BlockHexagon { PosX = -112, PosY = -195, X = -4, Y = -2, Top1 = 7, Top2 = 0, Right = 5, Bottom1 = 6, Bottom2 = 4, Left = 3, CorrectRotate = 240 },
					new BlockHexagon { PosX = -37, PosY = -325, X = -3, Y = -3, Top1 = 0, Top2 = 7, Right = 7, Bottom1 = 6, Bottom2 = 1, Left = 7, CorrectRotate = 120 },
				}
			};
		}
	}
}