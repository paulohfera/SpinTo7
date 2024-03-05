using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hexagon
{
	public abstract class Level384
	{
		public static LevelHexagon GetLevel()
		{
			return new LevelHexagon
			{
				Number = 384,
				MatchsToWin = 57,
				ThreeStarsLimit = 88,
				TwoStarsLimit = 106,
				BlockWidth = 114,
				BlockHeight = 131,
				Blocks = new List<BlockHexagon>
				{
					new BlockHexagon { PosX = -256, PosY = 294, X = 0, Y = 0, Top1 = 0, Top2 = 6, Right = 3, Bottom1 = 0, Bottom2 = 3, Left = 3, CorrectRotate = 240 },
					new BlockHexagon { PosX = -199f, PosY = 392, X = 1, Y = 1, Top1 = 3, Top2 = 7, Right = 4, Bottom1 = 2, Bottom2 = 7, Left = 6, CorrectRotate = 240 },
					new BlockHexagon { PosX = -142, PosY = 294, X = 2, Y = 0, Top1 = 4, Top2 = 2, Right = 0, Bottom1 = 0, Bottom2 = 7, Left = 0, CorrectRotate = 300 },
					new BlockHexagon { PosX = -85f, PosY = 196, X = 3, Y = -1, Top1 = 1, Top2 = 1, Right = 7, Bottom1 = 6, Bottom2 = 4, Left = 0, CorrectRotate = 120 },
					new BlockHexagon { PosX = -199f, PosY = 196, X = 1, Y = -1, Top1 = 4, Top2 = 0, Right = 1, Bottom1 = 7, Bottom2 = 6, Left = 4, CorrectRotate = 120 },
					new BlockHexagon { PosX = 29f, PosY = 196, X = 5, Y = -1, Top1 = 7, Top2 = 0, Right = 5, Bottom1 = 7, Bottom2 = 6, Left = 3, CorrectRotate = 0 },
					new BlockHexagon { PosX = -28, PosY = 98, X = 4, Y = -2, Top1 = 4, Top2 = 3, Right = 7, Bottom1 = 1, Bottom2 = 5, Left = 6, CorrectRotate = 120 },
					new BlockHexagon { PosX = -142, PosY = 98, X = 2, Y = -2, Top1 = 1, Top2 = 3, Right = 6, Bottom1 = 4, Bottom2 = 7, Left = 2, CorrectRotate = 60 },
					new BlockHexagon { PosX = -256, PosY = 98, X = 0, Y = -2, Top1 = 3, Top2 = 6, Right = 3, Bottom1 = 6, Bottom2 = 0, Left = 2, CorrectRotate = 300 },
					new BlockHexagon { PosX = -313f, PosY = 196, X = -1, Y = -1, Top1 = 4, Top2 = 4, Right = 7, Bottom1 = 5, Bottom2 = 4, Left = 7, CorrectRotate = 0 },
					new BlockHexagon { PosX = 86, PosY = 294, X = 6, Y = 0, Top1 = 2, Top2 = 7, Right = 5, Bottom1 = 2, Bottom2 = 7, Left = 4, CorrectRotate = 0 },
					new BlockHexagon { PosX = 143f, PosY = 196, X = 7, Y = -1, Top1 = 2, Top2 = 5, Right = 1, Bottom1 = 7, Bottom2 = 7, Left = 5, CorrectRotate = 60 },
					new BlockHexagon { PosX = 86, PosY = 98, X = 6, Y = -2, Top1 = 2, Top2 = 0, Right = 2, Bottom1 = 4, Bottom2 = 7, Left = 1, CorrectRotate = 60 },
					new BlockHexagon { PosX = 200, PosY = 98, X = 8, Y = -2, Top1 = 3, Top2 = 0, Right = 3, Bottom1 = 6, Bottom2 = 7, Left = 1, CorrectRotate = 60 },
					new BlockHexagon { PosX = 29f, PosY = 0, X = 5, Y = -3, Top1 = 4, Top2 = 4, Right = 1, Bottom1 = 6, Bottom2 = 1, Left = 2, CorrectRotate = 120 },
					new BlockHexagon { PosX = 314, PosY = 98, X = 10, Y = -2, Top1 = 5, Top2 = 5, Right = 6, Bottom1 = 4, Bottom2 = 1, Left = 6, CorrectRotate = 300 },
					new BlockHexagon { PosX = 257f, PosY = 0, X = 9, Y = -3, Top1 = 4, Top2 = 7, Right = 1, Bottom1 = 0, Bottom2 = 3, Left = 7, CorrectRotate = 180 },
					new BlockHexagon { PosX = 200, PosY = -98, X = 8, Y = -4, Top1 = 1, Top2 = 0, Right = 4, Bottom1 = 4, Bottom2 = 0, Left = 5, CorrectRotate = 180 },
					new BlockHexagon { PosX = 143f, PosY = 0, X = 7, Y = -3, Top1 = 6, Top2 = 6, Right = 3, Bottom1 = 1, Bottom2 = 6, Left = 0, CorrectRotate = 300 },
					new BlockHexagon { PosX = 86, PosY = -98, X = 6, Y = -4, Top1 = 5, Top2 = 3, Right = 3, Bottom1 = 5, Bottom2 = 6, Left = 3, CorrectRotate = 180 },
					new BlockHexagon { PosX = 29f, PosY = -196, X = 5, Y = -5, Top1 = 7, Top2 = 6, Right = 7, Bottom1 = 4, Bottom2 = 0, Left = 4, CorrectRotate = 120 },
					new BlockHexagon { PosX = -28, PosY = -98, X = 4, Y = -4, Top1 = 0, Top2 = 4, Right = 7, Bottom1 = 6, Bottom2 = 3, Left = 4, CorrectRotate = 180 },
					new BlockHexagon { PosX = 86, PosY = -294, X = 6, Y = -6, Top1 = 4, Top2 = 3, Right = 2, Bottom1 = 2, Bottom2 = 6, Left = 7, CorrectRotate = 60 },
					new BlockHexagon { PosX = 200, PosY = -294, X = 8, Y = -6, Top1 = 4, Top2 = 5, Right = 4, Bottom1 = 6, Bottom2 = 5, Left = 7, CorrectRotate = 120 },
					new BlockHexagon { PosX = 143f, PosY = -392, X = 7, Y = -7, Top1 = 3, Top2 = 5, Right = 4, Bottom1 = 1, Bottom2 = 0, Left = 1, CorrectRotate = 300 },
					new BlockHexagon { PosX = 29f, PosY = -392, X = 5, Y = -7, Top1 = 0, Top2 = 7, Right = 2, Bottom1 = 7, Bottom2 = 4, Left = 1, CorrectRotate = 300 },
					new BlockHexagon { PosX = -28, PosY = -294, X = 4, Y = -6, Top1 = 3, Top2 = 6, Right = 2, Bottom1 = 6, Bottom2 = 6, Left = 0, CorrectRotate = 240 },
					new BlockHexagon { PosX = 257f, PosY = -196, X = 9, Y = -5, Top1 = 6, Top2 = 6, Right = 5, Bottom1 = 3, Bottom2 = 3, Left = 1, CorrectRotate = 60 },
					new BlockHexagon { PosX = 257f, PosY = -392, X = 9, Y = -7, Top1 = 2, Top2 = 0, Right = 5, Bottom1 = 4, Bottom2 = 1, Left = 1, CorrectRotate = 60 },
				}
			};
		}
	}
}