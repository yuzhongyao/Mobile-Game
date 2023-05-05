using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeMovement : MonoBehaviour
{
     Rigidbody2D rb;
    SlimeStats stats;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        stats = new SlimeStats();
        Vector2 v = new Vector2(stats.Speed, 0);
        rb.velocity = v; //this makes the slime move forward, don't know the math behind addforce though
    }
    public void DoAfterCollision()
    {
        StartCoroutine("SpeedUp");
       
    }
    IEnumerator SpeedUp()
    {
        yield return new WaitForSeconds(stats.Strength);
        Vector2 v = new Vector2(stats.Speed, 0);
        rb.velocity = v; //this makes the slime move forward, don't know the math behind addforce though
    }
}
