using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GeneratingEnemiesPro
{
    public class Spawner : MonoBehaviour
    {
        [SerializeField] private float _respawnTime = 2f;
        [SerializeField] private int _count = 5;
        [SerializeField] private List<Transform> _points;
        [SerializeField] private List<Enemy> _prefabs;
        [SerializeField] private Transform _pointCollection;

        private void Start()
        {
            StartCoroutine(Spawn());
        }

        private IEnumerator Spawn()
        {
            var waitTime = new WaitForSeconds(_respawnTime);

            for (int i = 0; i < _count; i++)
            {
                Transform spawnPoint = _points[Random.Range(0, _points.Count)];
                Enemy prefab = _prefabs[Random.Range(0, _prefabs.Count)];

                Enemy enemy = Instantiate(prefab, spawnPoint.position, Quaternion.identity);
                enemy.SetTarget(_pointCollection.position);

                yield return waitTime;
            }
        }
    }
}
