using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Core
{
	public class ModalHelper : MonoBehaviour
	{
		internal IEnumerator ShowModal(Transform panel)
		{
			yield return ShowModal(panel, 0);
		}

		internal IEnumerator ShowModal(Transform panel, float y)
		{
			yield return StartCoroutine(MoveRoutine(panel, new Vector3(0, y - 40, 0), 0.2f));
			yield return StartCoroutine(MoveRoutine(panel, new Vector3(0, y, 0), 0.2f));
		}

		internal IEnumerator HideModal(Transform panel)
		{
			var rectTransform = panel.GetComponent<RectTransform>();
			var x = 640 + rectTransform.rect.height + 20;
			var y = panel.transform.localPosition.y;
			yield return StartCoroutine(MoveRoutine(panel, new Vector3(0, y + 40f, 0), 0.2f));
			yield return StartCoroutine(MoveRoutine(panel, new Vector3(0, -x, 0), 0.2f));
		}

		private IEnumerator MoveRoutine(Transform transform, Vector3 destination, float timeToMove)
		{
			Vector3 startPosition = transform.localPosition;

			bool reachedDestination = false;

			float elapsedTime = 0f;

			while (!reachedDestination)
			{
				if (Vector3.Distance(transform.localPosition, destination) < 0.01f)
				{
					reachedDestination = true;
					transform.localPosition = destination;
				}

				elapsedTime += Time.deltaTime;

				float t = Mathf.Clamp(elapsedTime / timeToMove, 0f, 1f);

				transform.localPosition = Vector3.Lerp(startPosition, destination, t);

				yield return null;
			}
		}

		internal IEnumerator ShowStar(Image star)
		{
			yield return StartCoroutine(ScaleRoutine(star.transform, new Vector3(1.5f, 1.5f, 0), 0.3f));
			yield return StartCoroutine(ScaleRoutine(star.transform, new Vector3(1, 1, 0), 0.3f));
		}

		private IEnumerator ScaleRoutine(Transform transform, Vector3 destination, float timeToMove)
		{
			Vector3 startPosition = transform.localScale;

			bool reachedDestination = false;

			float elapsedTime = 0f;

			while (!reachedDestination)
			{
				if (Vector3.Distance(transform.localScale, destination) < 0.01f)
				{
					reachedDestination = true;
					transform.localScale = destination;
				}

				elapsedTime += Time.deltaTime;

				float t = Mathf.Clamp(elapsedTime / timeToMove, 0f, 1f);

				transform.localScale = Vector3.Lerp(startPosition, destination, t);

				yield return null;
			}
		}
	}
}