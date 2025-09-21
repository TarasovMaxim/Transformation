using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Mover : MonoBehaviour
{
    void Update()
    {
        float speed = 0.05f;
        transform.Translate(Vector3.forward * speed);
    }
}
