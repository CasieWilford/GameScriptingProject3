using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoubleNoteScore : MonoBehaviour
{
    public static int TotalNote = 0;
    public static int noteCount = 0;

    Text score;

    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        if (TotalNote == 10)
        {
            noteCount += 1;
            TotalNote = 0;
        }

        score.text = "" + noteCount;
    }
}
