using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hexagon
{
	public abstract class Level317
	{
		public static LevelHexagon GetLevel()
		{
			return new LevelHexagon
			{
				Number = 317,
				MatchsToWin = 20,
				ThreeStarsLimit = 30,
				TwoStarsLimit = 37,
				BlockWidth = 141,
				BlockHeight = 162,
				Blocks = new List<BlockHexagon>
				{
					new BlockHexagon { PosX = 282, PosY = -122, X = 0, Y = 0, Top1 = 0, Top2 = 2, Right = 2, Bottom1 = 2, Bottom2 = 5, Left = 1, CorrectRotate = 120 },
					new BlockHexagon { PosX = 212, PosY = -244, X = -1, Y = -1, Top1 = 1, Top2 = 7, Right = 1, Bottom1 = 7, Bottom2 = 0, Left = 7, CorrectRotate = 120 },
					new BlockHexagon { PosX = 142, PosY = -122, X = -2, Y = 0, Top1 = 1, Top2 = 5, Right = 6, Bottom1 = 1, Bottom2 = 4, Left = 2, CorrectRotate = 300 },
					new BlockHexagon { PosX = 72, PosY = 0, X = -3, Y = 1, Top1 = 2, Top2 = 0, Right = 1, Bottom1 = 5, Bottom2 = 5, Left = 2, CorrectRotate = 60 },
					new BlockHexagon { PosX = 212, PosY = 0, X = -1, Y = 1, Top1 = 0, Top2 = 2, Right = 0, Bottom1 = 5, Bottom2 = 6, Left = 2, CorrectRotate = 0 },
					new BlockHexagon { PosX = 2, PosY = -122, X = -4, Y = 0, Top1 = 5, Top2 = 1, Right = 3, Bottom1 = 2, Bottom2 = 5, Left = 3, CorrectRotate = 180 },
					new BlockHexagon { PosX = -138, PosY = -122, X = -6, Y = 0, Top1 = 2, Top2 = 1, Right = 2, Bottom1 = 3, Bottom2 = 4, Left = 6, CorrectRotate = 120 },
					new BlockHexagon { PosX = -68, PosY = 0, X = -5, Y = 1, Top1 = 4, Top2 = 0, Right = 6, Bottom1 = 5, Bottom2 = 5, Left = 5, CorrectRotate = 120 },
					new BlockHexagon { PosX = -278, PosY = -122, X = -8, Y = 0, Top1 = 5, Top2 = 2, Right = 3, Bottom1 = 0, Bottom2 = 6, Left = 1, CorrectRotate = 120 },
					new BlockHexagon { PosX = -138, PosY = 122, X = -6, Y = 2, Top1 = 1, Top2 = 0, Right = 3, Bottom1 = 5, Bottom2 = 4, Left = 5, CorrectRotate = 180 },
					new BlockHexagon { PosX = -68, PosY = 244, X = -5, Y = 3, Top1 = 3, Top2 = 3, Right = 3, Bottom1 = 1, Bottom2 = 3, Left = 4, CorrectRotate = 180 },
					new BlockHexagon { PosX = 2, PosY = 122, X = -4, Y = 2, Top1 = 4, Top2 = 3, Right = 2, Bottom1 = 7, Bottom2 = 2, Left = 2, CorrectRotate = 0 },
				}
			};
		}
	}
}