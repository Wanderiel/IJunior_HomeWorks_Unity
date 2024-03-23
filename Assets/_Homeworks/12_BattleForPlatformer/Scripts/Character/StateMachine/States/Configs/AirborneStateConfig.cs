using System;
using UnityEngine;

namespace BattleForPlatformer
{
    [Serializable]
    public class AirborneStateConfig
    {
        [SerializeField] private JumpingStateConfig _jumpingStateConfig;
        [SerializeField, Range(0, 10f)] private float _speed;

        private float _multiplier = 2f;

        public JumpingStateConfig JumpingStateConfig => _jumpingStateConfig;
        public float Speed => _speed;
        public float BaseGravity =>
            _multiplier * _jumpingStateConfig.MaxHeight / (_jumpingStateConfig.TimeToReachMaxHeight * _jumpingStateConfig.TimeToReachMaxHeight);
    }
}
