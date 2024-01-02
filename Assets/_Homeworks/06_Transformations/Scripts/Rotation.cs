using UnityEngine;

namespace Transformations
{
    public class Rotation : MonoBehaviour
    {
        [SerializeField] private float _speedY = 1f;

        private void Update()
        {
            transform.Rotate(0, _speedY, 0);
        }
    }
}
