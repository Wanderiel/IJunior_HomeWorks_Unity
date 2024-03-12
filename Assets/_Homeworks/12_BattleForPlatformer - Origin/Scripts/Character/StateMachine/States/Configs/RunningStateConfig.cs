using System;
using UnityEngine;

namespace BattleForPlatformer
{
    [Serializable]
    public class RunningStateConfig
    {
        [SerializeField, Range(0, 10f)] private float _speed;

        public float Speed => _speed;
    }
}
