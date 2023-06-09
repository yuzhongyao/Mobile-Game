using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class StatUpgrades : MonoBehaviour
{
    SlimeStats stats;
    public TextMeshProUGUI strength;
    public TextMeshProUGUI speed;
    public TextMeshProUGUI awareness;
    public TextMeshProUGUI sprint;
    public TextMeshProUGUI skillPointsText;
    public int skillPoints = 3;
    public int tmpStr;
    public int tmpSpe;
    public int tmpAwe;
    public int tmpSpr;
    // Start is called before the first frame update
    void Start()
    {
        stats = GetComponent<SlimeStats>();
        /*tmp variable will be the value that is affected by changes on the stats upgrade screen, only when the CONFIRM button
         is pressed is when the changes are applied to the variables in class SlimeStats*/
        tmpStr = stats.Strength;
        tmpSpe = stats.Speed;
        tmpAwe = stats.Awareness;
        tmpSpr = stats.Sprint;
        strength.text = tmpStr.ToString();
        speed.text = tmpSpe.ToString();
        awareness.text = tmpAwe.ToString();
        sprint.text = tmpSpr.ToString();
        skillPointsText.text = "Skill Points: " + skillPoints;
    }

    public void AddStr()
    {
        if (skillPoints > 0)
        {
            tmpStr++;
            skillPoints--;
        }
        strength.text = tmpStr.ToString();
        skillPointsText.text = "Skill Points: " + skillPoints;
        /*if(tmpStr > stats.Strength)
        {
            strength.faceColor = new Color32(50,50,200,255);
        }*/
    }
    public void SubStr()
    {
        if (tmpStr <= stats.Strength)
        {
            tmpStr = tmpStr;
           // strength.faceColor = new Color32(0, 0, 0, 255);
        }
        else
        {
            tmpStr--;
            skillPoints++;
        }
        strength.text = tmpStr.ToString();
        skillPointsText.text = "Skill Points: " + skillPoints;
    }

    public void AddSpe()
    {
        if (skillPoints > 0)
        {
            tmpSpe++;
            skillPoints--;
        }
        speed.text = tmpSpe.ToString();
        skillPointsText.text = "Skill Points: " + skillPoints;
    }
    public void SubSpe()
    {
        if (tmpSpe <= stats.Speed)
        {
            tmpSpe = tmpSpe;
        }
        else
        {
            tmpSpe--;
            skillPoints++;
        }
        speed.text = tmpSpe.ToString();
        skillPointsText.text = "Skill Points: " + skillPoints;
    }
    public void AddAwe()
    {
        if (skillPoints > 0)
        {
            tmpAwe++;
            skillPoints--;
        }
        awareness.text = tmpAwe.ToString();
        skillPointsText.text = "Skill Points: " + skillPoints;
    }
    public void SubAwe()
    {
        if (tmpAwe <= stats.Awareness)
        {
            tmpAwe = tmpAwe;
        }
        else
        {
            tmpAwe--;
            skillPoints++;
        }
        awareness.text = tmpAwe.ToString();
        skillPointsText.text = "Skill Points: " + skillPoints;
    }
    public void AddSpr()
    {
        if (skillPoints > 0)
        {
            tmpSpr++;
            skillPoints--;
        }
        sprint.text = tmpSpr.ToString();
        skillPointsText.text = "Skill Points: " + skillPoints;
    }
    public void SubSpr()
    {
        if (tmpSpr <= stats.Sprint)
        {
            tmpSpr = tmpSpr;
        }
        else
        {
            tmpSpr--;
            skillPoints++;
        }
        sprint.text = tmpSpr.ToString();
        skillPointsText.text = "Skill Points: " + skillPoints;
    }
}
