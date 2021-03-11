using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    public GameObject paper;
    public GameObject startbtn;

    public void gunR()
    {
        soundManager.instance.GunReady();
        Invoke("showMenu", 1f);
    }
    public void showMenu()
    {
        soundManager.instance.Gun();
        paper.SetActive(true);
        startbtn.SetActive(true);
    }
    
}
