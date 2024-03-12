using UnityEngine;

namespace BattleForPlatformer
{
    public class Character : MonoBehaviour
    {
        [SerializeField] private CharacterView _view;
        [SerializeField] private CharacterConfig _config;
        [SerializeField] private GroundChecker _groundChecker;

        private PlayerInputPro _inputActions;
        private CharacterStateMachine _stateMachine;
        private SpriteRenderer _spriteRenderer;

        public PlayerInputPro InputActions => _inputActions;
        public SpriteRenderer SpriteRenderer => _spriteRenderer;
        public CharacterView View => _view;
        public CharacterConfig Config => _config;
        public GroundChecker GroundChecker => _groundChecker;

        private void Awake()
        {
            _view.Initialize();
            _inputActions = new PlayerInputPro();
            _stateMachine = new CharacterStateMachine(this);
            _spriteRenderer = GetComponent<SpriteRenderer>();
        }

        private void Update()
        {
            _stateMachine.HandleInput();
            _stateMachine.Update();

            Debug.Log( _groundChecker.IsGrounded);
        }

        public void OnEnable() =>
            _inputActions.Enable();

        public void OnDisable() =>
            _inputActions.Disable();
    }
}
