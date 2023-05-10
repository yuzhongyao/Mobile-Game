using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceToGoal : MonoBehaviour
{
    GameObject goal;
    Vector2 goalVector;
    Vector2 slimeVector;
    float distance;
    public Text t;
    string name;
    Rigidbody2D rb;
    void Start()
    {
        goal = GameObject.Find("goal");
        goalVector = goal.transform.position;
        slimeVector = transform.position;
        name = this.gameObject.name;
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        slimeVector = transform.position;
        distance = Vector2.Distance(slimeVector, goalVector);
        if (distance<=0.1 && distance>0)
        {
            rb.velocity = new Vector2(0,0);
        }
        t.text = name+": "+ distance.ToString("#.##");
    }
    
}
