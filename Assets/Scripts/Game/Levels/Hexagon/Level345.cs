using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hexagon
{
	public abstract class Level345
	{
		public static LevelHexagon GetLevel()
		{
			return new LevelHexagon
			{
				Number = 345,
				MatchsToWin = 44,
				ThreeStarsLimit = 63,
				TwoStarsLimit = 76,
				BlockWidth = 141,
				BlockHeight = 162,
				Blocks = new List<BlockHexagon>
				{
					new BlockHexagon { PosX = -70.5f, PosY = 183f, X = 0, Y = 0, Top1 = 7, Top2 = 1, Right = 6, Bottom1 = 7, Bottom2 = 1, Left = 7, CorrectRotate = 180 },
					new BlockHexagon { PosX = -0.5f, PosY = 305f, X = 1, Y = 1, Top1 = 1, Top2 = 1, Right = 1, Bottom1 = 6, Bottom2 = 6, Left = 2, CorrectRotate = 300 },
					new BlockHexagon { PosX = 69.5f, PosY = 183f, X = 2, Y = 0, Top1 = 6, Top2 = 1, Right = 6, Bottom1 = 2, Bottom2 = 2, Left = 0, CorrectRotate = 0 },
					new BlockHexagon { PosX = -0.5f, PosY = 61f, X = 1, Y = -1, Top1 = 5, Top2 = 0, Right = 5, Bottom1 = 0, Bottom2 = 4, Left = 5, CorrectRotate = 60 },
					new BlockHexagon { PosX = 69.5f, PosY = -61f, X = 2, Y = -2, Top1 = 3, Top2 = 0, Right = 6, Bottom1 = 1, Bottom2 = 3, Left = 2, CorrectRotate = 0 },
					new BlockHexagon { PosX = -70.5f, PosY = -61f, X = 0, Y = -2, Top1 = 0, Top2 = 4, Right = 2, Bottom1 = 5, Bottom2 = 5, Left = 5, CorrectRotate = 60 },
					new BlockHexagon { PosX = -140.5f, PosY = 61f, X = -1, Y = -1, Top1 = 7, Top2 = 1, Right = 6, Bottom1 = 6, Bottom2 = 2, Left = 3, CorrectRotate = 120 },
					new BlockHexagon { PosX = -0.5f, PosY = -183f, X = 1, Y = -3, Top1 = 4, Top2 = 7, Right = 4, Bottom1 = 5, Bottom2 = 0, Left = 2, CorrectRotate = 300 },
					new BlockHexagon { PosX = -140.5f, PosY = -183f, X = -1, Y = -3, Top1 = 4, Top2 = 2, Right = 7, Bottom1 = 3, Bottom2 = 3, Left = 0, CorrectRotate = 0 },
					new BlockHexagon { PosX = -210.5f, PosY = -61f, X = -2, Y = -2, Top1 = 7, Top2 = 3, Right = 7, Bottom1 = 0, Bottom2 = 3, Left = 0, CorrectRotate = 240 },
					new BlockHexagon { PosX = -210.5f, PosY = 183f, X = -2, Y = 0, Top1 = 1, Top2 = 1, Right = 2, Bottom1 = 2, Bottom2 = 2, Left = 5, CorrectRotate = 240 },
					new BlockHexagon { PosX = 139.5f, PosY = -183f, X = 3, Y = -3, Top1 = 3, Top2 = 4, Right = 7, Bottom1 = 0, Bottom2 = 6, Left = 1, CorrectRotate = 240 },
					new BlockHexagon { PosX = -70.5f, PosY = -305f, X = 0, Y = -4, Top1 = 0, Top2 = 4, Right = 2, Bottom1 = 6, Bottom2 = 1, Left = 7, CorrectRotate = 60 },
					new BlockHexagon { PosX = -210.5f, PosY = -305f, X = -2, Y = -4, Top1 = 2, Top2 = 2, Right = 0, Bottom1 = 4, Bottom2 = 4, Left = 7, CorrectRotate = 180 },
					new BlockHexagon { PosX = -280.5f, PosY = -183f, X = -3, Y = -3, Top1 = 0, Top2 = 7, Right = 3, Bottom1 = 3, Bottom2 = 1, Left = 7, CorrectRotate = 300 },
					new BlockHexagon { PosX = -280.5f, PosY = 61f, X = -3, Y = -1, Top1 = 3, Top2 = 4, Right = 5, Bottom1 = 6, Bottom2 = 4, Left = 0, CorrectRotate = 60 },
					new BlockHexagon { PosX = -280.5f, PosY = 305f, X = -3, Y = 1, Top1 = 5, Top2 = 4, Right = 4, Bottom1 = 7, Bottom2 = 5, Left = 2, CorrectRotate = 180 },
					new BlockHexagon { PosX = -140.5f, PosY = 305f, X = -1, Y = 1, Top1 = 1, Top2 = 0, Right = 2, Bottom1 = 5, Bottom2 = 0, Left = 4, CorrectRotate = 240 },
					new BlockHexagon { PosX = 279.5f, PosY = -183f, X = 5, Y = -3, Top1 = 4, Top2 = 5, Right = 0, Bottom1 = 5, Bottom2 = 3, Left = 3, CorrectRotate = 60 },
					new BlockHexagon { PosX = 209.5f, PosY = -305f, X = 4, Y = -4, Top1 = 4, Top2 = 3, Right = 4, Bottom1 = 3, Bottom2 = 1, Left = 2, CorrectRotate = 60 },
					new BlockHexagon { PosX = 69.5f, PosY = -305f, X = 2, Y = -4, Top1 = 3, Top2 = 4, Right = 4, Bottom1 = 1, Bottom2 = 3, Left = 0, CorrectRotate = 240 },
				}
			};
		}
	}
}