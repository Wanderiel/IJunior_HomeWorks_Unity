using System.Collections.Generic;
using UnityEngine;

namespace BattleForPlatformer
{
    public class Spawner : MonoBehaviour
    {
        [SerializeField] private List<SpawnPoint> _points;
        [SerializeField] private int _count = 3;

        private void Awake()
        {
            
        }

        private void Spawn()
        {
            for (int i = 0; i < _count; i++)
            {

            }
        }
    }
}
