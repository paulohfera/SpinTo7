using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hexagon
{
	public abstract class Level389
	{
		public static LevelHexagon GetLevel()
		{
			return new LevelHexagon
			{
				Number = 389,
				MatchsToWin = 60,
				ThreeStarsLimit = 65,
				TwoStarsLimit = 79,
				BlockWidth = 105,
				BlockHeight = 121,
				Blocks = new List<BlockHexagon>
				{
					new BlockHexagon { PosX = -262.5f, PosY = 182, X = 0, Y = 0, Top1 = 2, Top2 = 6, Right = 3, Bottom1 = 4, Bottom2 = 1, Left = 5, CorrectRotate = 120 },
					new BlockHexagon { PosX = -314.5f, PosY = 273f, X = -1, Y = 1, Top1 = 4, Top2 = 7, Right = 3, Bottom1 = 3, Bottom2 = 2, Left = 4, CorrectRotate = 120 },
					new BlockHexagon { PosX = -210.5f, PosY = 273f, X = 1, Y = 1, Top1 = 4, Top2 = 6, Right = 5, Bottom1 = 0, Bottom2 = 3, Left = 5, CorrectRotate = 0 },
					new BlockHexagon { PosX = -158.5f, PosY = 182, X = 2, Y = 0, Top1 = 7, Top2 = 2, Right = 6, Bottom1 = 1, Bottom2 = 4, Left = 6, CorrectRotate = 0 },
					new BlockHexagon { PosX = -106.5f, PosY = 273f, X = 3, Y = 1, Top1 = 2, Top2 = 4, Right = 3, Bottom1 = 1, Bottom2 = 3, Left = 5, CorrectRotate = 60 },
					new BlockHexagon { PosX = -54.5f, PosY = 182, X = 4, Y = 0, Top1 = 4, Top2 = 5, Right = 2, Bottom1 = 0, Bottom2 = 3, Left = 1, CorrectRotate = 0 },
					new BlockHexagon { PosX = 49.5f, PosY = 182, X = 6, Y = 0, Top1 = 5, Top2 = 5, Right = 5, Bottom1 = 5, Bottom2 = 2, Left = 2, CorrectRotate = 120 },
					new BlockHexagon { PosX = -2.5f, PosY = 91f, X = 5, Y = -1, Top1 = 4, Top2 = 7, Right = 2, Bottom1 = 4, Bottom2 = 7, Left = 0, CorrectRotate = 60 },
					new BlockHexagon { PosX = -106.5f, PosY = 91f, X = 3, Y = -1, Top1 = 0, Top2 = 6, Right = 4, Bottom1 = 3, Bottom2 = 5, Left = 1, CorrectRotate = 60 },
					new BlockHexagon { PosX = 101.5f, PosY = 273f, X = 7, Y = 1, Top1 = 7, Top2 = 0, Right = 2, Bottom1 = 5, Bottom2 = 2, Left = 5, CorrectRotate = 0 },
					new BlockHexagon { PosX = 153.5f, PosY = 182, X = 8, Y = 0, Top1 = 7, Top2 = 4, Right = 5, Bottom1 = 2, Bottom2 = 6, Left = 5, CorrectRotate = 180 },
					new BlockHexagon { PosX = 101.5f, PosY = 91f, X = 7, Y = -1, Top1 = 3, Top2 = 5, Right = 3, Bottom1 = 0, Bottom2 = 4, Left = 5, CorrectRotate = 60 },
					new BlockHexagon { PosX = 49.5f, PosY = 0, X = 6, Y = -2, Top1 = 4, Top2 = 2, Right = 0, Bottom1 = 2, Bottom2 = 0, Left = 1, CorrectRotate = 120 },
					new BlockHexagon { PosX = -2.5f, PosY = -91f, X = 5, Y = -3, Top1 = 3, Top2 = 3, Right = 2, Bottom1 = 6, Bottom2 = 0, Left = 3, CorrectRotate = 240 },
					new BlockHexagon { PosX = 49.5f, PosY = -182, X = 6, Y = -4, Top1 = 7, Top2 = 4, Right = 7, Bottom1 = 4, Bottom2 = 4, Left = 7, CorrectRotate = 180 },
					new BlockHexagon { PosX = -54.5f, PosY = -182, X = 4, Y = -4, Top1 = 6, Top2 = 5, Right = 5, Bottom1 = 0, Bottom2 = 5, Left = 2, CorrectRotate = 60 },
					new BlockHexagon { PosX = -106.5f, PosY = -91f, X = 3, Y = -3, Top1 = 1, Top2 = 2, Right = 5, Bottom1 = 1, Bottom2 = 1, Left = 2, CorrectRotate = 120 },
					new BlockHexagon { PosX = 205.5f, PosY = 273f, X = 9, Y = 1, Top1 = 1, Top2 = 5, Right = 0, Bottom1 = 7, Bottom2 = 5, Left = 7, CorrectRotate = 120 },
					new BlockHexagon { PosX = 205.5f, PosY = 91f, X = 9, Y = -1, Top1 = 4, Top2 = 7, Right = 0, Bottom1 = 7, Bottom2 = 7, Left = 6, CorrectRotate = 120 },
					new BlockHexagon { PosX = 153.5f, PosY = 0, X = 8, Y = -2, Top1 = 0, Top2 = 2, Right = 7, Bottom1 = 3, Bottom2 = 3, Left = 1, CorrectRotate = 180 },
					new BlockHexagon { PosX = 101.5f, PosY = -91f, X = 7, Y = -3, Top1 = 4, Top2 = 6, Right = 5, Bottom1 = 3, Bottom2 = 2, Left = 3, CorrectRotate = 60 },
					new BlockHexagon { PosX = -54.5f, PosY = 0, X = 4, Y = -2, Top1 = 7, Top2 = 5, Right = 7, Bottom1 = 6, Bottom2 = 7, Left = 2, CorrectRotate = 300 },
					new BlockHexagon { PosX = -2.5f, PosY = -273f, X = 5, Y = -5, Top1 = 5, Top2 = 2, Right = 3, Bottom1 = 4, Bottom2 = 5, Left = 0, CorrectRotate = 60 },
					new BlockHexagon { PosX = -106.5f, PosY = -273f, X = 3, Y = -5, Top1 = 5, Top2 = 0, Right = 3, Bottom1 = 5, Bottom2 = 2, Left = 1, CorrectRotate = 120 },
					new BlockHexagon { PosX = -158.5f, PosY = -182, X = 2, Y = -4, Top1 = 6, Top2 = 1, Right = 4, Bottom1 = 4, Bottom2 = 6, Left = 4, CorrectRotate = 300 },
					new BlockHexagon { PosX = -158.5f, PosY = 0, X = 2, Y = -2, Top1 = 6, Top2 = 6, Right = 0, Bottom1 = 2, Bottom2 = 5, Left = 2, CorrectRotate = 0 },
					new BlockHexagon { PosX = 153.5f, PosY = 364, X = 8, Y = 2, Top1 = 7, Top2 = 5, Right = 5, Bottom1 = 3, Bottom2 = 3, Left = 7, CorrectRotate = 120 },
					new BlockHexagon { PosX = 309.5f, PosY = 273f, X = 11, Y = 1, Top1 = 7, Top2 = 4, Right = 7, Bottom1 = 2, Bottom2 = 2, Left = 7, CorrectRotate = 300 },
					new BlockHexagon { PosX = 49.5f, PosY = -364, X = 6, Y = -6, Top1 = 7, Top2 = 2, Right = 2, Bottom1 = 4, Bottom2 = 0, Left = 1, CorrectRotate = 60 },
					new BlockHexagon { PosX = 153.5f, PosY = -364, X = 8, Y = -6, Top1 = 7, Top2 = 0, Right = 6, Bottom1 = 4, Bottom2 = 7, Left = 3, CorrectRotate = 0 },
				}
			};
		}
	}
}