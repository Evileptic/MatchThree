using UnityEngine;

namespace ZlodeyPack
{
    [CreateAssetMenu]
    public class StaticData : ScriptableObject
    {
        [Header("Prefabs")]
        public SoundManager SoundManagerPrefab;
        public UI UIPrefab;
    }
}