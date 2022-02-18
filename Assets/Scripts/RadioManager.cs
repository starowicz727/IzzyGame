using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioManager : MonoBehaviour
{
    public AudioClip[] songs; //wszystkie piosenki w radiu 
    public static RadioManager instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
    }
    void Start() 
    {
        this.gameObject.GetComponent<AudioSource>().clip = songs[0];
        this.gameObject.GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            this.gameObject.GetComponent<AudioSource>().clip = songs[0];
            this.gameObject.GetComponent<AudioSource>().Play();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            this.gameObject.GetComponent<AudioSource>().clip = songs[1];
            this.gameObject.GetComponent<AudioSource>().Play();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            this.gameObject.GetComponent<AudioSource>().clip = songs[2];
            this.gameObject.GetComponent<AudioSource>().Play();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            this.gameObject.GetComponent<AudioSource>().clip = songs[3];
            this.gameObject.GetComponent<AudioSource>().Play();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            this.gameObject.GetComponent<AudioSource>().clip = songs[4];
            this.gameObject.GetComponent<AudioSource>().Play();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            this.gameObject.GetComponent<AudioSource>().clip = songs[5];
            this.gameObject.GetComponent<AudioSource>().Play();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            this.gameObject.GetComponent<AudioSource>().clip = songs[6];
            this.gameObject.GetComponent<AudioSource>().Play();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            this.gameObject.GetComponent<AudioSource>().clip = songs[7];
            this.gameObject.GetComponent<AudioSource>().Play();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            this.gameObject.GetComponent<AudioSource>().clip = songs[8];
            this.gameObject.GetComponent<AudioSource>().Play();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            this.gameObject.GetComponent<AudioSource>().clip = songs[9];
            this.gameObject.GetComponent<AudioSource>().Play();
        }
    }
}
