using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerTimer : MonoBehaviour
{
    //public Text t;
    Text t;
    float time = 0f;
    bool finished;
    bool setPosition;
    GameObject counter;
    GameObject placingsPanel;
    // Start is called before the first frame update
    void Start()
    {
        finished = false;
        setPosition = false;
        counter = GameObject.Find("SlimeCounter");
        placingsPanel = GameObject.Find("Placings");
        t = GameObject.Find("PlayerTimer").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!finished)
        {
            time += Time.deltaTime;
        }
        TimerUpdate(time);
       
    }
    void OnTriggerEnter2D(Collider2D c)
    {
        if (c.gameObject.tag == "Goal"&&!setPosition)
        {
            finished = true; setPosition = true;
            counter.GetComponent<ResultPanel>().Count();
            placingsPanel.GetComponent<Placings>().setPosition(this.gameObject.name,time);
            Debug.Log("player finish");
        }
    }
    public void TimerUpdate(float time)
    {
        int mins = Mathf.FloorToInt(time / 60f);
        //int seconds = Mathf.RoundToInt(time % 60f);
        float seconds = time%60f;
        if (seconds == 60f)
        {
            seconds = 0;
            mins += 1;
        }
        t.text = mins.ToString("00") + " : " + seconds.ToString("F4");
        
    }
    /*Tracks the time it takes for the player to cross the finish line, when the player hits the goal, this script will send
     a signal to the placings script, which should put it in its proper position. We do know that there are a few bugs that need to be 
     addressed. I mentioned trying a fix that revolves around recording the times and sorting them when the race is finished. */
}
