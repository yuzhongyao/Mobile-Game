using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeMovement : MonoBehaviour
{
    Rigidbody2D rb;
    //SlimeStats stats;
    public PlayerStats PStats;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //stats = GetComponent<SlimeStats>();
        //Vector2 v = new Vector2(stats.Speed, 0);
        Vector2 v = new Vector2(PStats.Speed, 0);
        rb.velocity = v; //this makes the slime move forward
    }
    public void DoAfterCollision()// makes the slime speed up again after it hits an obstacle
    {
        StartCoroutine("SpeedUp");
       
    }
    IEnumerator SpeedUp()
    {
        yield return new WaitForSeconds(1f);
        // Vector2 v = new Vector2(stats.Speed, 0);
        Vector2 v = new Vector2(PStats.Speed, 0);
        rb.velocity = v; //this makes the slime move forward
    }
    public void Sprint()//method for slime sprinting
    {
       // rb.velocity = new Vector2(stats.Speed * 1.2f, 0);
        rb.velocity = new Vector2(PStats.Speed * 1.2f, 0);
        StartCoroutine("SprintState");
    }
    IEnumerator SprintState()
    {
       // yield return new WaitForSeconds(stats.Sprint*0.8f);
        //rb.velocity = new Vector2(stats.Speed, 0);
        yield return new WaitForSeconds(PStats.Sprint * 0.8f);
        rb.velocity = new Vector2(PStats.Speed, 0);
    }
   
}
