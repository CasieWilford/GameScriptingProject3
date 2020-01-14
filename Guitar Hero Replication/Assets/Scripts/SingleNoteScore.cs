using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SingleNoteScore : MonoBehaviour
{
    public static int singleNote = 0;

    Text score;

    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        score.text = "" + singleNote;

        if (singleNote > 9)
            singleNote = 0;
    }
}
