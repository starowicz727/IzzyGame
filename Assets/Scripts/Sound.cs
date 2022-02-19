using UnityEngine.Audio;
using UnityEngine;

[System.Serializable] // dzi�ki temu mo�emy widzie� elementy klasy w interfejsie unity 
public class Sound
{

    public string name;
    public AudioClip clip;

    [HideInInspector]
    public AudioSource source;

    [Range(0f, 1f)]
    public float volume;

    [Range(0.1f, 3f)]
    public float pitch;

}

