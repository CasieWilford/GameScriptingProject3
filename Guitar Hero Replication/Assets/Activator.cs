using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour
{
    MeshRenderer mr;

    public KeyCode key;
    bool active = false;

    Material initial;
    public Material pressedMat;

    GameObject note;
    
    //Transform note;

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
            if (Input.GetKeyDown(KeyCode.A) && active)
            {
                StartCoroutine(GreenAni());
            }

            if (Input.GetKeyDown(KeyCode.S) && active)
            {
                StartCoroutine(RedAni());
            }

            if (Input.GetKeyDown(KeyCode.J) && active)
            {
                StartCoroutine(YellowAni());
            }

            if (Input.GetKeyDown(KeyCode.K) && active)
            {
                StartCoroutine(BlueAni());
            }

            if (Input.GetKeyDown(KeyCode.L) && active)
            {
                StartCoroutine(OrangeAni());
            }

            Destroy(note);
            ScoreScript.scoreValue += 20;
            NoteCounter.noteValue += 1;

            active = false;
        }
        else if (Input.GetKeyDown(key) && !active)
        {
            NoteCounter.noteValue = 0;
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

        if (other.gameObject.tag.Equals("Note"))
            note = other.gameObject;
    }

    private void OnTriggerExit(Collider other)
    {
        active = false;
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
