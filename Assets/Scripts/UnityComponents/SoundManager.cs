using UnityEngine;

namespace ZlodeyPack
{
    public class SoundManager : MonoBehaviour
    {
        public AudioSource ChannelOne;
        public AudioSource ChannelTwo;
        public AudioSource ChannelThree;

		public static SoundManager Instance = null;

		private void Awake()
		{
			if (Instance == null)
				Instance = this;

			DontDestroyOnLoad(gameObject);
		}
	}
}