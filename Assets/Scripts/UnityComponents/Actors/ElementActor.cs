using Leopotam.Ecs;
using UnityEngine;

namespace MatchThree
{
    [RequireComponent(typeof(Animator))]
    public class ElementActor : Actor
    {
        public Animator Animator;

        private void Start()
        {
            Animator = GetComponent<Animator>();
        }

        public override void ExpandEntity(EcsEntity entity)
        {
            entity.Get<Element>().ActorRef = this;
        }

        private void OnMouseEnter() => Animator.SetBool("Blink", true);
        private void OnMouseExit() => Animator.SetBool("Blink", false);
    }
}