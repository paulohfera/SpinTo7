using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Levels
{
	public class SceneController : MonoBehaviour
	{
		void Update()
		{
			if (Input.GetKeyDown(KeyCode.Escape))
			{
				Menu();
			}
		}

		public void Menu()
		{
			SceneManager.LoadScene("Main");
		}
	}
}