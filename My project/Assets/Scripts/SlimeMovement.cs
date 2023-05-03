using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeMovement : MonoBehaviour
{
     Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Vector2 v = new Vector2(50, 0);
        rb.AddForce(v); //this makes the slime move forward, don't know the math behind addforce though
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
