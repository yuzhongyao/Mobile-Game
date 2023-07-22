using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PauseScreen : MonoBehaviour
{
    public Canvas pauseScreen;
    // Start is called before the first frame update
    void Start()
    {
        pauseScreen.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
            pauseScreen.enabled =true;
        }
    }
    public void Resume()
    {
        Time.timeScale = 1;
        pauseScreen.enabled = false;
    }
    public void MainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }
}
