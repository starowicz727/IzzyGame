using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckRotation : MonoBehaviour
{
    public float rotationsPerMinute = 20f;
    void Update()
    {
        transform.Rotate(0, 0, 6.0f * rotationsPerMinute * Time.deltaTime);
    }
}
