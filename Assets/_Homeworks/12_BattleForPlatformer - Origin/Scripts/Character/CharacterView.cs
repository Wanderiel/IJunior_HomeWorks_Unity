using UnityEngine;

namespace BattleForPlatformer
{
    [RequireComponent(typeof(Animator))]
    public class CharacterView : MonoBehaviour
    {
        private const string IsIdling = "IsIdling";
        private const string IsRunning = "IsRunning";
        private const string IsAttacking = "IsAttacking";
        private const string IsJumping = "IsJumping";
        private const string IsFalling = "IsFalling";
        private const string IsGrounded = "IsGrounded";
        private const string IsMovement = "IsMovement";
        private const string IsAirborne = "IsAirborne";

        private Animator _animator;

        public void Initialize() =>
            _animator = GetComponent<Animator>();

        public void StartGrounded() =>
            _animator.SetBool(IsGrounded, true);

        public void StopGrounded() =>
            _animator.SetBool(IsGrounded, false);

        public void StartMovement() =>
            _animator.SetBool(IsMovement, true);

        public void StopMovement() =>
            _animator.SetBool(IsMovement, false);

        public void StartAirborne() =>
            _animator.SetBool(IsAirborne, true);

        public void StopAirborne() =>
            _animator.SetBool(IsAirborne, false);

        public void StartIdling() =>
            _animator.SetBool(IsIdling, true);

        public void StopIdling() =>
            _animator.SetBool(IsIdling, false);

        public void StartRunning() =>
            _animator.SetBool(IsRunning, true);

        public void StopRunning() =>
            _animator.SetBool(IsRunning, false);

        public void StartAttacking() =>
            _animator.SetBool(IsAttacking, true);

        public void StopAttacking() =>
            _animator.SetBool(IsAttacking, false);

        public void StartJumping() =>
            _animator.SetBool(IsJumping, true);

        public void StopJumping() =>
            _animator.SetBool(IsJumping, false);

        public void StartFalling() =>
            _animator.SetBool(IsFalling, true);

        public void StopFalling() =>
            _animator.SetBool(IsFalling, false);
    }
}
