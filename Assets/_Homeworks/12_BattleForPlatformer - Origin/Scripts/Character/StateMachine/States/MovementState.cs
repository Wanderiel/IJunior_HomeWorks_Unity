using UnityEngine;

namespace BattleForPlatformer
{
    public class MovementState : IState
    {
        protected readonly IStateSwitcher StateSwitcher;
        protected readonly StateMachineData Data;

        private readonly Character _character;

        public MovementState(IStateSwitcher stateSwitcher, StateMachineData data, Character character)
        {
            StateSwitcher = stateSwitcher;
            Data = data;
            _character = character;
        }

        protected PlayerInputPro InputActions => _character.InputActions;
        protected CharacterView View => _character.View;

        private Quaternion TurnRight => Quaternion.Euler(Vector3.zero);
        private Quaternion TurnLeft => Quaternion.Euler(0, 180, 0);

        public virtual void Enter()
        {
            View.StartMovement();
            AddInputActionsCallbacks();
        }

        public virtual void Exit()
        {
            View.StopMovement();
            RemoveInputActionsCallbacks();
        }

        public void HandleInput()
        {
            Data.XInput = ReadHorizontalInput();
            Data.XVelocity = Mathf.Abs(Data.XInput * Data.Speed);
        }

        public virtual void Update()
        {
            Vector3 velocity = GetConvertVelocity();
            _character.transform.Translate(velocity * Time.deltaTime);
            _character.transform.rotation = GetRotation();
        }

        protected bool IsHorizontalInputZero() =>
            Data.XInput == 0;

        protected virtual void AddInputActionsCallbacks()
        {
        }

        protected virtual void RemoveInputActionsCallbacks()
        {
        }

        private Quaternion GetRotation()
        {
            if (Data.XInput > 0)
                return TurnRight;

            if (Data.XInput < 0)
                return TurnLeft;

            return _character.transform.rotation;
        }

        private Vector3 GetConvertVelocity() =>
            new Vector3(Data.XVelocity, Data.YVelocity, 0);

        private float ReadHorizontalInput() =>
            InputActions.Movement.Move.ReadValue<float>();
    }
}
