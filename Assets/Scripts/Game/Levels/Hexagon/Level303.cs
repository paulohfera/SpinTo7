using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hexagon
{
	public abstract class Level303
	{
		public static LevelHexagon GetLevel()
		{
			return new LevelHexagon
			{
				Number = 303,
				MatchsToWin = 7,
				ThreeStarsLimit = 16,
				TwoStarsLimit = 19,
				BlockWidth = 150,
				BlockHeight = 172,
				Blocks = new List<BlockHexagon>
				{
					new BlockHexagon { PosX = 0, PosY = 65, X = 0, Y = 0, Top1 = 3, Top2 = 4, Right = 7, Bottom1 = 6, Bottom2 = 4, Left = 4, CorrectRotate = 0 },
					new BlockHexagon { PosX = 75, PosY = -65, X = 1, Y = -1, Top1 = 6, Top2 = 4, Right = 1, Bottom1 = 2, Bottom2 = 0, Left = 6, CorrectRotate = 120 },
					new BlockHexagon { PosX = -75, PosY = -65, X = -1, Y = -1, Top1 = 3, Top2 = 4, Right = 2, Bottom1 = 5, Bottom2 = 6, Left = 3, CorrectRotate = 240 },
					new BlockHexagon { PosX = -150, PosY = 65, X = -2, Y = 0, Top1 = 3, Top2 = 1, Right = 5, Bottom1 = 5, Bottom2 = 4, Left = 7, CorrectRotate = 240 },
					new BlockHexagon { PosX = 150, PosY = 65, X = 2, Y = 0, Top1 = 7, Top2 = 5, Right = 0, Bottom1 = 5, Bottom2 = 5, Left = 3, CorrectRotate = 180 },
				}
			};
		}
	}
}