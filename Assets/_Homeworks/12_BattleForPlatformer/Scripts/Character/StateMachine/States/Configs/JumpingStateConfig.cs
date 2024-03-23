using System;
using UnityEngine;

namespace BattleForPlatformer
{
    [Serializable]
    public class JumpingStateConfig
    {
        [SerializeField, Range(0, 10f)] private float _maxHeight;
        [SerializeField, Range(0, 3f)] private float _timeToReachMaxHeight;

        private float _multiplier = 2f;

        public float MaxHeight => _maxHeight;
        public float TimeToReachMaxHeight => _timeToReachMaxHeight;
        public float StartYVelocity => _multiplier * _maxHeight / _timeToReachMaxHeight;
    }
}
