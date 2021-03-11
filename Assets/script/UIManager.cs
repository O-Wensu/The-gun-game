using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{
    public Text timetext;
    public Text totalTime;
    public float GameTime = 0;
    //private float startTime = 0f;

    public static UIManager instance;
    private void Awake()
    {
        if (UIManager.instance == null)
        {
            UIManager.instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        GameTime = GameTime + Time.deltaTime;

        timetext.text = "시간 : " + (System.Math.Truncate(GameTime*100)/100); //둘째 자리까지 

        /*
        else
            timetext.text = "시간 : " + (System.Math.Truncate(GameTime * 10) / 10);
        */
    }

    public void totalT()
    {
        totalTime.text = "플레이 타임 " + (System.Math.Truncate(GameTime * 100) / 100); //둘째 자리까지 
    }
}
