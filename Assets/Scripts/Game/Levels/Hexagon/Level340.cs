using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hexagon
{
	public abstract class Level340
	{
		public static LevelHexagon GetLevel()
		{
			return new LevelHexagon
			{
				Number = 340,
				MatchsToWin = 36,
				ThreeStarsLimit = 54,
				TwoStarsLimit = 66,
				BlockWidth = 150,
				BlockHeight = 172,
				Blocks = new List<BlockHexagon>
				{
					new BlockHexagon { PosX = 188, PosY = 390, X = 0, Y = 0, Top1 = 3, Top2 = 3, Right = 3, Bottom1 = 2, Bottom2 = 7, Left = 0, CorrectRotate = 0 },
					new BlockHexagon { PosX = 263f, PosY = 260, X = 1, Y = -1, Top1 = 7, Top2 = 5, Right = 6, Bottom1 = 4, Bottom2 = 5, Left = 1, CorrectRotate = 240 },
					new BlockHexagon { PosX = 188, PosY = 130, X = 0, Y = -2, Top1 = 0, Top2 = 4, Right = 0, Bottom1 = 1, Bottom2 = 7, Left = 6, CorrectRotate = 120 },
					new BlockHexagon { PosX = 113f, PosY = 260, X = -1, Y = -1, Top1 = 3, Top2 = 7, Right = 7, Bottom1 = 2, Bottom2 = 7, Left = 0, CorrectRotate = 240 },
					new BlockHexagon { PosX = 263f, PosY = 0, X = 1, Y = -3, Top1 = 2, Top2 = 6, Right = 1, Bottom1 = 4, Bottom2 = 2, Left = 2, CorrectRotate = 120 },
					new BlockHexagon { PosX = 188, PosY = -130, X = 0, Y = -4, Top1 = 1, Top2 = 1, Right = 5, Bottom1 = 1, Bottom2 = 7, Left = 1, CorrectRotate = 60 },
					new BlockHexagon { PosX = 113f, PosY = 0, X = -1, Y = -3, Top1 = 7, Top2 = 1, Right = 6, Bottom1 = 4, Bottom2 = 3, Left = 2, CorrectRotate = 300 },
					new BlockHexagon { PosX = 263f, PosY = -260, X = 1, Y = -5, Top1 = 4, Top2 = 0, Right = 0, Bottom1 = 1, Bottom2 = 1, Left = 0, CorrectRotate = 120 },
					new BlockHexagon { PosX = 113f, PosY = -260, X = -1, Y = -5, Top1 = 6, Top2 = 7, Right = 6, Bottom1 = 7, Bottom2 = 1, Left = 3, CorrectRotate = 60 },
					new BlockHexagon { PosX = -37f, PosY = -260, X = -3, Y = -5, Top1 = 6, Top2 = 5, Right = 1, Bottom1 = 4, Bottom2 = 4, Left = 4, CorrectRotate = 0 },
					new BlockHexagon { PosX = -112, PosY = -130, X = -4, Y = -4, Top1 = 7, Top2 = 4, Right = 3, Bottom1 = 6, Bottom2 = 1, Left = 0, CorrectRotate = 60 },
					new BlockHexagon { PosX = 38, PosY = -130, X = -2, Y = -4, Top1 = 3, Top2 = 6, Right = 0, Bottom1 = 2, Bottom2 = 1, Left = 1, CorrectRotate = 300 },
					new BlockHexagon { PosX = -187f, PosY = 0, X = -5, Y = -3, Top1 = 4, Top2 = 5, Right = 3, Bottom1 = 0, Bottom2 = 7, Left = 7, CorrectRotate = 300 },
					new BlockHexagon { PosX = -187f, PosY = -260, X = -5, Y = -5, Top1 = 2, Top2 = 5, Right = 7, Bottom1 = 3, Bottom2 = 6, Left = 5, CorrectRotate = 60 },
					new BlockHexagon { PosX = -37f, PosY = 0, X = -3, Y = -3, Top1 = 6, Top2 = 1, Right = 4, Bottom1 = 6, Bottom2 = 4, Left = 2, CorrectRotate = 0 },
					new BlockHexagon { PosX = -262, PosY = 130, X = -6, Y = -2, Top1 = 6, Top2 = 5, Right = 0, Bottom1 = 5, Bottom2 = 2, Left = 4, CorrectRotate = 300 },
					new BlockHexagon { PosX = -112, PosY = 130, X = -4, Y = -2, Top1 = 3, Top2 = 2, Right = 5, Bottom1 = 6, Bottom2 = 5, Left = 1, CorrectRotate = 120 },
					new BlockHexagon { PosX = -262, PosY = -130, X = -6, Y = -4, Top1 = 4, Top2 = 6, Right = 3, Bottom1 = 7, Bottom2 = 0, Left = 2, CorrectRotate = 120 },
					new BlockHexagon { PosX = -112, PosY = -390, X = -4, Y = -6, Top1 = 5, Top2 = 2, Right = 1, Bottom1 = 1, Bottom2 = 3, Left = 0, CorrectRotate = 180 },
				}
			};
		}
	}
}