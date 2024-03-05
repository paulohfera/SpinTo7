using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hexagon
{
	public abstract class Level301
	{
		public static LevelHexagon GetLevel()
		{
			return new LevelHexagon
			{
				Number = 301,
				MatchsToWin = 7,
				ThreeStarsLimit = 18,
				TwoStarsLimit = 22,
				BlockWidth = 150,
				BlockHeight = 172,
				Blocks = new List<BlockHexagon>
				{
					new BlockHexagon { PosX = -112, PosY = 0, X = 0, Y = 0, Top1 = 4, Top2 = 6, Right = 4, Bottom1 = 0, Bottom2 = 6, Left = 5, CorrectRotate = 120 },
					new BlockHexagon { PosX = -37, PosY = 130, X = 1, Y = 1, Top1 = 1, Top2 = 2, Right = 0, Bottom1 = 0, Bottom2 = 7, Left = 7, CorrectRotate = 60 },
					new BlockHexagon { PosX = 38, PosY = 0, X = 2, Y = 0, Top1 = 0, Top2 = 2, Right = 1, Bottom1 = 0, Bottom2 = 0, Left = 1, CorrectRotate = 180 },
					new BlockHexagon { PosX = 113, PosY = -130, X = 3, Y = -1, Top1 = 0, Top2 = 4, Right = 6, Bottom1 = 7, Bottom2 = 7, Left = 6, CorrectRotate = 240 },
					new BlockHexagon { PosX = -37, PosY = -130, X = 1, Y = -1, Top1 = 5, Top2 = 0, Right = 2, Bottom1 = 6, Bottom2 = 2, Left = 2, CorrectRotate = 300 },
				}
			};
		}
	}
}