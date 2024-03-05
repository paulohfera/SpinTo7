using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hexagon
{
	public abstract class Level328
	{
		public static LevelHexagon GetLevel()
		{
			return new LevelHexagon
			{
				Number = 328,
				MatchsToWin = 25,
				ThreeStarsLimit = 34,
				TwoStarsLimit = 41,
				BlockWidth = 132,
				BlockHeight = 152,
				Blocks = new List<BlockHexagon>
				{
					new BlockHexagon { PosX = -297, PosY = -115, X = 0, Y = 0, Top1 = 2, Top2 = 1, Right = 4, Bottom1 = 0, Bottom2 = 5, Left = 6, CorrectRotate = 240 },
					new BlockHexagon { PosX = -165, PosY = -115, X = 2, Y = 0, Top1 = 7, Top2 = 3, Right = 5, Bottom1 = 4, Bottom2 = 2, Left = 5, CorrectRotate = 0 },
					new BlockHexagon { PosX = -99, PosY = 0, X = 3, Y = 1, Top1 = 2, Top2 = 2, Right = 3, Bottom1 = 2, Bottom2 = 1, Left = 4, CorrectRotate = 60 },
					new BlockHexagon { PosX = -33, PosY = -115, X = 4, Y = 0, Top1 = 2, Top2 = 6, Right = 1, Bottom1 = 0, Bottom2 = 5, Left = 1, CorrectRotate = 60 },
					new BlockHexagon { PosX = -99, PosY = -230, X = 3, Y = -1, Top1 = 4, Top2 = 1, Right = 3, Bottom1 = 3, Bottom2 = 6, Left = 5, CorrectRotate = 180 },
					new BlockHexagon { PosX = -231, PosY = -230, X = 1, Y = -1, Top1 = 2, Top2 = 6, Right = 6, Bottom1 = 5, Bottom2 = 4, Left = 2, CorrectRotate = 120 },
					new BlockHexagon { PosX = -33, PosY = 115, X = 4, Y = 2, Top1 = 4, Top2 = 7, Right = 4, Bottom1 = 5, Bottom2 = 5, Left = 2, CorrectRotate = 240 },
					new BlockHexagon { PosX = 99, PosY = 115, X = 6, Y = 2, Top1 = 5, Top2 = 0, Right = 2, Bottom1 = 7, Bottom2 = 0, Left = 3, CorrectRotate = 0 },
					new BlockHexagon { PosX = 33, PosY = 0, X = 5, Y = 1, Top1 = 6, Top2 = 5, Right = 0, Bottom1 = 7, Bottom2 = 3, Left = 3, CorrectRotate = 120 },
					new BlockHexagon { PosX = 165, PosY = 230, X = 7, Y = 3, Top1 = 0, Top2 = 3, Right = 3, Bottom1 = 3, Bottom2 = 0, Left = 7, CorrectRotate = 60 },
					new BlockHexagon { PosX = 231, PosY = 115, X = 8, Y = 2, Top1 = 5, Top2 = 7, Right = 7, Bottom1 = 3, Bottom2 = 0, Left = 4, CorrectRotate = 60 },
					new BlockHexagon { PosX = 165, PosY = 0, X = 7, Y = 1, Top1 = 1, Top2 = 3, Right = 4, Bottom1 = 0, Bottom2 = 3, Left = 4, CorrectRotate = 180 },
					new BlockHexagon { PosX = 297, PosY = 0, X = 9, Y = 1, Top1 = 3, Top2 = 7, Right = 7, Bottom1 = 4, Bottom2 = 7, Left = 0, CorrectRotate = 60 },
					new BlockHexagon { PosX = 231, PosY = -115, X = 8, Y = 0, Top1 = 7, Top2 = 1, Right = 5, Bottom1 = 7, Bottom2 = 3, Left = 6, CorrectRotate = 300 },
				}
			};
		}
	}
}