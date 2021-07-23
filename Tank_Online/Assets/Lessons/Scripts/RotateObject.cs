using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    [SerializeField] private RotateSettings rotateSettings;
    void Update()
    {
        transform.Rotate(Vector3.up, rotateSettings.Speed * Time.deltaTime);
    }


}
