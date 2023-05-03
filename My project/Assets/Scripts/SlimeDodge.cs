using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeDodge : MonoBehaviour
{
    GameObject slime;
    BoxCollider2D collider;
    SpriteRenderer sr;
    void Start()
    {
        slime = GameObject.Find("Slime");
        collider = slime.GetComponent<BoxCollider2D>();
        sr = slime.GetComponent<SpriteRenderer>();
    }
    public void DodgeButtonClick()
    {
        StartCoroutine("Dodge");
    }

    IEnumerator Dodge()
    {
        collider.enabled = false;
        sr.color = new Color(1f, 0.9581f, 0.0245f, 0.5f);
        yield return new WaitForSeconds(0.5f);
        collider.enabled = true;
        sr.color = new Color(1f, 0.9581f, 0.0245f, 1f);
        /*when the dodge button is clicked, the box collider will be disabled for half a second, allowing the slime to pass through the obstacle
         *the sprite's color opacity is changed to give the slime a ghost effect as well as signaling to the player that the slime is dodging */
    }
}
