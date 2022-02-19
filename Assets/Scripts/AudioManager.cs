using System;
using UnityEngine.Audio;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;
    public static AudioManager instance;
    void Awake() //awake wykonuje siê tu¿ przed Start()
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

        foreach (Sound snd in sounds)
        {
            snd.source = gameObject.AddComponent<AudioSource>();
            snd.source.clip = snd.clip;
            snd.source.volume = snd.volume;
            snd.source.pitch = snd.pitch;
        }
    }
    

    public void Play(string name)
    {
        Sound fsnd = Array.Find(sounds, sound => sound.name == name); //szukamy w tablicy Sound o nazwie name

        if (fsnd == null)
        {
            Debug.LogWarning("Didn't found sound named " + name);  //jeœli nie znajdziemy to mamy o tym informacjê w Console
            return;
        }
        else
        {
            fsnd.source.Play();
        }

    }
}
