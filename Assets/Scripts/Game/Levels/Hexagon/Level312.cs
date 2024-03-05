using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hexagon
{
	public abstract class Level312
	{
		public static LevelHexagon GetLevel()
		{
			return new LevelHexagon
			{
				Number = 312,
				MatchsToWin = 18,
				ThreeStarsLimit = 30,
				TwoStarsLimit = 37,
				BlockWidth = 150,
				BlockHeight = 172,
				Blocks = new List<BlockHexagon>
				{
					new BlockHexagon { PosX = -112, PosY = -65, X = 0, Y = 0, Top1 = 0, Top2 = 0, Right = 7, Bottom1 = 5, Bottom2 = 5, Left = 6, CorrectRotate = 120 },
					new BlockHexagon { PosX = -187, PosY = 65, X = -1, Y = 1, Top1 = 6, Top2 = 2, Right = 7, Bottom1 = 3, Bottom2 = 0, Left = 6, CorrectRotate = 60 },
					new BlockHexagon { PosX = -37, PosY = 65, X = 1, Y = 1, Top1 = 4, Top2 = 0, Right = 5, Bottom1 = 2, Bottom2 = 4, Left = 2, CorrectRotate = 60 },
					new BlockHexagon { PosX = 38, PosY = -65, X = 2, Y = 0, Top1 = 1, Top2 = 1, Right = 2, Bottom1 = 3, Bottom2 = 7, Left = 3, CorrectRotate = 180 },
					new BlockHexagon { PosX = -37, PosY = -195, X = 1, Y = -1, Top1 = 5, Top2 = 0, Right = 6, Bottom1 = 1, Bottom2 = 6, Left = 2, CorrectRotate = 180 },
					new BlockHexagon { PosX = -187, PosY = -195, X = -1, Y = -1, Top1 = 1, Top2 = 4, Right = 3, Bottom1 = 5, Bottom2 = 2, Left = 7, CorrectRotate = 240 },
					new BlockHexagon { PosX = 38, PosY = 195, X = 2, Y = 2, Top1 = 5, Top2 = 3, Right = 0, Bottom1 = 2, Bottom2 = 0, Left = 5, CorrectRotate = 300 },
					new BlockHexagon { PosX = 113, PosY = 65, X = 3, Y = 1, Top1 = 7, Top2 = 0, Right = 5, Bottom1 = 7, Bottom2 = 4, Left = 6, CorrectRotate = 180 },
					new BlockHexagon { PosX = 188, PosY = -65, X = 4, Y = 0, Top1 = 4, Top2 = 0, Right = 7, Bottom1 = 0, Bottom2 = 3, Left = 2, CorrectRotate = 60 },
					new BlockHexagon { PosX = 113, PosY = -195, X = 3, Y = -1, Top1 = 6, Top2 = 5, Right = 6, Bottom1 = 5, Bottom2 = 1, Left = 6, CorrectRotate = 120 },
				}
			};
		}
	}
}