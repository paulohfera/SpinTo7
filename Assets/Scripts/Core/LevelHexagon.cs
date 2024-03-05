using System.Collections.Generic;

namespace Assets.Scripts.Core
{
	public class LevelHexagon
	{
		public int Number { get; set; }
		public int MatchsToWin { get; set; }
		public int ThreeStarsLimit { get; set; }
		public int TwoStarsLimit { get; set; }
		public float BlockWidth { get; set; }
		public float BlockHeight { get; set; }
		public List<BlockHexagon> Blocks { get; set; }
	}
}