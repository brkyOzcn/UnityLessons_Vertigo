using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlRigidbody : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private ControlRigidbodySettings settings;

    private void Update()
    {
        bool spaceKeyDown = Input.GetKeyDown(KeyCode.Space);
        if (spaceKeyDown)
        {
            _rigidbody.AddForce(settings.JumpForce, ForceMode.Impulse);
        }
    }

}
