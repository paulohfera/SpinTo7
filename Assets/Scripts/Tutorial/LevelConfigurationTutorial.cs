using Assets.Scripts.Core;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Tutorial
{
	public class LevelConfigurationTutorial : MonoBehaviour
	{
		public List<Level> Levels { get; set; }

		public LevelConfigurationTutorial()
		{
			Levels = new List<Level>
			{
				Level1(),
				Level2(),
				Level3(),
			};
		}

		private Level Level1()
		{
			return new Level
			{
				Number = 1,
				MatchsToWin = 1,
				ThreeStarsLimit = 4,
				TwoStarsLimit = 5,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = 0, PosY = -65, X = 0, Y = 0, Top = 5, Right = 2, Bottom = 7, Left = 1, CorrectRotate = 90 },
					new Block { PosX = 0, PosY =  65, X = 0, Y = 1, Top = 5, Right = 5, Bottom = 5, Left = 5, CorrectRotate = 0, Fixed = true }
				}
			};
		}

		private Level Level2()
		{
			return new Level
			{
				Number = 2,
				MatchsToWin = 2,
				ThreeStarsLimit = 4,
				TwoStarsLimit = 5,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = -130, PosY = 0, X = 0, Y = 0, Top = 5, Right = 5, Bottom = 5, Left = 5, CorrectRotate = 0, Fixed = true },
					new Block { PosX =    0, PosY = 0, X = 1, Y = 0, Top = 2, Right = 2, Bottom = 5, Left = 4, CorrectRotate = 180 },
					new Block { PosX =  130, PosY = 0, X = 2, Y = 0, Top = 3, Right = 3, Bottom = 3, Left = 3, CorrectRotate = 0, Fixed = true }
				}
			};
		}

		private Level Level3()
		{
			return new Level
			{
				Number = 3,
				MatchsToWin = 2,
				ThreeStarsLimit = 4,
				TwoStarsLimit = 5,
				BlockSizes = 130,
				Blocks = new List<Block>
				{
					new Block { PosX = -130, PosY = 0, X = 0, Y = 0, Top = 5, Right = 5, Bottom = 5, Left = 5, CorrectRotate = 0, Fixed = true },
					new Block { PosX =    0, PosY = 0, X = 1, Y = 0, Top = 2, Right = 5, Bottom = 4, Left = 2, CorrectRotate = 90 },
					new Block { PosX =  130, PosY = 0, X = 2, Y = 0, Top = 3, Right = 3, Bottom = 3, Left = 3, CorrectRotate = 0, Fixed = true }
				}
			};
		}
	}
}