using Leopotam.Ecs;
using UnityEngine;

namespace MatchThree
{
    public class BoardActor : Actor
    {
        [Header("Actor Refs")]
        public Transform VerticalGroupTransform;

        public override void ExpandEntity(EcsEntity entity)
        {
            entity.Get<Board>().ActorRef = this;
        }
    }
}