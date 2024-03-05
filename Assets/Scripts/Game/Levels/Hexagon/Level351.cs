using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hexagon
{
	public abstract class Level351
	{
		public static LevelHexagon GetLevel()
		{
			return new LevelHexagon
			{
				Number = 351,
				MatchsToWin = 53,
				ThreeStarsLimit = 83,
				TwoStarsLimit = 101,
				BlockWidth = 141,
				BlockHeight = 162,
				Blocks = new List<BlockHexagon>
				{
					new BlockHexagon { PosX = -70.5f, PosY = -122, X = 0, Y = 0, Top1 = 0, Top2 = 0, Right = 1, Bottom1 = 2, Bottom2 = 3, Left = 0, CorrectRotate = 60 },
					new BlockHexagon { PosX = -0.5f, PosY = 0, X = 1, Y = 1, Top1 = 3, Top2 = 1, Right = 3, Bottom1 = 6, Bottom2 = 1, Left = 5, CorrectRotate = 300 },
					new BlockHexagon { PosX = 69.5f, PosY = -122, X = 2, Y = 0, Top1 = 4, Top2 = 5, Right = 6, Bottom1 = 5, Bottom2 = 7, Left = 5, CorrectRotate = 0 },
					new BlockHexagon { PosX = -0.5f, PosY = -244, X = 1, Y = -1, Top1 = 1, Top2 = 4, Right = 7, Bottom1 = 4, Bottom2 = 0, Left = 6, CorrectRotate = 180 },
					new BlockHexagon { PosX = -140.5f, PosY = -244, X = -1, Y = -1, Top1 = 0, Top2 = 1, Right = 1, Bottom1 = 4, Bottom2 = 7, Left = 7, CorrectRotate = 240 },
					new BlockHexagon { PosX = -210.5f, PosY = -122, X = -2, Y = 0, Top1 = 0, Top2 = 0, Right = 3, Bottom1 = 1, Bottom2 = 7, Left = 0, CorrectRotate = 120 },
					new BlockHexagon { PosX = -70.5f, PosY = 122, X = 0, Y = 2, Top1 = 2, Top2 = 6, Right = 4, Bottom1 = 1, Bottom2 = 3, Left = 0, CorrectRotate = 180 },
					new BlockHexagon { PosX = 69.5f, PosY = 122, X = 2, Y = 2, Top1 = 7, Top2 = 0, Right = 2, Bottom1 = 6, Bottom2 = 4, Left = 7, CorrectRotate = 0 },
					new BlockHexagon { PosX = 139.5f, PosY = 0, X = 3, Y = 1, Top1 = 1, Top2 = 1, Right = 7, Bottom1 = 2, Bottom2 = 6, Left = 1, CorrectRotate = 300 },
					new BlockHexagon { PosX = -140.5f, PosY = 0, X = -1, Y = 1, Top1 = 7, Top2 = 6, Right = 7, Bottom1 = 0, Bottom2 = 1, Left = 6, CorrectRotate = 180 },
					new BlockHexagon { PosX = 139.5f, PosY = -244, X = 3, Y = -1, Top1 = 3, Top2 = 2, Right = 6, Bottom1 = 1, Bottom2 = 2, Left = 5, CorrectRotate = 240 },
					new BlockHexagon { PosX = -140.5f, PosY = 244, X = -1, Y = 3, Top1 = 4, Top2 = 3, Right = 6, Bottom1 = 1, Bottom2 = 4, Left = 1, CorrectRotate = 300 },
					new BlockHexagon { PosX = -0.5f, PosY = 244, X = 1, Y = 3, Top1 = 4, Top2 = 1, Right = 6, Bottom1 = 6, Bottom2 = 0, Left = 4, CorrectRotate = 60 },
					new BlockHexagon { PosX = -210.5f, PosY = 122, X = -2, Y = 2, Top1 = 3, Top2 = 7, Right = 2, Bottom1 = 0, Bottom2 = 5, Left = 6, CorrectRotate = 240 },
					new BlockHexagon { PosX = 139.5f, PosY = 244, X = 3, Y = 3, Top1 = 7, Top2 = 1, Right = 5, Bottom1 = 0, Bottom2 = 0, Left = 7, CorrectRotate = 120 },
					new BlockHexagon { PosX = 209.5f, PosY = 122, X = 4, Y = 2, Top1 = 6, Top2 = 5, Right = 0, Bottom1 = 1, Bottom2 = 2, Left = 6, CorrectRotate = 120 },
					new BlockHexagon { PosX = 279.5f, PosY = 0, X = 5, Y = 1, Top1 = 4, Top2 = 2, Right = 3, Bottom1 = 1, Bottom2 = 6, Left = 1, CorrectRotate = 300 },
					new BlockHexagon { PosX = 209.5f, PosY = -122, X = 4, Y = 0, Top1 = 6, Top2 = 4, Right = 7, Bottom1 = 2, Bottom2 = 1, Left = 0, CorrectRotate = 300 },
					new BlockHexagon { PosX = 279.5f, PosY = -244, X = 5, Y = -1, Top1 = 4, Top2 = 0, Right = 6, Bottom1 = 2, Bottom2 = 6, Left = 2, CorrectRotate = 60 },
					new BlockHexagon { PosX = 209.5f, PosY = -366, X = 4, Y = -2, Top1 = 6, Top2 = 5, Right = 5, Bottom1 = 7, Bottom2 = 3, Left = 1, CorrectRotate = 60 },
					new BlockHexagon { PosX = 69.5f, PosY = -366, X = 2, Y = -2, Top1 = 0, Top2 = 3, Right = 2, Bottom1 = 6, Bottom2 = 1, Left = 1, CorrectRotate = 180 },
					new BlockHexagon { PosX = -70.5f, PosY = 366, X = 0, Y = 4, Top1 = 3, Top2 = 7, Right = 2, Bottom1 = 1, Bottom2 = 1, Left = 6, CorrectRotate = 120 },
					new BlockHexagon { PosX = -280.5f, PosY = 244, X = -3, Y = 3, Top1 = 3, Top2 = 2, Right = 1, Bottom1 = 6, Bottom2 = 6, Left = 1, CorrectRotate = 240 },
					new BlockHexagon { PosX = 69.5f, PosY = 366, X = 2, Y = 4, Top1 = 1, Top2 = 2, Right = 1, Bottom1 = 6, Bottom2 = 1, Left = 6, CorrectRotate = 240 },
				}
			};
		}
	}
}