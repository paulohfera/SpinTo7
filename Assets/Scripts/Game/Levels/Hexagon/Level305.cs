using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hexagon
{
	public abstract class Level305
	{
		public static LevelHexagon GetLevel()
		{
			return new LevelHexagon
			{
				Number = 305,
				MatchsToWin = 8,
				ThreeStarsLimit = 26,
				TwoStarsLimit = 31,
				BlockWidth = 150,
				BlockHeight = 172,
				Blocks = new List<BlockHexagon>
				{
					new BlockHexagon { PosX = 0, PosY = 195, X = 0, Y = 0, Top1 = 6, Top2 = 1, Right = 1, Bottom1 = 6, Bottom2 = 0, Left = 4, CorrectRotate = 240 },
					new BlockHexagon { PosX = 75, PosY = 65, X = 1, Y = -1, Top1 = 6, Top2 = 7, Right = 0, Bottom1 = 6, Bottom2 = 7, Left = 6, CorrectRotate = 180 },
					new BlockHexagon { PosX = 0, PosY = -65, X = 0, Y = -2, Top1 = 7, Top2 = 2, Right = 0, Bottom1 = 1, Bottom2 = 0, Left = 5, CorrectRotate = 180 },
					new BlockHexagon { PosX = -75, PosY = 65, X = -1, Y = -1, Top1 = 0, Top2 = 2, Right = 6, Bottom1 = 7, Bottom2 = 6, Left = 7, CorrectRotate = 60 },
					new BlockHexagon { PosX = 75, PosY = -195, X = 1, Y = -3, Top1 = 1, Top2 = 1, Right = 1, Bottom1 = 3, Bottom2 = 2, Left = 0, CorrectRotate = 300 },
					new BlockHexagon { PosX = -75, PosY = -195, X = -1, Y = -3, Top1 = 5, Top2 = 5, Right = 4, Bottom1 = 3, Bottom2 = 0, Left = 0, CorrectRotate = 300 },
				}
			};
		}
	}
}