using Assets.Scripts.Core;
using System;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Map
{
	public class BlockContentController : MonoBehaviour
	{
		private Transform Container;

		public Text StarsScore;
		public Sprite StarIcon;

		void Start()
		{
			Container = GetComponent<Transform>();
			var userData = HudManager.Instance.UserData;
			var levelsInMode = userData.Levels.Where(x => x.Number < HudManager.Instance.Maxlevel).ToList();
			var maxLevel = levelsInMode.Count == 0 ? 1 : levelsInMode.Max(x => x.Number) + 1;

			var levels = HudManager.Instance.Maxlevel - HudManager.Instance.Minlevel + 1;
			var score = 0;

			for (int i = HudManager.Instance.Minlevel; i <= HudManager.Instance.Maxlevel; i++)
			{
				if (i > maxLevel && !userData.HasDonated && i != HudManager.Instance.Minlevel)
				{
					Instantiate(Resources.Load("BlockLocked"), Container);
					continue;
				}

				var block = Instantiate(Resources.Load("BlockOpened"), Container) as GameObject;
				block.GetComponentInChildren<Text>().text = Convert.ToString(i);
				block.GetComponent<Block>().Number = i;
				var starPanel = block.transform.Find("Stars");

				var level = userData.Levels.SingleOrDefault(x => x.Number == i);
				var levelScore = level == null ? 0 : level.Star;
				score += levelScore;

				for (int s = 1; s <= levelScore; s++)
				{
					AddStar(starPanel);
				}
			}

			StarsScore.text = string.Format("{0}/{1}", score, levels * 3);
		}

		private void AddStar(Transform parent)
		{
			var star = new GameObject();
			star.transform.SetParent(parent);
			star.AddComponent<Image>().sprite = StarIcon;
			star.GetComponent<RectTransform>().sizeDelta = new Vector2(26, 26);
			star.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
		}
	}
}