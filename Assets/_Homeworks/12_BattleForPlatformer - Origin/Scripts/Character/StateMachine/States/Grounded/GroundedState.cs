using System;
using UnityEngine.InputSystem;

namespace BattleForPlatformer
{
    public class GroundedState : MovementState
    {
        private GroundChecker _groundChecker;

        public GroundedState(IStateSwitcher stateSwitcher, StateMachineData data, Character character)
            : base(stateSwitcher, data, character)
        {
            _groundChecker = character.GroundChecker;
        }

        public override void Enter()
        {
            base.Enter();

            View.StartGrounded();
        }

        public override void Exit()
        {
            base.Exit();

            View.StopGrounded();
        }

        public override void Update()
        {
            base.Update();

            if (_groundChecker.IsGrounded == false)
                StateSwitcher.SwitchState<FallingState>();
        }

        protected override void AddInputActionsCallbacks()
        {
            base.AddInputActionsCallbacks();

            InputActions.Movement.Jump.started += OnJumpKeyPressed;
        }

        protected override void RemoveInputActionsCallbacks()
        {
            base.RemoveInputActionsCallbacks();

            InputActions.Movement.Jump.started -= OnJumpKeyPressed;
        }

        private void OnJumpKeyPressed(InputAction.CallbackContext context) =>
            StateSwitcher.SwitchState<JumpingState>();
    }
}
