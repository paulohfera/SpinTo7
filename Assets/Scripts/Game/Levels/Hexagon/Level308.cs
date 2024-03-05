using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hexagon
{
	public abstract class Level308
	{
		public static LevelHexagon GetLevel()
		{
			return new LevelHexagon
			{
				Number = 308,
				MatchsToWin = 13,
				ThreeStarsLimit = 23,
				TwoStarsLimit = 28,
				BlockWidth = 150,
				BlockHeight = 172,
				Blocks = new List<BlockHexagon>
				{
					new BlockHexagon { PosX = 0, PosY = 130, X = 0, Y = 0, Top1 = 2, Top2 = 5, Right = 4, Bottom1 = 6, Bottom2 = 5, Left = 4, CorrectRotate = 60 },
					new BlockHexagon { PosX = 75, PosY = 0, X = 1, Y = -1, Top1 = 2, Top2 = 1, Right = 5, Bottom1 = 4, Bottom2 = 3, Left = 1, CorrectRotate = 0 },
					new BlockHexagon { PosX = -75, PosY = 0, X = -1, Y = -1, Top1 = 0, Top2 = 1, Right = 2, Bottom1 = 3, Bottom2 = 6, Left = 6, CorrectRotate = 120 },
					new BlockHexagon { PosX = -150, PosY = 130, X = -2, Y = 0, Top1 = 3, Top2 = 5, Right = 5, Bottom1 = 0, Bottom2 = 6, Left = 1, CorrectRotate = 300 },
					new BlockHexagon { PosX = 150, PosY = 130, X = 2, Y = 0, Top1 = 7, Top2 = 2, Right = 0, Bottom1 = 6, Bottom2 = 1, Left = 0, CorrectRotate = 300 },
					new BlockHexagon { PosX = 150, PosY = -130, X = 2, Y = -2, Top1 = 5, Top2 = 5, Right = 3, Bottom1 = 1, Bottom2 = 1, Left = 7, CorrectRotate = 120 },
					new BlockHexagon { PosX = 0, PosY = -130, X = 0, Y = -2, Top1 = 2, Top2 = 1, Right = 4, Bottom1 = 2, Bottom2 = 5, Left = 5, CorrectRotate = 60 },
					new BlockHexagon { PosX = -150, PosY = -130, X = -2, Y = -2, Top1 = 0, Top2 = 7, Right = 7, Bottom1 = 3, Bottom2 = 7, Left = 5, CorrectRotate = 180 },
				}
			};
		}
	}
}