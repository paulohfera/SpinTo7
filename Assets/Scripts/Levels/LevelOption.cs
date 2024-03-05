using Assets.Scripts.Core;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.Scripts.Levels
{
	public class LevelOption : MonoBehaviour
	{
		public Difficulty Difficulty;
		public Text Title;
		public Text Score;
		public Image Locker;
		public bool Available;

		public void OnClick()
		{
			if (!Available) return;
			HudManager.Instance.Difficulty = Difficulty;
			SceneManager.LoadScene("Map");
		}
	}
}