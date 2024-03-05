using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hexagon
{
	public abstract class Level369
	{
		public static LevelHexagon GetLevel()
		{
			return new LevelHexagon
			{
				Number = 369,
				MatchsToWin = 54,
				ThreeStarsLimit = 83,
				TwoStarsLimit = 101,
				BlockWidth = 123,
				BlockHeight = 142,
				Blocks = new List<BlockHexagon>
				{
					new BlockHexagon { PosX = 184.5f, PosY = -214, X = 0, Y = 0, Top1 = 5, Top2 = 5, Right = 4, Bottom1 = 6, Bottom2 = 3, Left = 4, CorrectRotate = 120 },
					new BlockHexagon { PosX = 123.5f, PosY = -321f, X = -1, Y = -1, Top1 = 0, Top2 = 1, Right = 3, Bottom1 = 3, Bottom2 = 2, Left = 1, CorrectRotate = 180 },
					new BlockHexagon { PosX = 62.5f, PosY = -214, X = -2, Y = 0, Top1 = 3, Top2 = 2, Right = 4, Bottom1 = 5, Bottom2 = 3, Left = 5, CorrectRotate = 300 },
					new BlockHexagon { PosX = 1.5f, PosY = -321f, X = -3, Y = -1, Top1 = 7, Top2 = 0, Right = 0, Bottom1 = 2, Bottom2 = 4, Left = 2, CorrectRotate = 120 },
					new BlockHexagon { PosX = 1.5f, PosY = -107f, X = -3, Y = 1, Top1 = 6, Top2 = 0, Right = 2, Bottom1 = 2, Bottom2 = 4, Left = 1, CorrectRotate = 300 },
					new BlockHexagon { PosX = 62.5f, PosY = 0, X = -2, Y = 2, Top1 = 1, Top2 = 0, Right = 7, Bottom1 = 5, Bottom2 = 1, Left = 1, CorrectRotate = 120 },
					new BlockHexagon { PosX = 123.5f, PosY = -107f, X = -1, Y = 1, Top1 = 5, Top2 = 3, Right = 4, Bottom1 = 7, Bottom2 = 6, Left = 6, CorrectRotate = 240 },
					new BlockHexagon { PosX = 1.5f, PosY = 107f, X = -3, Y = 3, Top1 = 2, Top2 = 1, Right = 0, Bottom1 = 0, Bottom2 = 6, Left = 3, CorrectRotate = 300 },
					new BlockHexagon { PosX = 123.5f, PosY = 107f, X = -1, Y = 3, Top1 = 3, Top2 = 7, Right = 3, Bottom1 = 2, Bottom2 = 6, Left = 5, CorrectRotate = 300 },
					new BlockHexagon { PosX = 184.5f, PosY = 0, X = 0, Y = 2, Top1 = 4, Top2 = 1, Right = 6, Bottom1 = 5, Bottom2 = 1, Left = 6, CorrectRotate = 0 },
					new BlockHexagon { PosX = -59.5f, PosY = 214, X = -4, Y = 4, Top1 = 5, Top2 = 4, Right = 6, Bottom1 = 2, Bottom2 = 4, Left = 0, CorrectRotate = 240 },
					new BlockHexagon { PosX = 62.5f, PosY = 214, X = -2, Y = 4, Top1 = 2, Top2 = 7, Right = 1, Bottom1 = 0, Bottom2 = 2, Left = 5, CorrectRotate = 60 },
					new BlockHexagon { PosX = -59.5f, PosY = 0, X = -4, Y = 2, Top1 = 1, Top2 = 6, Right = 7, Bottom1 = 7, Bottom2 = 6, Left = 6, CorrectRotate = 60 },
					new BlockHexagon { PosX = 245.5f, PosY = 107f, X = 1, Y = 3, Top1 = 0, Top2 = 1, Right = 6, Bottom1 = 2, Bottom2 = 6, Left = 6, CorrectRotate = 60 },
					new BlockHexagon { PosX = 306.5f, PosY = 0, X = 2, Y = 2, Top1 = 7, Top2 = 1, Right = 1, Bottom1 = 2, Bottom2 = 4, Left = 7, CorrectRotate = 120 },
					new BlockHexagon { PosX = 245.5f, PosY = -107f, X = 1, Y = 1, Top1 = 1, Top2 = 2, Right = 2, Bottom1 = 0, Bottom2 = 4, Left = 0, CorrectRotate = 120 },
					new BlockHexagon { PosX = -120.5f, PosY = 107f, X = -5, Y = 3, Top1 = 6, Top2 = 4, Right = 1, Bottom1 = 1, Bottom2 = 1, Left = 1, CorrectRotate = 60 },
					new BlockHexagon { PosX = 1.5f, PosY = 321f, X = -3, Y = 5, Top1 = 0, Top2 = 7, Right = 5, Bottom1 = 2, Bottom2 = 5, Left = 5, CorrectRotate = 180 },
					new BlockHexagon { PosX = 184.5f, PosY = 214, X = 0, Y = 4, Top1 = 1, Top2 = 2, Right = 6, Bottom1 = 4, Bottom2 = 7, Left = 6, CorrectRotate = 300 },
					new BlockHexagon { PosX = -181.5f, PosY = 0, X = -6, Y = 2, Top1 = 4, Top2 = 2, Right = 2, Bottom1 = 7, Bottom2 = 6, Left = 6, CorrectRotate = 180 },
					new BlockHexagon { PosX = -242.5f, PosY = 107f, X = -7, Y = 3, Top1 = 4, Top2 = 3, Right = 1, Bottom1 = 0, Bottom2 = 1, Left = 4, CorrectRotate = 0 },
					new BlockHexagon { PosX = -242.5f, PosY = -107f, X = -7, Y = 1, Top1 = 3, Top2 = 5, Right = 6, Bottom1 = 0, Bottom2 = 0, Left = 7, CorrectRotate = 0 },
					new BlockHexagon { PosX = -303.5f, PosY = 0, X = -8, Y = 2, Top1 = 4, Top2 = 0, Right = 3, Bottom1 = 3, Bottom2 = 6, Left = 5, CorrectRotate = 180 },
					new BlockHexagon { PosX = -303.5f, PosY = 214, X = -8, Y = 4, Top1 = 0, Top2 = 3, Right = 2, Bottom1 = 2, Bottom2 = 0, Left = 7, CorrectRotate = 240 },
					new BlockHexagon { PosX = -181.5f, PosY = 214, X = -6, Y = 4, Top1 = 5, Top2 = 5, Right = 3, Bottom1 = 4, Bottom2 = 7, Left = 6, CorrectRotate = 300 },
					new BlockHexagon { PosX = -181.5f, PosY = -214, X = -6, Y = 0, Top1 = 3, Top2 = 7, Right = 7, Bottom1 = 6, Bottom2 = 1, Left = 6, CorrectRotate = 60 },
				}
			};
		}
	}
}