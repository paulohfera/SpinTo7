using Assets.Scripts.Core;
using Assets.Scripts.Generator;
using Assets.Scripts.Tutorial;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.Scripts.Game
{
	public class TileCorner : MonoBehaviour, IPointerDownHandler
	{
		internal Text[] Numbers;
		private bool isRotating;
		private List<Color> Colors;

		public int x;
		public int y;
		public int CorrectRotate;

		public int Corner1 = 0;
		public int Corner2 = 0;
		public int Corner3 = 0;
		public int Corner4 = 0;

		public Text Corner1Text;
		public Text Corner2Text;
		public Text Corner3Text;
		public Text Corner4Text;
		public bool Fixed = false;
		//public int SpinCount;
		public bool HasNumbers = false;

		public void Init()
		{
			InitColors();
			gameObject.GetComponentsInChildren<Image>()[1].color = GetRandomColor();

			Numbers = gameObject.GetComponentsInChildren<Text>();
			if (Numbers == null) return;

			Numbers[0].text = Corner1.ToString();
			Numbers[1].text = Corner2.ToString();
			Numbers[2].text = Corner3.ToString();
			Numbers[3].text = Corner4.ToString();

			Corner1Text = Numbers[0];
			Corner2Text = Numbers[1];
			Corner3Text = Numbers[2];
			Corner4Text = Numbers[3];
		}

		private void InitColors()
		{
			Colors = new List<Color>
		{
			new Color32(248, 212, 27, 255), //Yellow
			new Color32(107, 137, 210, 255), //Blue
			new Color32(181, 55, 137, 255), //Pink
			new Color32(23, 166, 151, 255), //Green
			new Color32(237, 106, 117, 255), //Red
			new Color32(143, 212, 217, 255), //Cyan
			new Color32(128, 122, 123, 255), //Gray
			new Color32(249, 158, 77, 255), //Orange
		};
		}

		public Color GetRandomColor()
		{
			return Colors[UnityEngine.Random.Range(0, 7)];
		}

		public void OnPointerDown(PointerEventData eventData)
		{
			if (isRotating || Fixed) return;
			if (SoundController.Instance != null)
				SoundController.Instance.PlayAudio(Const.Music.Click);
			StartCoroutine(Rotate(90, 0.2f));
			//SpinCount++;
		}

		public IEnumerator Rotate(float degrees, float duration)
		{
			isRotating = true;
			Quaternion startRot = transform.rotation;
			Quaternion startRotN = Numbers[0].transform.localRotation;
			float progress = 0;

			while (progress <= 1)
			{
				float d = Mathf.Lerp(0, degrees, progress);
				Quaternion q = Quaternion.AngleAxis(d, Vector3.forward);
				transform.rotation = startRot * q;

				Quaternion qn = Quaternion.AngleAxis(d, Vector3.back);
				Numbers[0].transform.localRotation = startRotN * qn;
				Numbers[1].transform.localRotation = startRotN * qn;
				Numbers[2].transform.localRotation = startRotN * qn;
				Numbers[3].transform.localRotation = startRotN * qn;

				progress += Time.deltaTime / duration;

				yield return null;
			}

			transform.rotation = startRot * Quaternion.AngleAxis(degrees, Vector3.forward);

			var numberRotation = startRotN * Quaternion.AngleAxis(degrees, Vector3.back);
			Numbers[0].transform.localRotation = numberRotation;
			Numbers[1].transform.localRotation = numberRotation;
			Numbers[2].transform.localRotation = numberRotation;
			Numbers[3].transform.localRotation = numberRotation;

			SetNumbers();
			SetTexts();

			if (SceneManager.GetActiveScene().name.StartsWith("Game"))
				BoardCorner.Instance.CheckMatchs(this, false, true);

			if (SceneManager.GetActiveScene().name.StartsWith("Generator"))
				BoardGeneratorCorner.Instance.CheckMatchs(this, true);

			isRotating = false;
		}

		public void SetNumbers()
		{
			var temp = Corner1;
			Corner1 = Corner2;
			Corner2 = Corner3;
			Corner3 = Corner4;
			Corner4 = temp;
		}

		public void SetTexts()
		{
			var temp = Corner1Text;
			Corner1Text = Corner2Text;
			Corner2Text = Corner3Text;
			Corner3Text = Corner4Text;
			Corner4Text = temp;
		}

		public bool IsCorrect()
		{
			return transform.eulerAngles.z == CorrectRotate;
		}
	}
}