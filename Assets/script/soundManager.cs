using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundManager : MonoBehaviour
{
    public AudioClip gunSound;
    public AudioClip gunReady;
    public AudioClip Scream;
    AudioSource myAudio;

    public static soundManager instance;

    void Awake()
    {
        if (soundManager.instance == null)
        {
            soundManager.instance = this;
        }
    }
    public void Start()
    {
        myAudio = GetComponent<AudioSource>();
        DontDestroyOnLoad(gameObject);
    }
    public void Gun()
    {
        myAudio.PlayOneShot(gunSound);
    }
    public void GunReady()
    {
        myAudio.PlayOneShot(gunReady);
    }
    public void SScream()
    {
        myAudio.PlayOneShot(Scream);
    }
}
