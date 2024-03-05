using Assets.Scripts.Core;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Levels.Hexagon
{
	public abstract class Level385
	{
		public static LevelHexagon GetLevel()
		{
			return new LevelHexagon
			{
				Number = 385,
				MatchsToWin = 62,
				ThreeStarsLimit = 68,
				TwoStarsLimit = 82,
				BlockWidth = 132,
				BlockHeight = 152,
				Blocks = new List<BlockHexagon>
				{
					new BlockHexagon { PosX = 165f, PosY = 287.5f, X = 0, Y = 0, Top1 = 5, Top2 = 4, Right = 6, Bottom1 = 2, Bottom2 = 1, Left = 0, CorrectRotate = 60 },
					new BlockHexagon { PosX = 231f, PosY = 172.5f, X = 1, Y = -1, Top1 = 2, Top2 = 2, Right = 1, Bottom1 = 1, Bottom2 = 6, Left = 6, CorrectRotate = 300 },
					new BlockHexagon { PosX = 297f, PosY = 57.5f, X = 2, Y = -2, Top1 = 0, Top2 = 6, Right = 4, Bottom1 = 5, Bottom2 = 3, Left = 7, CorrectRotate = 60 },
					new BlockHexagon { PosX = 165f, PosY = 57.5f, X = 0, Y = -2, Top1 = 4, Top2 = 2, Right = 6, Bottom1 = 7, Bottom2 = 4, Left = 6, CorrectRotate = 60 },
					new BlockHexagon { PosX = 33f, PosY = 57.5f, X = -2, Y = -2, Top1 = 3, Top2 = 3, Right = 2, Bottom1 = 3, Bottom2 = 6, Left = 0, CorrectRotate = 60 },
					new BlockHexagon { PosX = -33f, PosY = 172.5f, X = -3, Y = -1, Top1 = 2, Top2 = 7, Right = 1, Bottom1 = 3, Bottom2 = 4, Left = 4, CorrectRotate = 60 },
					new BlockHexagon { PosX = 99f, PosY = 172.5f, X = -1, Y = -1, Top1 = 5, Top2 = 4, Right = 5, Bottom1 = 7, Bottom2 = 1, Left = 5, CorrectRotate = 120 },
					new BlockHexagon { PosX = -99f, PosY = 287.5f, X = -4, Y = 0, Top1 = 5, Top2 = 6, Right = 1, Bottom1 = 1, Bottom2 = 0, Left = 3, CorrectRotate = 60 },
					new BlockHexagon { PosX = 33f, PosY = 287.5f, X = -2, Y = 0, Top1 = 2, Top2 = 6, Right = 6, Bottom1 = 0, Bottom2 = 0, Left = 2, CorrectRotate = 180 },
					new BlockHexagon { PosX = -165f, PosY = 172.5f, X = -5, Y = -1, Top1 = 3, Top2 = 3, Right = 4, Bottom1 = 5, Bottom2 = 1, Left = 7, CorrectRotate = 60 },
					new BlockHexagon { PosX = -165f, PosY = 402.5f, X = -5, Y = 1, Top1 = 1, Top2 = 4, Right = 6, Bottom1 = 1, Bottom2 = 5, Left = 6, CorrectRotate = 180 },
					new BlockHexagon { PosX = -33f, PosY = 402.5f, X = -3, Y = 1, Top1 = 1, Top2 = 4, Right = 1, Bottom1 = 2, Bottom2 = 7, Left = 6, CorrectRotate = 60 },
					new BlockHexagon { PosX = 99f, PosY = -57.5f, X = -1, Y = -3, Top1 = 1, Top2 = 2, Right = 2, Bottom1 = 1, Bottom2 = 1, Left = 3, CorrectRotate = 180 },
					new BlockHexagon { PosX = 33f, PosY = -172.5f, X = -2, Y = -4, Top1 = 1, Top2 = 5, Right = 2, Bottom1 = 5, Bottom2 = 3, Left = 4, CorrectRotate = 0 },
					new BlockHexagon { PosX = 165f, PosY = -172.5f, X = 0, Y = -4, Top1 = 6, Top2 = 5, Right = 6, Bottom1 = 7, Bottom2 = 7, Left = 3, CorrectRotate = 120 },
					new BlockHexagon { PosX = -33f, PosY = -287.5f, X = -3, Y = -5, Top1 = 0, Top2 = 7, Right = 1, Bottom1 = 4, Bottom2 = 3, Left = 7, CorrectRotate = 120 },
					new BlockHexagon { PosX = -99f, PosY = -172.5f, X = -4, Y = -4, Top1 = 4, Top2 = 2, Right = 5, Bottom1 = 3, Bottom2 = 6, Left = 4, CorrectRotate = 60 },
					new BlockHexagon { PosX = 231f, PosY = -57.5f, X = 1, Y = -3, Top1 = 4, Top2 = 3, Right = 0, Bottom1 = 5, Bottom2 = 3, Left = 0, CorrectRotate = 60 },
					new BlockHexagon { PosX = 99f, PosY = -287.5f, X = -1, Y = -5, Top1 = 3, Top2 = 3, Right = 4, Bottom1 = 2, Bottom2 = 1, Left = 1, CorrectRotate = 180 },
					new BlockHexagon { PosX = -165f, PosY = -287.5f, X = -5, Y = -5, Top1 = 6, Top2 = 3, Right = 0, Bottom1 = 3, Bottom2 = 3, Left = 7, CorrectRotate = 0 },
					new BlockHexagon { PosX = -165f, PosY = -57.5f, X = -5, Y = -3, Top1 = 1, Top2 = 5, Right = 2, Bottom1 = 5, Bottom2 = 2, Left = 6, CorrectRotate = 240 },
					new BlockHexagon { PosX = -33f, PosY = -57.5f, X = -3, Y = -3, Top1 = 2, Top2 = 6, Right = 6, Bottom1 = 7, Bottom2 = 5, Left = 6, CorrectRotate = 120 },
					new BlockHexagon { PosX = 231f, PosY = -287.5f, X = 1, Y = -5, Top1 = 6, Top2 = 4, Right = 1, Bottom1 = 1, Bottom2 = 4, Left = 0, CorrectRotate = 60 },
					new BlockHexagon { PosX = 33f, PosY = -402.5f, X = -2, Y = -6, Top1 = 4, Top2 = 1, Right = 3, Bottom1 = 5, Bottom2 = 7, Left = 0, CorrectRotate = 300 },
					new BlockHexagon { PosX = -99f, PosY = -402.5f, X = -4, Y = -6, Top1 = 4, Top2 = 5, Right = 4, Bottom1 = 4, Bottom2 = 7, Left = 0, CorrectRotate = 180 },
					new BlockHexagon { PosX = -297f, PosY = -287.5f, X = -7, Y = -5, Top1 = 7, Top2 = 1, Right = 1, Bottom1 = 5, Bottom2 = 0, Left = 2, CorrectRotate = 120 },
					new BlockHexagon { PosX = -231f, PosY = 57.5f, X = -6, Y = -2, Top1 = 1, Top2 = 0, Right = 5, Bottom1 = 5, Bottom2 = 3, Left = 3, CorrectRotate = 0 },
					new BlockHexagon { PosX = -231f, PosY = -172.5f, X = -6, Y = -4, Top1 = 2, Top2 = 2, Right = 3, Bottom1 = 5, Bottom2 = 3, Left = 1, CorrectRotate = 120 },
					new BlockHexagon { PosX = 297f, PosY = -172.5f, X = 2, Y = -4, Top1 = 6, Top2 = 7, Right = 6, Bottom1 = 0, Bottom2 = 4, Left = 6, CorrectRotate = 240 },
				}
			};
		}
	}
}