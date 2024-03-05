using Assets.Scripts.Core;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Map
{
	public class Block : MonoBehaviour
	{
		public int Number;

		public void OnClick()
		{
			HudManager.Instance.GameLevel = Number;
			if (HudManager.Instance.Difficulty == Difficulty.Hexagon)
			{
				SceneManager.LoadScene("GameHexagon");
				return;
			}

			if (HudManager.Instance.Difficulty == Difficulty.Corner)
			{
				SceneManager.LoadScene("GameCorner");
				return;
			}

			SceneManager.LoadScene("Game");
		}
	}
}