using UnityEngine;

namespace Assets.Scripts.Core
{
	public class SoundController : MonoBehaviour
	{
		private static SoundController _instance;
		public static SoundController Instance { get { return _instance; } }

		private AudioSource AudioSource;
		public bool StopAtAll;

		public AudioClip[] Sounds;

		void Awake()
		{
			if (_instance != null && _instance != this)
			{
				Destroy(gameObject);
			}
			else
			{
				_instance = this;
				DontDestroyOnLoad(gameObject);
				AudioSource = GetComponent<AudioSource>();
			}
		}

		public void PlayAudio(Const.Music music)
		{
			if (StopAtAll) return;

			AudioSource.Stop();
			AudioSource.clip = Sounds[(int)music];
			AudioSource.Play();
		}

		public void Stop()
		{
			StopAtAll = true;
		}

		public void UnStop()
		{
			StopAtAll = false;
		}
	}
}