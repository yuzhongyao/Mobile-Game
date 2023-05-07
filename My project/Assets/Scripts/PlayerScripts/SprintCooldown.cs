using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SprintCooldown : MonoBehaviour
{
    SlimeStats stats;
    public Button sprintButton;
    void Start()
    {
        stats = new SlimeStats();
    }
    public void StartCooldown()
    {
        sprintButton.interactable = false;
        StartCoroutine("EndCooldown");
    }
    IEnumerator EndCooldown()
    {
        yield return new WaitForSeconds(stats.Sprint * 0.8f + 2);
        sprintButton.interactable = true;
    }
}
