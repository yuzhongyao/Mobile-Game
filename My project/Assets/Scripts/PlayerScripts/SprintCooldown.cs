using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SprintCooldown : MonoBehaviour
{
    //SlimeStats stats;
    public PlayerStats PStats;
    GameObject slime;
    public Button sprintButton;
    void Start()
    {
        slime = GameObject.FindWithTag("Player");
        //stats = slime.GetComponent<SlimeStats>();
    }
    public void StartCooldown()
    {
        sprintButton.interactable = false;
        StartCoroutine("EndCooldown");
    }
    IEnumerator EndCooldown()
    {
        yield return new WaitForSeconds(PStats.Sprint * 0.8f + 2);
        sprintButton.interactable = true;
    }
}
