using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ResultPanel : MonoBehaviour
{
    public Canvas resultsPanel;
    public int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        resultsPanel.enabled = false;
       // resultsPanel.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (counter == 3)
        {
            resultsPanel.enabled = true;
        }
    }
    public void Count()
    {
        counter++;
    }
}
