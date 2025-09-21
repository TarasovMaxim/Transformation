using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _speed;

    void Update()
    {
        transform.RotateAround(transform.position, transform.up, _speed);
    }
}
