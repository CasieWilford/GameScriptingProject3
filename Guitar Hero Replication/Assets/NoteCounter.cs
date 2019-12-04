using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoteCounter : MonoBehaviour
{
    public static int noteValue = 0;
    Text score;

    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Notes: " + noteValue;
    }
}
