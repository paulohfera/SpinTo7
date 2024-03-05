using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hexagon
{
	public abstract class Level302
	{
		public static LevelHexagon GetLevel()
		{
			return new LevelHexagon
			{
				Number = 302,
				MatchsToWin = 6,
				ThreeStarsLimit = 22,
				TwoStarsLimit = 27,
				BlockWidth = 150,
				BlockHeight = 172,
				Blocks = new List<BlockHexagon>
				{
					new BlockHexagon { PosX = 75, PosY = 130, X = 0, Y = 0, Top1 = 2, Top2 = 2, Right = 1, Bottom1 = 2, Bottom2 = 5, Left = 4, CorrectRotate = 120 },
					new BlockHexagon { PosX = 0, PosY = 0, X = -1, Y = -1, Top1 = 3, Top2 = 5, Right = 1, Bottom1 = 5, Bottom2 = 6, Left = 0, CorrectRotate = 120 },
					new BlockHexagon { PosX = 150, PosY = 0, X = 1, Y = -1, Top1 = 0, Top2 = 7, Right = 2, Bottom1 = 1, Bottom2 = 3, Left = 2, CorrectRotate = 240 },
					new BlockHexagon { PosX = -75, PosY = -130, X = -2, Y = -2, Top1 = 4, Top2 = 6, Right = 0, Bottom1 = 6, Bottom2 = 2, Left = 2, CorrectRotate = 300 },
					new BlockHexagon { PosX = -150, PosY = 0, X = -3, Y = -1, Top1 = 6, Top2 = 2, Right = 5, Bottom1 = 2, Bottom2 = 0, Left = 7, CorrectRotate = 300 },
				}
			};
		}
	}
}