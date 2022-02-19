using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Player 
{
    public string Name;
    public int PiggiesNumber;
    public float Time;

    public Player() { }
    public Player(string name, int piggiesNumber, float time)
    {
        Name = name;
        PiggiesNumber = piggiesNumber;
        Time = time;
    }
}
