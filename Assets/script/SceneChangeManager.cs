using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeManager : MonoBehaviour
{
    public GameObject stopPanel;
    /*
    public static SceneChangeManager instance;

    void Awake()
    {
        if (SceneChangeManager.instance == null)
        {
            SceneChangeManager.instance = this;
        }
    }
    */
    public void GoMain()
    {
        soundManager.instance.Gun();
        SceneManager.LoadScene(0);
    }
    public void GoGame()
    {
        soundManager.instance.Gun();
        SceneManager.LoadScene(1);
    }
    public void stopBtn()
    {
        Time.timeScale = 0f;
        stopPanel.SetActive(true);
    }
    public void reBtn()
    {
        Time.timeScale = 1f;
        stopPanel.SetActive(false);
    }
}
