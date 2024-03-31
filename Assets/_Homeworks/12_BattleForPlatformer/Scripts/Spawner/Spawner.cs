using System.Collections.Generic;
using UnityEngine;

namespace BattleForPlatformer
{
    public class Spawner : MonoBehaviour
    {
        [SerializeField] private List<SpawnPoint> _points;
        [SerializeField] private int _count = 3;

        private void Start() =>
            Spawn();

        private void Spawn()
        {
            List<SpawnPoint> points = new List<SpawnPoint>(_points);

            for (int i = 0; i < _count; i++)
            {
                SpawnPoint spawnPoint = points[Random.Range(0, points.Count)];
                spawnPoint.Spawn();
                points.Remove(spawnPoint);
            }
        }
    }
}
