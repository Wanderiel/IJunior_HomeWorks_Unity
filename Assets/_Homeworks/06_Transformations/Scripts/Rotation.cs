using UnityEngine;

namespace Transformations
{
    public class Rotation : MonoBehaviour
    {
        [SerializeField] private float _speedRotationY = 1f;

        private void Update()
        {
            transform.Rotate(0, _speedRotationY, 0);
        }
    }
}
