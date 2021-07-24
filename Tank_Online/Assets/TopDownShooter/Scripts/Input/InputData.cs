using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.PlayerInput
{
    [CreateAssetMenu(menuName = "TopDown Shooter/Input/Input Data")]
    public class InputData : ScriptableObject
    {
        public float horizontalInput;
        public float verticalInput;

        [Header("Axis Base Control")]
        [SerializeField] private bool _axisActive;
        [SerializeField] private string axisNameHorizontal;
        [SerializeField] private string axisNameVertical;

        [Header("Key Base Control")]
        [SerializeField] private bool _keyBaseHorizontalActive;
        [SerializeField] private KeyCode positiveHorizontalKeyCode;
        [SerializeField] private KeyCode negativeHorizontalKeyCode;
        [SerializeField] private bool _keyBaseVerticalActive;
        [SerializeField] private KeyCode positiveVerticalKeyCode;
        [SerializeField] private KeyCode negativeVerticalKeyCode;
        [SerializeField] private float _increaseAmount = 0.015f;

        public void ProcessInput()
        {
            if (_axisActive)
            {
                horizontalInput = Input.GetAxis(axisNameHorizontal);
                verticalInput = Input.GetAxis(axisNameVertical);
            }
            else
            {
                if (_keyBaseHorizontalActive)
                {
                    KeyBaseAxisControl(ref horizontalInput, positiveHorizontalKeyCode, negativeHorizontalKeyCode);
                }
                if (_keyBaseVerticalActive)
                {
                    KeyBaseAxisControl(ref verticalInput, positiveVerticalKeyCode, negativeVerticalKeyCode);
                }
            }
        }

        private void KeyBaseAxisControl(ref float value, KeyCode positive, KeyCode negative)
        {
            bool positiveActive = Input.GetKey(positive);
            bool negativeActive = Input.GetKey(negative);

            if (positiveActive)
            {
                value += _increaseAmount;
            }
            else if (negativeActive)
            {
                value -= _increaseAmount;
            }
            else
            {
                value = 0;
            }

            value = Mathf.Clamp(value, -1, 1);
        }
    }
}