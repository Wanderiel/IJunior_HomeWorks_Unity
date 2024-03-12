namespace BattleForPlatformer
{
    public class AttackingState : MovementState
    {
        public AttackingState(IStateSwitcher stateSwitcher, StateMachineData data, Character character)
            : base(stateSwitcher, data, character)
        {
        }

        public override void Enter()
        {
            base.Enter();

            View.StartAttacking();
        }

        public override void Exit()
        {
            base.Exit();

            View.StopAttacking();
        }

        public override void Update()
        {
            base.Update();


        }
    }
}
