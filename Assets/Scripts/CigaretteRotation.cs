using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CigaretteRotation : MonoBehaviour
{
    private float rotationsPerMinute = 20;
    void Update()
    {
        transform.Rotate(0, 0, 6.0f * rotationsPerMinute * Time.deltaTime);
    }
}
