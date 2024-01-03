using UnityEngine;

namespace GeneratingEnemiesPro
{
    public class SpawnPoint : MonoBehaviour
    {
        [SerializeField] private Enemy _prefab;
        [SerializeField] private Transform _target;

        public void Spawn()
        {
            Enemy enemy = Instantiate(_prefab, transform.position, Quaternion.identity);
            enemy.SetTarget(_target);
        }
    }
}
