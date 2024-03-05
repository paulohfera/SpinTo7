using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Map
{
	class SceneController : MonoBehaviour
	{
		void Update()
		{
			if (Input.GetKeyDown(KeyCode.Escape))
			{
				SceneManager.LoadScene("Main");
			}
		}

		public void OnMainClick()
		{
			SceneManager.LoadScene("Main", LoadSceneMode.Single);
		}
	}
}