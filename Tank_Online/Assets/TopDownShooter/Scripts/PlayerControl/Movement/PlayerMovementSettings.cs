using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.PlayerControls
{
    [CreateAssetMenu(menuName = "TopDown Shooter/Player/Movement Settings")]
    public class PlayerMovementSettings : ScriptableObject
    {
        public float horizontalSpeed = 5;
        public float verticalSpeed = 5;
    }
}