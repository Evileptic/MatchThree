using Leopotam.Ecs;
using UnityEngine;

namespace MatchThree
{
    public class CreateBoardSystem : Injects, IEcsRunSystem
    {
        private EcsFilter<CreateBoardEvent> _eventFilter;

        public void Run()
        {
            foreach (var index in _eventFilter)
            {
                Runtime.Cells = new GameObject[Static.BoardHeight, Static.BoardWidth];

                for (int i = 0; i < Static.BoardHeight; i++)
                {
                    var row = Object.Instantiate(Static.RowPrefab, Scene.BoardActorRef.VerticalGroupTransform);

                    for (int j = 0; j < Static.BoardWidth; j++)
                    {
                        var cell = Object.Instantiate(Static.CellPrefab, row.transform);
                        Runtime.Cells[i, j] = cell;
                        Object.Instantiate(Static.ElementPrefabs[Random.Range(0, Static.ElementPrefabs.Length)], cell.transform);
                    }
                }

                _eventFilter.GetEntity(index).Destroy();
            }
        }
    }
}