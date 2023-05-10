using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerTimer : MonoBehaviour
{
    public Text t;
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
            placingsPanel.GetComponent<Placings>().setPosition(this.gameObject.name);
        }
    }
    public void TimerUpdate(float totalSeconds)
    {
        int mins = Mathf.FloorToInt(totalSeconds / 60f);
        int seconds = Mathf.RoundToInt(totalSeconds % 60f);
        if (seconds == 60)
        {
            seconds = 0;
            mins += 1;
        }
        t.text = mins.ToString("00") + " : " + seconds.ToString("00");
    }
}
