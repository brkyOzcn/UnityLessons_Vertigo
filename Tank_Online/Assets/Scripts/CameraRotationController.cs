using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotationController : MonoBehaviour
{
    [SerializeField] private Transform targetTransform;
    [SerializeField] private Transform cameraTransform;
    [SerializeField] private float lerpSpeed;

    private void Update()
    {
        cameraTransform.rotation = Quaternion.Lerp(cameraTransform.rotation,
            Quaternion.LookRotation(targetTransform.position - cameraTransform.position), lerpSpeed * Time.deltaTime);
    }

}
