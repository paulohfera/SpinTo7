using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hexagon
{
	public abstract class Level335
	{
		public static LevelHexagon GetLevel()
		{
			return new LevelHexagon
			{
				Number = 335,
				MatchsToWin = 29,
				ThreeStarsLimit = 48,
				TwoStarsLimit = 58,
				BlockWidth = 141,
				BlockHeight = 162,
				Blocks = new List<BlockHexagon>
				{
					new BlockHexagon { PosX = 282, PosY = 244, X = 0, Y = 0, Top1 = 5, Top2 = 1, Right = 4, Bottom1 = 2, Bottom2 = 0, Left = 1, CorrectRotate = 60 },
					new BlockHexagon { PosX = 142, PosY = 244, X = -2, Y = 0, Top1 = 1, Top2 = 2, Right = 7, Bottom1 = 3, Bottom2 = 6, Left = 0, CorrectRotate = 300 },
					new BlockHexagon { PosX = 212, PosY = 366, X = -1, Y = 1, Top1 = 4, Top2 = 6, Right = 6, Bottom1 = 3, Bottom2 = 7, Left = 2, CorrectRotate = 240 },
					new BlockHexagon { PosX = 72, PosY = 122, X = -3, Y = -1, Top1 = 2, Top2 = 7, Right = 6, Bottom1 = 4, Bottom2 = 5, Left = 4, CorrectRotate = 120 },
					new BlockHexagon { PosX = 2, PosY = 0, X = -4, Y = -2, Top1 = 5, Top2 = 5, Right = 0, Bottom1 = 0, Bottom2 = 1, Left = 5, CorrectRotate = 0 },
					new BlockHexagon { PosX = -68, PosY = 122, X = -5, Y = -1, Top1 = 1, Top2 = 1, Right = 7, Bottom1 = 6, Bottom2 = 0, Left = 2, CorrectRotate = 120 },
					new BlockHexagon { PosX = 142, PosY = 0, X = -2, Y = -2, Top1 = 6, Top2 = 1, Right = 7, Bottom1 = 7, Bottom2 = 3, Left = 0, CorrectRotate = 240 },
					new BlockHexagon { PosX = -68, PosY = -122, X = -5, Y = -3, Top1 = 2, Top2 = 7, Right = 3, Bottom1 = 5, Bottom2 = 2, Left = 6, CorrectRotate = 240 },
					new BlockHexagon { PosX = -138, PosY = 0, X = -6, Y = -2, Top1 = 6, Top2 = 2, Right = 5, Bottom1 = 7, Bottom2 = 0, Left = 7, CorrectRotate = 300 },
					new BlockHexagon { PosX = -138, PosY = 244, X = -6, Y = 0, Top1 = 5, Top2 = 5, Right = 6, Bottom1 = 7, Bottom2 = 0, Left = 1, CorrectRotate = 60 },
					new BlockHexagon { PosX = 2, PosY = 244, X = -4, Y = 0, Top1 = 5, Top2 = 3, Right = 1, Bottom1 = 1, Bottom2 = 1, Left = 0, CorrectRotate = 0 },
					new BlockHexagon { PosX = 282, PosY = 0, X = 0, Y = -2, Top1 = 5, Top2 = 0, Right = 4, Bottom1 = 1, Bottom2 = 1, Left = 1, CorrectRotate = 240 },
					new BlockHexagon { PosX = 212, PosY = -122, X = -1, Y = -3, Top1 = 6, Top2 = 3, Right = 0, Bottom1 = 1, Bottom2 = 5, Left = 6, CorrectRotate = 0 },
					new BlockHexagon { PosX = 72, PosY = -122, X = -3, Y = -3, Top1 = 1, Top2 = 0, Right = 0, Bottom1 = 5, Bottom2 = 7, Left = 0, CorrectRotate = 240 },
					new BlockHexagon { PosX = -138, PosY = -244, X = -6, Y = -4, Top1 = 2, Top2 = 3, Right = 4, Bottom1 = 6, Bottom2 = 0, Left = 1, CorrectRotate = 60 },
					new BlockHexagon { PosX = -208, PosY = -366, X = -7, Y = -5, Top1 = 6, Top2 = 7, Right = 2, Bottom1 = 6, Bottom2 = 0, Left = 6, CorrectRotate = 120 },
					new BlockHexagon { PosX = -278, PosY = -244, X = -8, Y = -4, Top1 = 3, Top2 = 3, Right = 7, Bottom1 = 5, Bottom2 = 5, Left = 5, CorrectRotate = 60 },
				}
			};
		}
	}
}