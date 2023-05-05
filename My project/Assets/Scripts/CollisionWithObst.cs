using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionWithObst : MonoBehaviour
{
    GameObject slime;
    // Start is called before the first frame update
    void Start()
    {
        slime = GameObject.Find("Slime");
    }

    void OnCollisionEnter2D(Collision2D c)
    {
        if(c.gameObject.tag == "Player")
        {
            slime.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            //if the player touches the obstacle in any way, the velocity will be set to 0
            slime.GetComponent<SlimeMovement>().DoAfterCollision();
            Destroy(gameObject);
        }
    }
}
