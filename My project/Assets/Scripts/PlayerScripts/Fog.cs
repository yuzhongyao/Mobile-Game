using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fog : MonoBehaviour
{
    public GameObject fog;
    GameObject slime;
    //SlimeStats stats;
    public PlayerStats PStats;
    void Start()
    {
        slime = GameObject.FindWithTag("Player");
       // stats = slime.GetComponent<SlimeStats>();
        fog.transform.position = new Vector2(slime.transform.position.x + 20 + (PStats.Awareness/2f), slime.transform.position.y); 
        //this line defines how far away the fog is from the player, thinking that a cap of 10 should be good enough
    }
}
