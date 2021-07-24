using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.Camera
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField] private CameraSettings _cameraSettings;
        [SerializeField] private Transform _positionTarget;
        [SerializeField] private Transform _cameraTransform;
        [SerializeField] private Transform _rotationTarget;

        private void Update()
        {
            CameraMovementFollow();
            CameraRotationFollow();
        }

        void CameraRotationFollow()
        {
            _cameraTransform.rotation = Quaternion.Lerp(_cameraTransform.rotation,
                Quaternion.LookRotation(_rotationTarget.forward),
                Time.deltaTime * _cameraSettings.RotationLerpSpeed);
        }
        
        void CameraMovementFollow()
        {  
            _cameraTransform.localPosition = _cameraSettings.PositionOffset;
        }

    }
}