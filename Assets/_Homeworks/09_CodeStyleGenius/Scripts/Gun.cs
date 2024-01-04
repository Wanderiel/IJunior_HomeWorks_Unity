using System.Collections;
using UnityEngine;

namespace CodeStyleGenius
{
    public class Gun : MonoBehaviour
    {
        [SerializeField] private float _cooldown = 2f;
        [SerializeField] private Bullet _bullet;
        [SerializeField] private Transform _target;

        private WaitForSeconds _sleep;

        private void Awake()
        {
            _sleep = new WaitForSeconds(_cooldown);
        }

        private void Start()
        {
            StartCoroutine(Shoot());
        }

        private IEnumerator Shoot()
        {
            while (enabled)
            {
                Vector3 targetDirection = (_target.position - transform.position).normalized;
                Bullet bullet = Instantiate(_bullet, transform.position + targetDirection, Quaternion.identity);

                bullet.SetTargetDirection(targetDirection);

                yield return _sleep;
            }
        }
    }
}
