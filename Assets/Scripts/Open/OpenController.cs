using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Open
{
	public class OpenController : MonoBehaviour
	{
		void Start()
		{
			StartCoroutine(GoToTitle());
		}

		private IEnumerator GoToTitle()
		{
			yield return new WaitForSeconds(1.5f);
			SceneManager.LoadScene("Main", LoadSceneMode.Single);
		}
	}
}