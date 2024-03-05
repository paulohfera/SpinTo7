using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hexagon
{
	public abstract class Level307
	{
		public static LevelHexagon GetLevel()
		{
			return new LevelHexagon
			{
				Number = 307,
				MatchsToWin = 10,
				ThreeStarsLimit = 23,
				TwoStarsLimit = 28,
				BlockWidth = 150,
				BlockHeight = 172,
				Blocks = new List<BlockHexagon>
				{
					new BlockHexagon { PosX = 150, PosY = 195, X = 0, Y = 0, Top1 = 4, Top2 = 1, Right = 1, Bottom1 = 5, Bottom2 = 3, Left = 3, CorrectRotate = 240 },
					new BlockHexagon { PosX = 75, PosY = 65, X = -1, Y = -1, Top1 = 6, Top2 = 5, Right = 6, Bottom1 = 7, Bottom2 = 6, Left = 7, CorrectRotate = 180 },
					new BlockHexagon { PosX = 0, PosY = -65, X = -2, Y = -2, Top1 = 5, Top2 = 2, Right = 0, Bottom1 = 3, Bottom2 = 4, Left = 2, CorrectRotate = 240 },
					new BlockHexagon { PosX = -75, PosY = 65, X = -3, Y = -1, Top1 = 4, Top2 = 2, Right = 1, Bottom1 = 3, Bottom2 = 4, Left = 4, CorrectRotate = 0 },
					new BlockHexagon { PosX = 150, PosY = -65, X = 0, Y = -2, Top1 = 2, Top2 = 1, Right = 7, Bottom1 = 3, Bottom2 = 7, Left = 3, CorrectRotate = 60 },
					new BlockHexagon { PosX = -75, PosY = -195, X = -3, Y = -3, Top1 = 3, Top2 = 1, Right = 4, Bottom1 = 2, Bottom2 = 3, Left = 7, CorrectRotate = 240 },
					new BlockHexagon { PosX = -150, PosY = -65, X = -4, Y = -2, Top1 = 4, Top2 = 0, Right = 7, Bottom1 = 0, Bottom2 = 3, Left = 4, CorrectRotate = 180 },
				}
			};
		}
	}
}