using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hexagon
{
	public abstract class Level322
	{
		public static LevelHexagon GetLevel()
		{
			return new LevelHexagon
			{
				Number = 322,
				MatchsToWin = 22,
				ThreeStarsLimit = 39,
				TwoStarsLimit = 47,
				BlockWidth = 150,
				BlockHeight = 172,
				Blocks = new List<BlockHexagon>
				{
					new BlockHexagon { PosX = 38, PosY = 260, X = 0, Y = 0, Top1 = 1, Top2 = 6, Right = 1, Bottom1 = 7, Bottom2 = 0, Left = 0, CorrectRotate = 0 },
					new BlockHexagon { PosX = -112, PosY = 260, X = -2, Y = 0, Top1 = 5, Top2 = 5, Right = 5, Bottom1 = 3, Bottom2 = 7, Left = 7, CorrectRotate = 120 },
					new BlockHexagon { PosX = -37, PosY = 130, X = -1, Y = -1, Top1 = 3, Top2 = 0, Right = 3, Bottom1 = 2, Bottom2 = 0, Left = 7, CorrectRotate = 240 },
					new BlockHexagon { PosX = -262, PosY = 260, X = -4, Y = 0, Top1 = 1, Top2 = 2, Right = 2, Bottom1 = 0, Bottom2 = 2, Left = 5, CorrectRotate = 0 },
					new BlockHexagon { PosX = 113, PosY = 130, X = 1, Y = -1, Top1 = 5, Top2 = 6, Right = 4, Bottom1 = 0, Bottom2 = 4, Left = 0, CorrectRotate = 180 },
					new BlockHexagon { PosX = 38, PosY = 0, X = 0, Y = -2, Top1 = 1, Top2 = 2, Right = 0, Bottom1 = 6, Bottom2 = 7, Left = 7, CorrectRotate = 300 },
					new BlockHexagon { PosX = 113, PosY = -130, X = 1, Y = -3, Top1 = 5, Top2 = 2, Right = 3, Bottom1 = 0, Bottom2 = 7, Left = 0, CorrectRotate = 240 },
					new BlockHexagon { PosX = -37, PosY = -130, X = -1, Y = -3, Top1 = 4, Top2 = 7, Right = 1, Bottom1 = 7, Bottom2 = 7, Left = 6, CorrectRotate = 60 },
					new BlockHexagon { PosX = -112, PosY = 0, X = -2, Y = -2, Top1 = 0, Top2 = 0, Right = 6, Bottom1 = 4, Bottom2 = 5, Left = 4, CorrectRotate = 240 },
					new BlockHexagon { PosX = 263, PosY = -130, X = 3, Y = -3, Top1 = 2, Top2 = 3, Right = 6, Bottom1 = 5, Bottom2 = 4, Left = 6, CorrectRotate = 60 },
					new BlockHexagon { PosX = 188, PosY = -260, X = 2, Y = -4, Top1 = 2, Top2 = 5, Right = 1, Bottom1 = 6, Bottom2 = 2, Left = 6, CorrectRotate = 60 },
					new BlockHexagon { PosX = 38, PosY = -260, X = 0, Y = -4, Top1 = 5, Top2 = 5, Right = 3, Bottom1 = 4, Bottom2 = 0, Left = 4, CorrectRotate = 240 },
					new BlockHexagon { PosX = -112, PosY = -260, X = -2, Y = -4, Top1 = 2, Top2 = 2, Right = 6, Bottom1 = 1, Bottom2 = 1, Left = 3, CorrectRotate = 180 },
				}
			};
		}
	}
}