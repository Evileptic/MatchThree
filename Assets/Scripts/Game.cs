using Leopotam.Ecs;
using UnityEngine;

namespace ZlodeyPack
{
    sealed class Game : MonoBehaviour
    {
        EcsWorld _world;
        EcsSystems _systems;

        public StaticData _static;
        public SceneData _scene;

        void Start()
        {
            _world = new EcsWorld();
            _systems = new EcsSystems(_world);
#if UNITY_EDITOR
            Leopotam.Ecs.UnityIntegration.EcsWorldObserver.Create(_world);
            Leopotam.Ecs.UnityIntegration.EcsSystemsObserver.Create(_systems);
#endif
            var _runtime = new RuntimeData();

            var _soundManager = SoundManager.Instance
                              ? SoundManager.Instance
                              : Instantiate(_static.SoundManagerPrefab);

            UI _ui = Instantiate(_static.UIPrefab);

            _systems
                .Add(new InitializeSystem())                

                .Add(new StartGameSystem())

                .Add(new WinSystem())
                .Add(new LoseSystem())

                .Inject(_soundManager)
                .Inject(_runtime)
                .Inject(_static)
                .Inject(_scene)
                .Inject(_ui)
                .Init();
        }

        void Update() => _systems?.Run();

        void OnDestroy()
        {
            if (_systems != null)
            {
                _systems.Destroy();
                _systems = null;
                _world.Destroy();
                _world = null;
            }
        }
    }
}