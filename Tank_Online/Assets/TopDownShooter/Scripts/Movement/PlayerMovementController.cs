using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TopDownShooter.PlayerInput;

namespace TopDownShooter.PlayerMovement
{
    public class PlayerMovementController : MonoBehaviour
    {
        [SerializeField] private InputData _inputData;
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private PlayerMovementSettings _playerMovementSettings;
        private void Update()
        {
            _rigidbody.MovePosition(_rigidbody.position + (_rigidbody.transform.forward * _inputData.verticalInput * 
                _playerMovementSettings.verticalSpeed));
            _rigidbody.MovePosition(_rigidbody.position + (_rigidbody.transform.right * _inputData.horizontalInput * 
                _playerMovementSettings.horizontalSpeed));
        }
    }
}