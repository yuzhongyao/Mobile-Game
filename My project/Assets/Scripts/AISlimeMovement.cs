using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AISlimeMovement : MonoBehaviour
{
    Rigidbody2D rb;
    int speed, strength, awareness, sprint;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        speed = GetComponent<AISlimeStats>().Speed;
        strength = GetComponent<AISlimeStats>().Strength;
        awareness = GetComponent<AISlimeStats>().Awareness;
        sprint = GetComponent<AISlimeStats>().Sprint;
        Vector2 v = new Vector2(speed, 0);
        rb.velocity = v; 
    }
    void OnCollisionEnter2D(Collision2D c)
    {
        if(c.gameObject.tag == "DodgeObstacle")
        {
            StartCoroutine("Recover");
        }
        else if (c.gameObject.tag == "DestroyObstacle")
        {
            StartCoroutine("BreakObstacle");
        }
    }
    IEnumerator Recover()
    {
        yield return new WaitForSeconds(1f);//wait for 1 second before calling MoveAgain()
        MoveAgain();
    }
    IEnumerator BreakObstacle()
    {
        yield return new WaitForSeconds(strength);//wait for time determined by strength stat before moving again
        MoveAgain();
    }
    void MoveAgain()
    {
        Vector2 v = new Vector2(speed, 0);
        rb.velocity = v;
    }
}
