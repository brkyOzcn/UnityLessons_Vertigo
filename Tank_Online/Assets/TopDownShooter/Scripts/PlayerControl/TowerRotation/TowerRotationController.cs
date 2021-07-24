using System.Collections;
using System.Collections.Generic;
using TopDownShooter.PlayerInput;
using UnityEngine;


namespace TopDownShooter.PlayerControls
{
    public class TowerRotationController : MonoBehaviour
    {
        [SerializeField] private InputData _rotationInput;
        [SerializeField] private Transform _towerTransform;
        [SerializeField] private TowerRotationSettings _towerRotationSettings;

        private void Update()
        {
            _towerTransform.Rotate(0, _rotationInput.horizontalInput * _towerRotationSettings.towerRotationSpeed, 0, Space.Self);
        }
    }
}