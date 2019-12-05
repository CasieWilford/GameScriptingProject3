using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour
{
    public AudioSource greenSource;
    public AudioSource redSource;
    public AudioSource yellowSource;
    public AudioSource blueSource;
    public AudioSource orangeSource;

    public AudioClip greenClip;
    public AudioClip redClip;
    public AudioClip yellowClip;
    public AudioClip blueClip;
    public AudioClip orangeClip;

    public static bool gActi;
    public static bool rActi;
    public static bool yActi;
    public static bool bActi;
    public static bool oActi;

    // Start is called before the first frame update
    void Start()
    {
        greenSource.clip = greenClip;
        redSource.clip = redClip;
        yellowSource.clip = yellowClip;
        blueSource.clip = blueClip;
        orangeSource.clip = orangeClip;
    }

    // Update is called once per frame
    void Update()
    {
        if(gActi)
        {
            greenSource.Play();
            gActi = false;
        }

        if (rActi)
        {
            redSource.Play();
            rActi = false;
        }

        if (yActi)
        {
            yellowSource.Play();
            yActi = false;
        }

        if (bActi)
        {
            blueSource.Play();
            bActi = false;
        }

        if (oActi)
        {
            orangeSource.Play();
            oActi = false;
        }
    }

}
