using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CigaretteCollision : MonoBehaviour
{
    public Text livesCountTxt;
    public GameObject HitColor;
    

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
