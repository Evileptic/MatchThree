using Leopotam.Ecs;

namespace MatchThree
{
    public class StartGameSystem : Injects, IEcsRunSystem
    {
        private EcsFilter<StartGameEvent> _eventFilter;
        public void Run()
        {
            foreach (var index in _eventFilter)
            {

                _eventFilter.GetEntity(index).Destroy();
            }
        }
    }
}