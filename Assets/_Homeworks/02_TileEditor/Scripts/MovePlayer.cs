using UnityEngine;

namespace TileEditor
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class MovePlayer : MonoBehaviour
    {
        [SerializeField] private float _speed = 15f;

        private Rigidbody2D _rigidBody2D;
        private Vector2 _moveVector;

        void Awake()
        {
            _rigidBody2D = GetComponent<Rigidbody2D>();
        }

        void Update()
        {
            _moveVector.x = Input.GetAxis("Horizontal");
            _moveVector.y = Input.GetAxis("Vertical");
            _rigidBody2D.MovePosition(_rigidBody2D.position + _moveVector * _speed * Time.deltaTime);
        }
    }
}