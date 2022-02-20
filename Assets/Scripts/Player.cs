using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Player : IComparable<Player>
{
    public string Name;
    public int PiggiesNumber;
    public float Time;

    public Player() {
        Name = null;
        PiggiesNumber = 0;
        Time = 356400; //zakladam ze 99h to jest max czas spedzony no bo bez przesady xd
    }
    public Player(string name, int piggiesNumber, float time)
    {
        Name = name;
        PiggiesNumber = piggiesNumber;
        Time = time;
    }

    public int CompareTo(Player other)
    {
        if(other == null) { return 1; }
        int result = (-PiggiesNumber).CompareTo(-other.PiggiesNumber); // najpierw sortujemy po najwiekszej liczbie swinek

        if (result == 0)
        {
            result = Time.CompareTo(other.Time);  //potem sortujemy po najmniejszym czasie
        }

        return result;
    }
}
