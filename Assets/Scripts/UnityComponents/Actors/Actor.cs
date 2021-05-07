using Leopotam.Ecs;
using NaughtyAttributes;
using System;
using System.Collections;
using UnityEngine;

namespace ZlodeyPack
{
    public abstract class Actor : MonoBehaviour
    {
        public EcsEntity Entity;
        public EcsWorld World;

        public void Init(EcsWorld world)
        {
            World = world;
            Entity = World.NewEntity();
            ExpandEntity(Entity);
        }

        public abstract void ExpandEntity(EcsEntity entity);

        public void SelfDestroy(float delay = 0f) => StartCoroutine(SelfDestroyCoroutine(delay));

        public IEnumerator SelfDestroyCoroutine(float delay)
        {
            yield return new WaitForSeconds(delay);
            Entity.Destroy();
            Destroy(gameObject);
        }

        public virtual void Update()
        {
            ViewEcsComponents();
        }

        #region EcsComponentsView
        [Header("Ecs Components")]
        [SerializeField]
        [ResizableTextArea]
        private string _;

        private void ViewEcsComponents()
        {
#if UNITY_EDITOR
            if (Entity.IsAlive())
            {
                _ = default;
                Type[] types = default;
                Entity.GetComponentTypes(ref types);
                foreach (var type in types)
                    _ += $"{type.Name}\n";
            }
#endif
        }
        #endregion
    }
}