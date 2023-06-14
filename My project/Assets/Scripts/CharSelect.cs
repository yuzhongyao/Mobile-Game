using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CharSelect : MonoBehaviour
{
   public void SelectSam()
    {
        PlayerPrefs.SetInt("character", 0);
        SceneManager.LoadScene("Prototype");
    }
    public void SelectBob()
    {
        PlayerPrefs.SetInt("character", 1);
        SceneManager.LoadScene("Prototype");
    }
}
