using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Core
{
	public static class TransformExtension
	{
		public static Image FindImage(this Transform parent, string name)
		{
			var list = parent.GetComponentsInChildren<Image>(true);

			foreach (var item in list)
			{
				if (item.name == name)
				{
					return item;
				}
			}

			return null;
		}

		public static Text FindText(this Transform parent, string name)
		{
			var list = parent.GetComponentsInChildren<Text>(true);

			foreach (var item in list)
			{
				if (item.name == name)
				{
					return item;
				}
			}

			return null;
		}
	}
}