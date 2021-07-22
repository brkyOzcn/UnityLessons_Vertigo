using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Lessons/Lesson1/Rotate Settings")]
public class RotateSettings : ScriptableObject
{
    [SerializeField] private float speed = 1f;
    public float Speed { get { return speed; } }



}
