using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.PlayerInput 
{
    public class InputManager : MonoBehaviour
    {
        [SerializeField] private InputData _inputData;   
        private void Update()
        {
            _inputData.horizontalInput = Input.GetAxis("Horizontal");
            _inputData.verticalInput = Input.GetAxis("Vertical");
        }
        

    }
}