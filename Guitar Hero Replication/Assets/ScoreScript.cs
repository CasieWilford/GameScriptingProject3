using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{

    public static int scoreValue = 0;
    Text score;

    public GameObject greeNoteFlame;
    public GameObject redNoteFlame;
    public GameObject yellowNoteFlame;
    public GameObject blueNoteFlame;
    public GameObject orangeNoteFlame;

    public static bool greenActive;
    public static bool redActive;
    public static bool yellowActive;
    public static bool blueActive;
    public static bool orangeActive;

    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();

        greeNoteFlame.SetActive(false);
        redNoteFlame.SetActive(false);
        yellowNoteFlame.SetActive(false);
        blueNoteFlame.SetActive(false);
        orangeNoteFlame.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + scoreValue;

        // Green Note Flame Animation.
        if (greenActive)
        {
            greeNoteFlame.SetActive(true);
        }
        else
            greeNoteFlame.SetActive(false);

        // Red Note Flame Animation.
        if (redActive)
        {
            redNoteFlame.SetActive(true);
        }
        else
            redNoteFlame.SetActive(false);

        // Yellow Note Flame Animation.
        if (yellowActive)
        {
            yellowNoteFlame.SetActive(true);
        }
        else
            yellowNoteFlame.SetActive(false);

        // Blue Note Flame Animation.
        if (blueActive)
        {
            blueNoteFlame.SetActive(true);
        }
        else
            blueNoteFlame.SetActive(false);

        // Orange Note Flame Animation.
        if (orangeActive)
        {
            orangeNoteFlame.SetActive(true);
        }
        else
            orangeNoteFlame.SetActive(false);
    }
}
