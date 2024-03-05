using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hexagon
{
	public abstract class Level363
	{
		public static LevelHexagon GetLevel()
		{
			return new LevelHexagon
			{
				Number = 363,
				MatchsToWin = 57,
				ThreeStarsLimit = 95,
				TwoStarsLimit = 115,
				BlockWidth = 141,
				BlockHeight = 162,
				Blocks = new List<BlockHexagon>
				{
					new BlockHexagon { PosX = 141f, PosY = -183f, X = 0, Y = 0, Top1 = 4, Top2 = 1, Right = 3, Bottom1 = 2, Bottom2 = 7, Left = 5, CorrectRotate = 300 },
					new BlockHexagon { PosX = 71f, PosY = -61f, X = -1, Y = 1, Top1 = 3, Top2 = 2, Right = 7, Bottom1 = 4, Bottom2 = 3, Left = 1, CorrectRotate = 240 },
					new BlockHexagon { PosX = 211f, PosY = -61f, X = 1, Y = 1, Top1 = 3, Top2 = 4, Right = 7, Bottom1 = 3, Bottom2 = 1, Left = 7, CorrectRotate = 120 },
					new BlockHexagon { PosX = 281f, PosY = -183f, X = 2, Y = 0, Top1 = 7, Top2 = 3, Right = 6, Bottom1 = 0, Bottom2 = 5, Left = 6, CorrectRotate = 180 },
					new BlockHexagon { PosX = 211f, PosY = -305f, X = 1, Y = -1, Top1 = 3, Top2 = 6, Right = 2, Bottom1 = 4, Bottom2 = 4, Left = 3, CorrectRotate = 180 },
					new BlockHexagon { PosX = 71f, PosY = -305f, X = -1, Y = -1, Top1 = 5, Top2 = 5, Right = 1, Bottom1 = 2, Bottom2 = 0, Left = 1, CorrectRotate = 300 },
					new BlockHexagon { PosX = 1f, PosY = -183f, X = -2, Y = 0, Top1 = 6, Top2 = 0, Right = 0, Bottom1 = 0, Bottom2 = 6, Left = 4, CorrectRotate = 60 },
					new BlockHexagon { PosX = 1f, PosY = 61f, X = -2, Y = 2, Top1 = 4, Top2 = 1, Right = 7, Bottom1 = 1, Bottom2 = 4, Left = 3, CorrectRotate = 180 },
					new BlockHexagon { PosX = -69f, PosY = -61f, X = -3, Y = 1, Top1 = 3, Top2 = 6, Right = 3, Bottom1 = 7, Bottom2 = 2, Left = 7, CorrectRotate = 0 },
					new BlockHexagon { PosX = -139f, PosY = -183f, X = -4, Y = 0, Top1 = 5, Top2 = 1, Right = 3, Bottom1 = 0, Bottom2 = 2, Left = 0, CorrectRotate = 300 },
					new BlockHexagon { PosX = -69f, PosY = 183f, X = -3, Y = 3, Top1 = 6, Top2 = 6, Right = 3, Bottom1 = 4, Bottom2 = 5, Left = 0, CorrectRotate = 180 },
					new BlockHexagon { PosX = 71f, PosY = 183f, X = -1, Y = 3, Top1 = 3, Top2 = 7, Right = 0, Bottom1 = 1, Bottom2 = 2, Left = 7, CorrectRotate = 120 },
					new BlockHexagon { PosX = 141f, PosY = 61f, X = 0, Y = 2, Top1 = 4, Top2 = 0, Right = 2, Bottom1 = 0, Bottom2 = 0, Left = 6, CorrectRotate = 60 },
					new BlockHexagon { PosX = -209f, PosY = -61f, X = -5, Y = 1, Top1 = 7, Top2 = 7, Right = 3, Bottom1 = 4, Bottom2 = 7, Left = 0, CorrectRotate = 180 },
					new BlockHexagon { PosX = -69f, PosY = -305f, X = -3, Y = -1, Top1 = 3, Top2 = 7, Right = 0, Bottom1 = 3, Bottom2 = 2, Left = 4, CorrectRotate = 300 },
					new BlockHexagon { PosX = -139f, PosY = 305f, X = -4, Y = 4, Top1 = 1, Top2 = 0, Right = 3, Bottom1 = 3, Bottom2 = 1, Left = 2, CorrectRotate = 300 },
					new BlockHexagon { PosX = 1f, PosY = 305f, X = -2, Y = 4, Top1 = 2, Top2 = 7, Right = 4, Bottom1 = 5, Bottom2 = 4, Left = 7, CorrectRotate = 120 },
					new BlockHexagon { PosX = -139f, PosY = 61f, X = -4, Y = 2, Top1 = 4, Top2 = 0, Right = 5, Bottom1 = 1, Bottom2 = 1, Left = 0, CorrectRotate = 180 },
					new BlockHexagon { PosX = 211f, PosY = 183f, X = 1, Y = 3, Top1 = 0, Top2 = 5, Right = 4, Bottom1 = 5, Bottom2 = 5, Left = 1, CorrectRotate = 300 },
					new BlockHexagon { PosX = 281f, PosY = 61f, X = 2, Y = 2, Top1 = 4, Top2 = 1, Right = 5, Bottom1 = 4, Bottom2 = 7, Left = 3, CorrectRotate = 300 },
					new BlockHexagon { PosX = -279f, PosY = -183f, X = -6, Y = 0, Top1 = 1, Top2 = 2, Right = 3, Bottom1 = 0, Bottom2 = 5, Left = 5, CorrectRotate = 120 },
					new BlockHexagon { PosX = 1f, PosY = -427f, X = -2, Y = -2, Top1 = 5, Top2 = 6, Right = 7, Bottom1 = 5, Bottom2 = 4, Left = 0, CorrectRotate = 120 },
					new BlockHexagon { PosX = -209f, PosY = -305f, X = -5, Y = -1, Top1 = 4, Top2 = 3, Right = 1, Bottom1 = 2, Bottom2 = 7, Left = 5, CorrectRotate = 180 },
					new BlockHexagon { PosX = -69f, PosY = 427f, X = -3, Y = 5, Top1 = 3, Top2 = 6, Right = 6, Bottom1 = 3, Bottom2 = 0, Left = 0, CorrectRotate = 180 },
					new BlockHexagon { PosX = -209f, PosY = 183f, X = -5, Y = 3, Top1 = 6, Top2 = 5, Right = 6, Bottom1 = 2, Bottom2 = 4, Left = 4, CorrectRotate = 180 },
					new BlockHexagon { PosX = 71f, PosY = 427f, X = -1, Y = 5, Top1 = 7, Top2 = 3, Right = 2, Bottom1 = 3, Bottom2 = 3, Left = 2, CorrectRotate = 60 },
				}
			};
		}
	}
}