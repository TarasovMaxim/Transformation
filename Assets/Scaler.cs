using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed=1;

    void Update()
    {
        transform.localScale *= _scaleSpeed;
    }
}
