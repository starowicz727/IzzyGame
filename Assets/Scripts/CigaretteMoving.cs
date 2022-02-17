using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CigaretteMoving : MonoBehaviour
{
    private float directionSpeed = 1f;
    private float startPosition;
    private float amplitude = 2f;
    public bool goUp;
    void Start()
    {
        startPosition = this.transform.position.y;
    }

    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        if (goUp)
        {
            if (this.transform.position.y <= startPosition + amplitude)
            {
                this.transform.position = transform.position + new Vector3(0, directionSpeed * Time.deltaTime, 0);
            }
            else
            {
                goUp = false;
            }
        }
        else
        {
            if (this.transform.position.y >= startPosition - amplitude)
            {
                this.transform.position = transform.position - new Vector3(0, directionSpeed * Time.deltaTime, 0);
            }
            else
            {
                goUp = true;
            }
        }
    }
}
