using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DisableDodge : MonoBehaviour
{
    public Button b;
    

    void OnTriggerStay2D(Collider2D c)
    {
        if(c.tag == "Player")
        {
            b.interactable = false;
        }
    }
    void OnTriggerExit2D(Collider2D c)
    {
        if (c.tag == "Player")
        {
            b.interactable = true;
        }
    }
}
