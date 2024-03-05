using Assets.Scripts.Core;
using System.IO;
using UnityEngine;

namespace Assets.Scripts.Data
{
	public static class Database
	{
		private static string DataFile = string.Format("{0}/{1}", Application.persistentDataPath, "data.ffs");

		//private static void Create()
		//{
		//	var data = SecurityHelper.Encrypt(new UserData().ToString());
		//	//var data = new UserData().ToString(); //**********************************************
		//	File.WriteAllText(DataFile, data);
		//}

		public static void Save(UserData userData)
		{
#if !UNITY_EDITOR
			var data = SecurityHelper.Encrypt(userData.ToString());
#else
			var data = userData.ToString(); //**********************************************
#endif
			File.WriteAllText(DataFile, data);
		}

		public static UserData GetData()
		{
			if (!File.Exists(DataFile))
			{
				//Create();
				return new UserData
				{
					Language = Application.systemLanguage
				};
			}

			var file = File.ReadAllText(DataFile);
#if !UNITY_EDITOR
			var data = SecurityHelper.Decrypt(file);
#else
			var data = file; //**********************************************
#endif

			return JsonUtility.FromJson<UserData>(data);
		}

		//public static void SaveLevel(int number, int stars)
		//{
		//	var userData = GetData();
		//	userData.SaveLevel(number, stars);
		//	Save(userData);
		//}
	}
}