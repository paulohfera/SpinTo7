using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hexagon
{
	public abstract class Level390
	{
		public static LevelHexagon GetLevel()
		{
			return new LevelHexagon
			{
				Number = 390,
				MatchsToWin = 65,
				ThreeStarsLimit = 112,
				TwoStarsLimit = 135,
				BlockWidth = 141,
				BlockHeight = 162,
				Blocks = new List<BlockHexagon>
				{
					new BlockHexagon { PosX = 211.5f, PosY = -61f, X = 0, Y = 0, Top1 = 6, Top2 = 1, Right = 7, Bottom1 = 5, Bottom2 = 5, Left = 1, CorrectRotate = 180 },
					new BlockHexagon { PosX = 141.5f, PosY = -183f, X = -1, Y = -1, Top1 = 7, Top2 = 7, Right = 2, Bottom1 = 1, Bottom2 = 5, Left = 6, CorrectRotate = 240 },
					new BlockHexagon { PosX = 71.5f, PosY = -61f, X = -2, Y = 0, Top1 = 1, Top2 = 0, Right = 2, Bottom1 = 5, Bottom2 = 2, Left = 5, CorrectRotate = 300 },
					new BlockHexagon { PosX = 1.5f, PosY = -183f, X = -3, Y = -1, Top1 = 2, Top2 = 7, Right = 0, Bottom1 = 3, Bottom2 = 2, Left = 6, CorrectRotate = 180 },
					new BlockHexagon { PosX = -68.5f, PosY = -61f, X = -4, Y = 0, Top1 = 0, Top2 = 5, Right = 4, Bottom1 = 7, Bottom2 = 7, Left = 0, CorrectRotate = 300 },
					new BlockHexagon { PosX = -68.5f, PosY = -305f, X = -4, Y = -2, Top1 = 2, Top2 = 7, Right = 5, Bottom1 = 1, Bottom2 = 0, Left = 0, CorrectRotate = 180 },
					new BlockHexagon { PosX = -138.5f, PosY = -183f, X = -5, Y = -1, Top1 = 5, Top2 = 2, Right = 0, Bottom1 = 7, Bottom2 = 6, Left = 7, CorrectRotate = 60 },
					new BlockHexagon { PosX = 1.5f, PosY = 61f, X = -3, Y = 1, Top1 = 6, Top2 = 2, Right = 7, Bottom1 = 4, Bottom2 = 2, Left = 4, CorrectRotate = 240 },
					new BlockHexagon { PosX = 71.5f, PosY = -305f, X = -2, Y = -2, Top1 = 3, Top2 = 1, Right = 7, Bottom1 = 5, Bottom2 = 5, Left = 6, CorrectRotate = 180 },
					new BlockHexagon { PosX = -208.5f, PosY = -305f, X = -6, Y = -2, Top1 = 2, Top2 = 4, Right = 6, Bottom1 = 1, Bottom2 = 2, Left = 0, CorrectRotate = 240 },
					new BlockHexagon { PosX = -208.5f, PosY = -61f, X = -6, Y = 0, Top1 = 0, Top2 = 1, Right = 5, Bottom1 = 0, Bottom2 = 5, Left = 5, CorrectRotate = 60 },
					new BlockHexagon { PosX = -68.5f, PosY = 183f, X = -4, Y = 2, Top1 = 2, Top2 = 7, Right = 6, Bottom1 = 7, Bottom2 = 1, Left = 5, CorrectRotate = 120 },
					new BlockHexagon { PosX = 71.5f, PosY = 183f, X = -2, Y = 2, Top1 = 3, Top2 = 6, Right = 1, Bottom1 = 7, Bottom2 = 3, Left = 4, CorrectRotate = 120 },
					new BlockHexagon { PosX = 141.5f, PosY = 61f, X = -1, Y = 1, Top1 = 3, Top2 = 5, Right = 5, Bottom1 = 2, Bottom2 = 6, Left = 1, CorrectRotate = 0 },
					new BlockHexagon { PosX = 141.5f, PosY = -427f, X = -1, Y = -3, Top1 = 0, Top2 = 4, Right = 5, Bottom1 = 4, Bottom2 = 2, Left = 1, CorrectRotate = 180 },
					new BlockHexagon { PosX = 1.5f, PosY = -427f, X = -3, Y = -3, Top1 = 6, Top2 = 2, Right = 0, Bottom1 = 0, Bottom2 = 5, Left = 5, CorrectRotate = 300 },
					new BlockHexagon { PosX = -138.5f, PosY = -427f, X = -5, Y = -3, Top1 = 2, Top2 = 3, Right = 0, Bottom1 = 2, Bottom2 = 7, Left = 4, CorrectRotate = 60 },
					new BlockHexagon { PosX = -138.5f, PosY = 61f, X = -5, Y = 1, Top1 = 5, Top2 = 3, Right = 7, Bottom1 = 2, Bottom2 = 6, Left = 7, CorrectRotate = 300 },
					new BlockHexagon { PosX = -138.5f, PosY = 305f, X = -5, Y = 3, Top1 = 0, Top2 = 1, Right = 5, Bottom1 = 2, Bottom2 = 3, Left = 4, CorrectRotate = 240 },
					new BlockHexagon { PosX = 1.5f, PosY = 305f, X = -3, Y = 3, Top1 = 0, Top2 = 7, Right = 1, Bottom1 = 2, Bottom2 = 6, Left = 6, CorrectRotate = 120 },
					new BlockHexagon { PosX = -208.5f, PosY = 183f, X = -6, Y = 2, Top1 = 2, Top2 = 0, Right = 0, Bottom1 = 1, Bottom2 = 3, Left = 6, CorrectRotate = 300 },
					new BlockHexagon { PosX = 141.5f, PosY = 305f, X = -1, Y = 3, Top1 = 1, Top2 = 7, Right = 0, Bottom1 = 1, Bottom2 = 6, Left = 1, CorrectRotate = 240 },
					new BlockHexagon { PosX = 211.5f, PosY = 183f, X = 0, Y = 2, Top1 = 5, Top2 = 3, Right = 2, Bottom1 = 4, Bottom2 = 0, Left = 2, CorrectRotate = 240 },
					new BlockHexagon { PosX = 281.5f, PosY = 61f, X = 1, Y = 1, Top1 = 5, Top2 = 2, Right = 2, Bottom1 = 4, Bottom2 = 2, Left = 0, CorrectRotate = 180 },
					new BlockHexagon { PosX = 281.5f, PosY = -427f, X = 1, Y = -3, Top1 = 5, Top2 = 6, Right = 2, Bottom1 = 6, Bottom2 = 3, Left = 1, CorrectRotate = 240 },
					new BlockHexagon { PosX = -278.5f, PosY = 305f, X = -7, Y = 3, Top1 = 1, Top2 = 2, Right = 0, Bottom1 = 7, Bottom2 = 1, Left = 5, CorrectRotate = 180 },
					new BlockHexagon { PosX = -68.5f, PosY = 427f, X = -4, Y = 4, Top1 = 0, Top2 = 5, Right = 0, Bottom1 = 6, Bottom2 = 3, Left = 4, CorrectRotate = 0 },
					new BlockHexagon { PosX = -278.5f, PosY = 61f, X = -7, Y = 1, Top1 = 6, Top2 = 6, Right = 7, Bottom1 = 4, Bottom2 = 6, Left = 1, CorrectRotate = 180 },
					new BlockHexagon { PosX = 211.5f, PosY = 427f, X = 0, Y = 4, Top1 = 6, Top2 = 2, Right = 0, Bottom1 = 3, Bottom2 = 6, Left = 2, CorrectRotate = 120 },
					new BlockHexagon { PosX = 281.5f, PosY = 305f, X = 1, Y = 3, Top1 = 0, Top2 = 3, Right = 7, Bottom1 = 5, Bottom2 = 6, Left = 5, CorrectRotate = 300 },
				}
			};
		}
	}
}