using System.Collections;
using UnityEngine;

namespace GeneratingEnemies
{
    public class Spawner : MonoBehaviour
    {
        [SerializeField] private float _respawnTime = 2f;
        [SerializeField] private Enemy _prefab;

        private void Start()
        {
            StartCoroutine(Spawn());
        }

        private IEnumerator Spawn()
        {
            var waitTime = new WaitForSeconds(_respawnTime);

            foreach (Transform spawnPoint in transform)
            {
                Instantiate(_prefab, spawnPoint.position, Quaternion.identity);

                yield return waitTime;
            }
        }
    }
}
