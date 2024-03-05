using Assets.Scripts.Core;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Scripts.Levels
{
	public class BlockContentController : MonoBehaviour
	{
		private Transform Container;
		private List<LevelConfig> Levels;

		private void Start()
		{
			Levels = new List<LevelConfig>
			{
				new LevelConfig { Difficulty = Difficulty.Easy, Title = "Easy mode" },
				new LevelConfig { Difficulty = Difficulty.Moderate, Title = "Negative numbers" },
				new LevelConfig { Difficulty = Difficulty.Hard, Title = "No highlight numbers" },
				new LevelConfig { Difficulty = Difficulty.Hexagon, Title = "Hexagons" },
				new LevelConfig { Difficulty = Difficulty.Corner, Title = "Two per block" },
			};

			if (HudManager.Instance.UserData.Language == SystemLanguage.Portuguese)
			{
				Levels[0].Title = "Modo fácil";
				Levels[1].Title = "Números negativos";
				Levels[2].Title = "Sem números destacados";
				Levels[3].Title = "Hexágonos";
				Levels[4].Title = "Dois por bloco";
			}

			CreateBoard();
		}

		private void CreateBoard()
		{
			Container = GetComponent<Transform>();
			var userData = HudManager.Instance.UserData;
			var openNextLevel = true;
			foreach (var item in Levels)
			{
				HudManager.Instance.Difficulty = item.Difficulty;

				var levels = "100";
				var score = userData.Levels
						.Count(x => x.Number >= HudManager.Instance.Minlevel && x.Number <= HudManager.Instance.Maxlevel)
						.ToString();

				if (item.Difficulty == Difficulty.Soon)
				{
					levels = "?";
					score = "?";
					openNextLevel = false;
				}

				var level = Instantiate(Resources.Load("LevelOption"), Container) as GameObject;
				var option = level.GetComponent<LevelOption>();
				option.Title.text = item.Title;
				option.Difficulty = item.Difficulty;
				option.Score.text = string.Format("{0}/{1}", score, levels);
				option.Available = openNextLevel;
				if (openNextLevel) option.Locker.transform.gameObject.SetActive(false);

				//openNextLevel = (userData.HasDonated || levels == score);
			}
		}
	}
}