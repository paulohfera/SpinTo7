using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hexagon
{
	public abstract class Level311
	{
		public static LevelHexagon GetLevel()
		{
			return new LevelHexagon
			{
				Number = 311,
				MatchsToWin = 18,
				ThreeStarsLimit = 35,
				TwoStarsLimit = 43,
				BlockWidth = 150,
				BlockHeight = 172,
				Blocks = new List<BlockHexagon>
				{
					new BlockHexagon { PosX = 150, PosY = 0, X = 0, Y = 0, Top1 = 3, Top2 = 1, Right = 3, Bottom1 = 6, Bottom2 = 1, Left = 7, CorrectRotate = 180 },
					new BlockHexagon { PosX = 0, PosY = 0, X = -2, Y = 0, Top1 = 4, Top2 = 4, Right = 2, Bottom1 = 2, Bottom2 = 4, Left = 0, CorrectRotate = 300 },
					new BlockHexagon { PosX = -75, PosY = 130, X = -3, Y = 1, Top1 = 6, Top2 = 0, Right = 7, Bottom1 = 5, Bottom2 = 3, Left = 1, CorrectRotate = 300 },
					new BlockHexagon { PosX = 75, PosY = 130, X = -1, Y = 1, Top1 = 3, Top2 = 7, Right = 7, Bottom1 = 1, Bottom2 = 0, Left = 1, CorrectRotate = 120 },
					new BlockHexagon { PosX = -75, PosY = -130, X = -3, Y = -1, Top1 = 6, Top2 = 7, Right = 6, Bottom1 = 5, Bottom2 = 3, Left = 0, CorrectRotate = 120 },
					new BlockHexagon { PosX = -150, PosY = 0, X = -4, Y = 0, Top1 = 1, Top2 = 7, Right = 5, Bottom1 = 5, Bottom2 = 2, Left = 3, CorrectRotate = 180 },
					new BlockHexagon { PosX = 75, PosY = -130, X = -1, Y = -1, Top1 = 4, Top2 = 5, Right = 6, Bottom1 = 2, Bottom2 = 5, Left = 2, CorrectRotate = 60 },
					new BlockHexagon { PosX = -225, PosY = -130, X = -5, Y = -1, Top1 = 0, Top2 = 1, Right = 4, Bottom1 = 7, Bottom2 = 7, Left = 0, CorrectRotate = 240 },
					new BlockHexagon { PosX = -225, PosY = 130, X = -5, Y = 1, Top1 = 4, Top2 = 6, Right = 0, Bottom1 = 3, Bottom2 = 4, Left = 2, CorrectRotate = 120 },
					new BlockHexagon { PosX = 225, PosY = -130, X = 1, Y = -1, Top1 = 3, Top2 = 5, Right = 4, Bottom1 = 1, Bottom2 = 0, Left = 1, CorrectRotate = 120 },
				}
			};
		}
	}
}