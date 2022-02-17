using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CigaretteRotation : MonoBehaviour
{
    public Text livesCountTxt;
    public GameObject HitColor;
    private float rotationsPerMinute = 20f;
    void Update()
    {
        transform.Rotate(0, 0, 6.0f * rotationsPerMinute * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            HitColor.SetActive(true);
            GameState.LivesNumber -= 1;
            livesCountTxt.text = GameState.LivesNumber.ToString();
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            HitColor.SetActive(false);
        }
    }
}
