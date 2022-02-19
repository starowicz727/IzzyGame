using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectPiggy : MonoBehaviour
{
    //public int piggyCount = 0;
    public Text piggyCountTxt;
    private float rotationsPerMinute = 15;
    private void Update()
    {
        transform.Rotate(0, 0, 6.0f * rotationsPerMinute * Time.deltaTime);

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            FindObjectOfType<AudioManager>().Play("collectPiggy");
            GameState.PiggyNumber += 1;
            piggyCountTxt.text = GameState.PiggyNumber.ToString() + "/23";
            Destroy(this.gameObject);
        }
    }
}
