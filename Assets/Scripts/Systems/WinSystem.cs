using Leopotam.Ecs;

namespace ZlodeyPack
{
    public class WinSystem : Injects, IEcsRunSystem
    {
        private EcsFilter<WinEvent> _eventFilter;
        public void Run()
        {
            foreach (var index in _eventFilter)
            {

                _eventFilter.GetEntity(index).Destroy();
            }
        }
    }
}