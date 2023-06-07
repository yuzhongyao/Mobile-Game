using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionWithObst : MonoBehaviour
{
    GameObject slime;
    // Start is called before the first frame update
    void Start()
    {
        slime = GameObject.FindWithTag("Player");
    }

    void OnCollisionEnter2D(Collision2D c)
    {
        if(c.gameObject.tag == "Player")
        {
            slime.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            //if the player touches the obstacle in any way, the velocity will be set to 0
            slime.GetComponent<SlimeMovement>().DoAfterCollision();//calls DoAfterCollsion in the SlimeMovement class attached to gameobject slime
            Destroy(gameObject);
        }
        else if (c.gameObject.tag == "AI")
        {
            Destroy(gameObject);
        }
        //Destroy(gameObject);
    }
    /*This code was supposed to handle what happens when a slime hits a dodgeable obstacle. However, I coded the AI part differently because I realized
     that there are going to be multiple AI slimes. I think a decent fix for this would be to code the player slime part so that it matches up with the
    AI slime more (use AISlimeMovement and SlimeMovement). Feel free to fix this in your own way if you think of one.*/
}
