using Leopotam.Ecs;
using UnityEngine;

namespace MatchThree
{
    public class InitializeSystem : Injects, IEcsInitSystem
    {
        public void Init()
        {
            var actors = Object.FindObjectsOfType<Actor>();
            foreach (var actor in actors)
                actor.Init(World);

            var screens = Object.FindObjectsOfType<Screen>();
            foreach (var screen in screens)
                screen.Init(World);

            World.NewEntity().Get<CreateBoardEvent>();
        }
    }
}