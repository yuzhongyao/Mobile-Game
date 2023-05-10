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
    void Start()
    {
        goal = GameObject.Find("goal");
        goalVector = goal.transform.position;
        slimeVector = transform.position;
    }
    void Update()
    {
        slimeVector = transform.position;
        distance = Vector2.Distance(slimeVector, goalVector);
        t.text = distance.ToString("#.##");
    }
}
