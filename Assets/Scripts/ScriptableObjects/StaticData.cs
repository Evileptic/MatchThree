using UnityEngine;

namespace MatchThree
{
    [CreateAssetMenu]
    public class StaticData : ScriptableObject
    {
        [Header("Board Props")]
        public int BoardHeight;
        public int BoardWidth;

        [Header("Prefabs")]
        public SoundManager SoundManagerPrefab;
        public UI UIPrefab;
        public GameObject RowPrefab;
        public GameObject CellPrefab;
        public ElementActor[] ElementPrefabs;
    }
}