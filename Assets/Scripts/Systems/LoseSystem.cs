using Leopotam.Ecs;

namespace ZlodeyPack
{
    public class LoseSystem : Injects, IEcsRunSystem
    {
        private EcsFilter<LoseEvent> _eventFilter;
        public void Run()
        {
            foreach (var index in _eventFilter)
            {

                _eventFilter.GetEntity(index).Destroy();
            }
        }
    }
}