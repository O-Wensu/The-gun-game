using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public GameObject bullet;
    public GameObject[] life;
    private Vector3 Pos;
    private int lifeNum = 3;
    public GameObject resultPanel;
    public GameObject redPanel;
    public Text levelText;
    public Text levelResult;
    private float speed=5f;
    private int lateTime = 3;
    public int level;
    private double randomX = -35.1;
    private double randomX2 = -35.1;
    private float randomY, randomZ, randomY2, randomZ2;

    // Start is called before the first frame update
    void Start()
    {
        level = 1;
        InvokeRepeating("makeBullet", 1, lateTime);
        Pos = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().AddForce(transform.up * speed);
        levelText.text = "Level " + level;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "goal")
        {
            player.transform.position = Pos;
            level++;
            speed = speed + 0.5f;
        }
        if (other.gameObject.tag == "wall")
        {
            Destroy(gameObject);
        }
        if(other.gameObject.tag=="bullet")
        {
            soundManager.instance.SScream();
            redPanel.SetActive(true);
            Invoke("del_red", 0.5f);

            life[lifeNum].SetActive(false);

            if (lifeNum <= 0)
            {
                Time.timeScale = 0f;
                resultPanel.SetActive(true);
                UIManager.instance.totalT();
                levelResult.text = "Level " + level+" 달성";
            }
            lifeNum--;
        }
        if (other.gameObject.tag == "heart")
        {
            life[lifeNum].SetActive(true);
            lifeNum++;
        }
    }
    public void del_red()
    {
        redPanel.SetActive(false);
    }
    public Vector3 RandSpawn()
    {
        randomY = Random.Range((float)2.58, (float)6.6);
        randomZ = Random.Range((float)-31.67, (float)2.88);
        Vector3 randPos = new Vector3((float)randomX, randomY, randomZ);
        return randPos;
    }
    public Vector3 RandHeart()
    {
        randomY2 = Random.Range((float)2.58, (float)6.6);
        randomZ2 = Random.Range((float)-31.67, (float)2.88);
        Vector3 randPos2 = new Vector3((float)randomX2, randomY2, randomZ2);
        return randPos2;
    }
    public void makeBullet()
    {
        Instantiate(bullet, RandSpawn(), Quaternion.Euler(0, 0, -90));
    }

}
