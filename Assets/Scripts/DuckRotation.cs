using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckRotation : MonoBehaviour
{
    public float rotationsPerMinute = 20f;
    private float startPoint = -60f;
    private float endPoint = -60f;
    
    void Update()
    {
        if (transform.rotation.z>=-60)
        {
            transform.Rotate(0, 0, 120.0f  * Time.deltaTime);
        }
        else if (transform.rotation.z < -60)
        {
            transform.Rotate(0, 0, -120.0f  * Time.deltaTime);
        }
        
    }
}
