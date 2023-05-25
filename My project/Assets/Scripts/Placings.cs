using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Placings : MonoBehaviour
{
     public Text[] Times = new Text[3];
    //public List<float> Times = new List<float>();
    int i = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        Times[0].text = "";
        Times[1].text = "";
        Times[2].text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void setPosition(string name,float time)
    {
       if(Times[i].text == "")
        {
            Times[i].text = name + " , " + time.ToString("F4"); 
        }
       else if(Times[i].text != "")
        {
            i++;
            Times[i].text = name + " , " +time.ToString("F4");
        }
       
    }
}
