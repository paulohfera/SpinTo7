using System.Collections.Generic;

namespace Assets.Scripts.Core
{
	public class Level
	{
		public int Number { get; set; }
		public int MatchsToWin { get; set; }
		public int ThreeStarsLimit { get; set; }
		public int TwoStarsLimit { get; set; }
		public float BlockSizes { get; set; }
		public List<Block> Blocks { get; set; }
	}
}