using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoteCounter : MonoBehaviour
{
    public static int noteValue = 0;
    Text score;

    float multiNum = 1;

    public GameObject noteBox;
    public GameObject singleNoteText;
    public GameObject doubleNoteText;
    public GameObject tripleNoteText;
    
    public GameObject twoText;
    public GameObject threeText;
    public GameObject fourText;

    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
        
        noteBox.SetActive(false);
        singleNoteText.SetActive(false);
        doubleNoteText.SetActive(false);
        tripleNoteText.SetActive(false);
        
        twoText.SetActive(false);
        threeText.SetActive(false);
        fourText.SetActive(false);
        noteBox.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (noteValue / 10 == 1)
        {
            Activator.multiplier = 2;
            multiNum = 2;
            Debug.Log("Times 2");
        }

        if (noteValue / 10 == 2)
        {
            Activator.multiplier = 3;
            multiNum = 3;
            Debug.Log("Times 3");
        }

        if (noteValue / 10 == 3)
        {
            Activator.multiplier = 4;
            multiNum = 4;
            Debug.Log("Times 4");
        }

        if (noteValue < 10)
        {
            Activator.multiplier = 1;
            multiNum = 1;
            Debug.Log("Times 1");
        }

        if (multiNum == 2)
        {
            twoText.SetActive(true);
        }
        else if (multiNum == 3)
        {
            twoText.SetActive(false);
            threeText.SetActive(true);
        }
        else if (multiNum == 4)
        {
            threeText.SetActive(false);
            fourText.SetActive(true);
        }
        else if (multiNum == 1)
        {
            twoText.SetActive(false);
            threeText.SetActive(false);
            fourText.SetActive(false);
        }

        score.text = "Note: " + noteValue;

        // Activates note box and note counter to appear.
        if (noteValue >= 5)
        {
            noteBox.SetActive(true);
            singleNoteText.SetActive(true);
            doubleNoteText.SetActive(true);
        }
        else
        {
            noteBox.SetActive(false);
            singleNoteText.SetActive(false);
            doubleNoteText.SetActive(false);
        }

        // Activates hundredth place note value.
        if (noteValue >= 100)
        {
            tripleNoteText.SetActive(true);
        }
        else
            tripleNoteText.SetActive(false);
    }
}
