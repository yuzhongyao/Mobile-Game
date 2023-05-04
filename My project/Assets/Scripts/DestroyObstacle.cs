using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObstacle : MonoBehaviour
{
    Rigidbody2D rb;
    GameObject slime;
    BoxCollider2D collider;
    // Start is called before the first frame update
    void Start()
    {
        slime = GameObject.Find("Slime");
        rb = slime.GetComponent<Rigidbody2D>();
        collider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D c)
    {
        StartCoroutine("Destroy");
    }
    IEnumerator Destroy()
    {
        collider.enabled = false;
        yield return new WaitForSeconds(1f);
        Vector2 v = new Vector2(50, 0);
        rb.AddForce(v); //this makes the slime move forward, don't know the math behind addforce though
        Destroy(gameObject);
       
    }
}
