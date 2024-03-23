using UnityEngine;

namespace BattleForPlatformer
{
    public class GroundChecker : MonoBehaviour
    {
        [SerializeField] private LayerMask _ground;
        [SerializeField, Range(0.01f, 0.5f)] private float _radius;

        public bool IsGrounded { get; private set; }

        private void Update() =>
            IsGrounded = Physics2D.OverlapCircle(transform.position, _radius, _ground);
    }
}
