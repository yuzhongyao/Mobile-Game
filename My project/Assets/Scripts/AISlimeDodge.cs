using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AISlimeDodge : MonoBehaviour
{
    public GameObject g;
    int AIAwareness;
    int baseAwareness = 65;
    BoxCollider2D collider;
    SpriteRenderer sr;
    
    // Start is called before the first frame update
    void Start()
    {
        AIAwareness = g.GetComponent<AISlimeStats>().Awareness*2+baseAwareness;
        //rb = g.GetComponent<Rigidbody2D>();
        collider = g.GetComponent<BoxCollider2D>();
        sr = g.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D c)
    {
        if(c.gameObject.tag == "DodgeObstacle")
        {
            int randomNum = Random.Range(0, 101);
            if(AIAwareness >= randomNum)
            {
                StartCoroutine("Dodge");
            }
        }
    }
    IEnumerator Dodge()
    {
        collider.enabled = false;
        Color dodgeColor;
        dodgeColor = sr.color;
        dodgeColor.a = 0.5f;
        sr.color = dodgeColor;
        yield return new WaitForSeconds(0.7f);
        collider.enabled = true;
        dodgeColor.a = 1f;
        sr.color = dodgeColor;
    }
}
