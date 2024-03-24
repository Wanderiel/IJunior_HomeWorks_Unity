using UnityEngine;

namespace BattleForPlatformer
{
    public class SpawnPoint : MonoBehaviour
    {
        [SerializeField] private Apple _prefab;

        public void Spawn() =>
            Instantiate(_prefab, transform.position, Quaternion.identity);
    }
}
