using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectLives : MonoBehaviour
{
    public Text livesCountTxt;
    private float directionSpeed = 0.5f;
    private float startPosition;
    private float amplitude = 0.4f;
    private bool goUp = true;

    private void Start()
    {
        startPosition = this.transform.position.y;
    }
    void Update()
    {
        Movement();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GameState.LivesNumber += 1;
            livesCountTxt.text = GameState.LivesNumber.ToString();
            Destroy(this.gameObject);
        }
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
