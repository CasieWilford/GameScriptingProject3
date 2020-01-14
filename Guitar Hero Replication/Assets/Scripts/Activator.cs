using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour
{
    MeshRenderer mr;

    public KeyCode key;

    bool active = false;

    bool greenActive = false;
    bool redActive = false;
    bool yellowActive = false;
    bool blueActive = false;
    bool orangeActive = false;
    
    Material initial;
    public Material pressedMat;

    GameObject note;

    public static int multiplier = 1;

    private void Awake()
    {
        mr = GetComponent<MeshRenderer>();
        //note = GameObject.FindGameObjectWithTag("note").transform;
    }

    // Start is called before the first frame update
    void Start()
    {
        initial = mr.material;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(key) && active)
        {
            if (Input.GetKeyDown(KeyCode.A) && greenActive)
            {
                StartCoroutine(GreenAni());
            }

            if (Input.GetKeyDown(KeyCode.S) && redActive)
            {
                StartCoroutine(RedAni());
            }

            if (Input.GetKeyDown(KeyCode.J) && yellowActive)
            {
                StartCoroutine(YellowAni());
            }

            if (Input.GetKeyDown(KeyCode.K) && blueActive)
            {
                StartCoroutine(BlueAni());
            }

            if (Input.GetKeyDown(KeyCode.L) && orangeActive)
            {
                StartCoroutine(OrangeAni());
            }
            
            Destroy(note);
            ScoreScript.scoreValue += (20 * multiplier);
            NoteCounter.noteValue += 1;
            SingleNoteScore.singleNote += 1;
            DoubleNoteScore.TotalNote += 1;

            active = false;
            greenActive = false;
            redActive = false;
            yellowActive = false;
            blueActive = false;
            orangeActive = false;
        }
        else if (Input.GetKeyDown(key) && !active)
        {
            NoteCounter.noteValue = 0;

            SingleNoteScore.singleNote = 0;
            DoubleNoteScore.TotalNote = 0;
            DoubleNoteScore.noteCount = 0;
        }
        
        // Exits Program.
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        active = true;

        if (other.gameObject.tag.Equals("GNote") || other.gameObject.tag.Equals("RNote") ||
            other.gameObject.tag.Equals("YNote") || other.gameObject.tag.Equals("BNote") || other.gameObject.tag.Equals("ONote"))
        {
            note = other.gameObject;
        }

        // Checks for Green Note.
        if (other.gameObject.tag.Equals("GNote"))
        {
            greenActive = true;
        }

        // Checks for Red Note.

        if (other.gameObject.tag.Equals("RNote"))
        {
            redActive = true;
        }

        // Checks for Yellow Note.
        if (other.gameObject.tag.Equals("YNote"))
        {
            yellowActive = true;
        }

        // Checks for Blue Note.
        if (other.gameObject.tag.Equals("BNote"))
        {
            blueActive = true;
        }

        // Checks for Orange Note.
        if (other.gameObject.tag.Equals("ONote"))
        {
            orangeActive = true;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        active = false;
        greenActive = false;
        redActive = false;
        yellowActive = false;
        blueActive = false;
        orangeActive = false;
    }

    // Green Flame Coroutine.
    IEnumerator GreenAni()
    {
        ScoreScript.greenActive = true;

        yield return new WaitForSeconds(.16f);

        ScoreScript.greenActive = false;
    }

    // Red Flame Coroutine.
    IEnumerator RedAni()
    {
        ScoreScript.redActive = true;

        yield return new WaitForSeconds(.16f);

        ScoreScript.redActive = false;
    }

    // Yellow Flame Coroutine.
    IEnumerator YellowAni()
    {
        ScoreScript.yellowActive = true;

        yield return new WaitForSeconds(.16f);

        ScoreScript.yellowActive = false;
    }

    // Blue Flame Coroutine.
    IEnumerator BlueAni()
    {
        ScoreScript.blueActive = true;

        yield return new WaitForSeconds(.16f);

        ScoreScript.blueActive = false;
    }

    // Orange Flame Coroutine.
    IEnumerator OrangeAni()
    {
        ScoreScript.orangeActive = true;

        yield return new WaitForSeconds(.16f);

        ScoreScript.orangeActive = false;
    }
}
