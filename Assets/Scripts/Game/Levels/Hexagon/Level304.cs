using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hexagon
{
	public abstract class Level304
	{
		public static LevelHexagon GetLevel()
		{
			return new LevelHexagon
			{
				Number = 304,
				MatchsToWin = 9,
				ThreeStarsLimit = 15,
				TwoStarsLimit = 18,
				BlockWidth = 150,
				BlockHeight = 172,
				Blocks = new List<BlockHexagon>
				{
					new BlockHexagon { PosX = -112, PosY = -130, X = 0, Y = 0, Top1 = 7, Top2 = 0, Right = 5, Bottom1 = 7, Bottom2 = 1, Left = 4, CorrectRotate = 300 },
					new BlockHexagon { PosX = -37, PosY = 0, X = 1, Y = 1, Top1 = 4, Top2 = 5, Right = 0, Bottom1 = 4, Bottom2 = 4, Left = 6, CorrectRotate = 240 },
					new BlockHexagon { PosX = -112, PosY = 130, X = 0, Y = 2, Top1 = 1, Top2 = 5, Right = 6, Bottom1 = 5, Bottom2 = 3, Left = 5, CorrectRotate = 60 },
					new BlockHexagon { PosX = 38, PosY = 130, X = 2, Y = 2, Top1 = 3, Top2 = 2, Right = 6, Bottom1 = 0, Bottom2 = 1, Left = 2, CorrectRotate = 0 },
					new BlockHexagon { PosX = 113, PosY = 0, X = 3, Y = 1, Top1 = 2, Top2 = 3, Right = 7, Bottom1 = 6, Bottom2 = 6, Left = 3, CorrectRotate = 120 },
					new BlockHexagon { PosX = 38, PosY = -130, X = 2, Y = 0, Top1 = 2, Top2 = 5, Right = 4, Bottom1 = 3, Bottom2 = 4, Left = 7, CorrectRotate = 0 },
				}
			};
		}
	}
}