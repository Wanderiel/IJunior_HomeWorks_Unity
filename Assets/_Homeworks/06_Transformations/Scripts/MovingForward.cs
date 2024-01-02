using UnityEngine;

namespace Transformations
{
    public class MovingForward : MonoBehaviour
    {
        [SerializeField] private float _speed = 1f;

        private void Update()
        {
            transform.Translate(Vector3.forward * _speed * Time.deltaTime);
        }
    }
}
