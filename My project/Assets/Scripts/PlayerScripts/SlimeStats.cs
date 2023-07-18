using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class SlimeStats : MonoBehaviour
{

    /*[SerializeField] public int Speed = 5;
    [SerializeField] public int Strength= 1;
    [SerializeField] public int Awareness = 2;
    [SerializeField] public int Sprint = 1;*/
    public int Speed = 5;
    public int Strength = 1;
    public int Awareness = 2;
    public int Sprint = 1;
   
    public void SetChanges(int newStr, int newSpeed, int newAwareness, int newSprint)
    {
        Speed = newSpeed;
        Strength = newStr;
        Awareness = newAwareness;
        Sprint = newSprint;
    }
}


