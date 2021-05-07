using Leopotam.Ecs;
using UnityEngine;

namespace ZlodeyPack
{
    public class InitializeSystem : Injects, IEcsInitSystem
    {
        public void Init()
        {
            // Initialize Actors
            var actors = Object.FindObjectsOfType<Actor>();
            foreach (var actor in actors)
                actor.Init(World);

            // Initialize Actors UI screens
            var screens = Object.FindObjectsOfType<Screen>();
            foreach (var screen in screens)
                screen.Init(World);
        }
    }
}