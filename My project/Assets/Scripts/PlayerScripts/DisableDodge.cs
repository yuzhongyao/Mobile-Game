using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DisableDodge : MonoBehaviour
{
    public Button dodgeButton;
    public Button sprintButton;

    void OnTriggerStay2D(Collider2D c)
    {
        if(c.tag == "Player")
        {
            dodgeButton.interactable = false;
            sprintButton.interactable = false;
        }
    }
    void OnTriggerExit2D(Collider2D c)
    {
        if (c.tag == "Player")
        {
            dodgeButton.interactable = true;
            sprintButton.interactable = true;
        }
    }
}
