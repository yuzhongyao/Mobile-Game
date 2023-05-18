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
    /*This code disables the buttons when they're about to hit a destroyable obstacle. This is to make sure the player can't dodge through the obstacle.
     *The sprint button is disabled because of a flaw in the code allowing the player to sprint through the obstacle iirc */
}
