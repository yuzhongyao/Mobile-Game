using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObstacle : MonoBehaviour
{
    Rigidbody2D rb;
    GameObject slime;
    BoxCollider2D collider;
    SlimeStats stats;
    // Start is called before the first frame update
    void Start()
    {
        slime = GameObject.Find("Slime");
        rb = slime.GetComponent<Rigidbody2D>();
        collider = GetComponent<BoxCollider2D>();
        stats = new SlimeStats();
    }

    void OnCollisionEnter2D(Collision2D c)
    {
        StartCoroutine("Destroy");
    }
    IEnumerator Destroy()
    {
        collider.enabled = false;
        yield return new WaitForSeconds(stats.Strength);//amount of time it will take for slime to start moving again, the formula still needs to be figured out
        Vector2 v = new Vector2(stats.Speed, 0);
        rb.velocity = v; //this makes the slime move forward
        Destroy(gameObject);
       
    }
    /*Like with the dodgeable obstacles, the player slime's movement is handled in here while AISlime's have their movement handled in the AISlime movement class.
     Again, I think it would be good to recode the player slime script to match up with the AISlimes so that the code is more organized (slime movement should be handled by the slimemovement classes imo)*/
}
