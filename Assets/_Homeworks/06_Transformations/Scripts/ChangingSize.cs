using UnityEngine;

namespace Transformations
{
    public class ChangingSize : MonoBehaviour
    {
        [SerializeField] private float _speed = .1f;

        private void Update()
        {
            float size = transform.localScale.x + _speed * Time.deltaTime;
            Debug.Log(size);
            gameObject.transform.localScale = new Vector3(size, size, size);
        }
    }
}
