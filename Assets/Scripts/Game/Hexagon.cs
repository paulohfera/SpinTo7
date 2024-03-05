using Assets.Scripts.Core;
using Assets.Scripts.Generator;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.Scripts.Game
{
	public class Hexagon : MonoBehaviour, IPointerDownHandler
	{
		internal Text[] Numbers;
		private bool isRotating;
		private List<Color> Colors;

		public int x;
		public int y;
		public int CorrectRotate;

		public int Top1 = 0;
		public int Top2 = 0;
		public int Right = 0;
		public int Bottom1 = 0;
		public int Bottom2 = 0;
		public int Left = 0;
		public Image Background;

		public Text Top1Text;
		public Text Top2Text;
		public Text RightText;
		public Text Bottom1Text;
		public Text Bottom2Text;
		public Text LeftText;
		public bool HasNumbers = false;

		public void Init()
		{
			InitColors();
			Background.color = GetRandomColor();
			//gameObject.GetComponentsInChildren<Image>()[1].color = GetRandomColor();

			Numbers = gameObject.GetComponentsInChildren<Text>();
			if (Numbers == null) return;

			Numbers[0].text = Top1.ToString();
			Numbers[1].text = Top2.ToString();
			Numbers[2].text = Right.ToString();
			Numbers[3].text = Bottom1.ToString();
			Numbers[4].text = Bottom2.ToString();
			Numbers[5].text = Left.ToString();

			Top1Text = Numbers[0];
			Top2Text = Numbers[1];
			RightText = Numbers[2];
			Bottom1Text = Numbers[3];
			Bottom2Text = Numbers[4];
			LeftText = Numbers[5];
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
			return Colors[Random.Range(0, 7)];
		}

		public void OnPointerDown(PointerEventData eventData)
		{
			OnClick();
		}

		public void OnClick()
		{
			if (isRotating) return;
			if (SoundController.Instance != null)
				SoundController.Instance.PlayAudio(Const.Music.Click);
			StartCoroutine(Rotate(60, 0.2f));
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
				Numbers[4].transform.localRotation = startRotN * qn;
				Numbers[5].transform.localRotation = startRotN * qn;

				progress += Time.deltaTime / duration;

				yield return null;
			}

			transform.rotation = startRot * Quaternion.AngleAxis(degrees, Vector3.forward);

			var numberRotation = startRotN * Quaternion.AngleAxis(degrees, Vector3.back);
			Numbers[0].transform.localRotation = numberRotation;
			Numbers[1].transform.localRotation = numberRotation;
			Numbers[2].transform.localRotation = numberRotation;
			Numbers[3].transform.localRotation = numberRotation;
			Numbers[4].transform.localRotation = numberRotation;
			Numbers[5].transform.localRotation = numberRotation;

			SetNumbers();
			SetTexts();

			if (SceneManager.GetActiveScene().name.StartsWith("Game"))
				BoardHexagon.Instance.CheckMatchs(this);

			if (SceneManager.GetActiveScene().name.StartsWith("Generator"))
				BoardGeneratorHexagon.Instance.CheckMatchs(this);

			isRotating = false;
		}

		public void SetNumbers()
		{
			var temp = Top1;
			Top1 = Top2;
			Top2 = Right;
			Right = Bottom1;
			Bottom1 = Bottom2;
			Bottom2 = Left;
			Left = temp;
		}

		public void SetTexts()
		{
			var temp = Top1Text;
			Top1Text = Top2Text;
			Top2Text = RightText;
			RightText = Bottom1Text;
			Bottom1Text = Bottom2Text;
			Bottom2Text = LeftText;
			LeftText = temp;
		}

		public bool IsCorrect()
		{
			return System.Math.Truncate(transform.eulerAngles.z) == CorrectRotate;
		}
	}
}