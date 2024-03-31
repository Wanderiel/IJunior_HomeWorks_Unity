using UnityEngine;

namespace BattleForPlatformer
{
    public class AttackingState : GroundedState
    {
        private Animator _animator;
        private float _delay = 0;
        private float _wait = 0;

        public AttackingState(IStateSwitcher stateSwitcher, StateMachineData data, Character character)
            : base(stateSwitcher, data, character)
        {
            _animator = character.MyAnimator;
        }

        public override void Enter()
        {
            base.Enter();

            View.StartAttacking();
            Data.Speed = 0;
            AnimatorStateInfo animatorStateInfo = _animator.GetCurrentAnimatorStateInfo(0);
            _delay = animatorStateInfo.length * animatorStateInfo.speed;
        }

        public override void Exit()
        {
            base.Exit();

            View.StopAttacking();
            _wait = 0;
        }

        public override void Update()
        {
            base.Update();

            _wait += Time.deltaTime;

            if (_wait < _delay)
                return;

            StateSwitcher.SwitchState<IdlingState>();
        }
    }
}
