using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hexagon
{
	public abstract class Level361
	{
		public static LevelHexagon GetLevel()
		{
			return new LevelHexagon
			{
				Number = 361,
				MatchsToWin = 59,
				ThreeStarsLimit = 71,
				TwoStarsLimit = 86,
				BlockWidth = 132,
				BlockHeight = 152,
				Blocks = new List<BlockHexagon>
				{
					new BlockHexagon { PosX = 99f, PosY = -115f, X = 0, Y = 0, Top1 = 6, Top2 = 3, Right = 5, Bottom1 = 5, Bottom2 = 7, Left = 6, CorrectRotate = 120 },
					new BlockHexagon { PosX = 165f, PosY = 0, X = 1, Y = 1, Top1 = 0, Top2 = 2, Right = 4, Bottom1 = 7, Bottom2 = 2, Left = 0, CorrectRotate = 180 },
					new BlockHexagon { PosX = 231f, PosY = -115f, X = 2, Y = 0, Top1 = 0, Top2 = 7, Right = 2, Bottom1 = 0, Bottom2 = 7, Left = 7, CorrectRotate = 60 },
					new BlockHexagon { PosX = 165f, PosY = -230, X = 1, Y = -1, Top1 = 0, Top2 = 4, Right = 2, Bottom1 = 1, Bottom2 = 0, Left = 3, CorrectRotate = 180 },
					new BlockHexagon { PosX = 33f, PosY = -230, X = -1, Y = -1, Top1 = 1, Top2 = 5, Right = 7, Bottom1 = 6, Bottom2 = 2, Left = 3, CorrectRotate = 300 },
					new BlockHexagon { PosX = -33f, PosY = -115f, X = -2, Y = 0, Top1 = 4, Top2 = 4, Right = 6, Bottom1 = 2, Bottom2 = 6, Left = 4, CorrectRotate = 180 },
					new BlockHexagon { PosX = 99f, PosY = 115f, X = 0, Y = 2, Top1 = 7, Top2 = 0, Right = 6, Bottom1 = 4, Bottom2 = 0, Left = 6, CorrectRotate = 60 },
					new BlockHexagon { PosX = 231f, PosY = 115f, X = 2, Y = 2, Top1 = 3, Top2 = 5, Right = 0, Bottom1 = 0, Bottom2 = 3, Left = 5, CorrectRotate = 60 },
					new BlockHexagon { PosX = 297f, PosY = 0, X = 3, Y = 1, Top1 = 6, Top2 = 7, Right = 5, Bottom1 = 7, Bottom2 = 4, Left = 6, CorrectRotate = 240 },
					new BlockHexagon { PosX = 33f, PosY = 0, X = -1, Y = 1, Top1 = 1, Top2 = 3, Right = 2, Bottom1 = 1, Bottom2 = 7, Left = 5, CorrectRotate = 300 },
					new BlockHexagon { PosX = 297f, PosY = -230, X = 3, Y = -1, Top1 = 4, Top2 = 0, Right = 6, Bottom1 = 2, Bottom2 = 7, Left = 6, CorrectRotate = 60 },
					new BlockHexagon { PosX = 231f, PosY = -345f, X = 2, Y = -2, Top1 = 7, Top2 = 1, Right = 2, Bottom1 = 5, Bottom2 = 3, Left = 4, CorrectRotate = 0 },
					new BlockHexagon { PosX = 99f, PosY = -345f, X = 0, Y = -2, Top1 = 3, Top2 = 3, Right = 0, Bottom1 = 3, Bottom2 = 3, Left = 2, CorrectRotate = 120 },
					new BlockHexagon { PosX = -33f, PosY = -345f, X = -2, Y = -2, Top1 = 6, Top2 = 1, Right = 4, Bottom1 = 2, Bottom2 = 5, Left = 0, CorrectRotate = 0 },
					new BlockHexagon { PosX = -99f, PosY = -230, X = -3, Y = -1, Top1 = 2, Top2 = 3, Right = 3, Bottom1 = 5, Bottom2 = 1, Left = 0, CorrectRotate = 60 },
					new BlockHexagon { PosX = -99f, PosY = 0, X = -3, Y = 1, Top1 = 6, Top2 = 3, Right = 0, Bottom1 = 6, Bottom2 = 0, Left = 5, CorrectRotate = 120 },
					new BlockHexagon { PosX = -165f, PosY = 115f, X = -4, Y = 2, Top1 = 5, Top2 = 7, Right = 3, Bottom1 = 5, Bottom2 = 1, Left = 3, CorrectRotate = 240 },
					new BlockHexagon { PosX = -33f, PosY = 115f, X = -2, Y = 2, Top1 = 2, Top2 = 3, Right = 5, Bottom1 = 0, Bottom2 = 2, Left = 1, CorrectRotate = 60 },
					new BlockHexagon { PosX = -231f, PosY = 230, X = -5, Y = 3, Top1 = 2, Top2 = 1, Right = 4, Bottom1 = 6, Bottom2 = 0, Left = 6, CorrectRotate = 120 },
					new BlockHexagon { PosX = -99f, PosY = 230, X = -3, Y = 3, Top1 = 3, Top2 = 5, Right = 7, Bottom1 = 4, Bottom2 = 4, Left = 7, CorrectRotate = 0 },
					new BlockHexagon { PosX = -231f, PosY = 0, X = -5, Y = 1, Top1 = 5, Top2 = 5, Right = 4, Bottom1 = 4, Bottom2 = 2, Left = 0, CorrectRotate = 60 },
					new BlockHexagon { PosX = 33f, PosY = 230, X = -1, Y = 3, Top1 = 7, Top2 = 2, Right = 0, Bottom1 = 5, Bottom2 = 2, Left = 7, CorrectRotate = 180 },
					new BlockHexagon { PosX = -165f, PosY = 345f, X = -4, Y = 4, Top1 = 2, Top2 = 6, Right = 0, Bottom1 = 0, Bottom2 = 4, Left = 1, CorrectRotate = 60 },
					new BlockHexagon { PosX = -297f, PosY = 115f, X = -6, Y = 2, Top1 = 2, Top2 = 2, Right = 6, Bottom1 = 7, Bottom2 = 1, Left = 5, CorrectRotate = 240 },
					new BlockHexagon { PosX = -33f, PosY = 345f, X = -2, Y = 4, Top1 = 5, Top2 = 2, Right = 2, Bottom1 = 7, Bottom2 = 2, Left = 7, CorrectRotate = 240 },
					new BlockHexagon { PosX = -165f, PosY = -115f, X = -4, Y = 0, Top1 = 1, Top2 = 1, Right = 4, Bottom1 = 0, Bottom2 = 5, Left = 5, CorrectRotate = 300 },
				}
			};
		}
	}
}