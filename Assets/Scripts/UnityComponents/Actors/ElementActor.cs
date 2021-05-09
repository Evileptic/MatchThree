using Leopotam.Ecs;

namespace MatchThree
{
    public class ElementActor : Actor
    {
        public override void ExpandEntity(EcsEntity entity)
        {
            entity.Get<Element>().ActorRef = this;
        }
    }
}