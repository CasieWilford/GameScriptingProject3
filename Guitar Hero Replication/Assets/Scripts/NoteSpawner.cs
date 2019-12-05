using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Manually spawn notes.
public class NoteSpawner : MonoBehaviour
{
    public GameObject note;

    public KeyCode key;

    float noteRate;
    float nextNote;

    // Start is called before the first frame update
    void Start()
    {
        noteRate = .5f;
        nextNote = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        // Spawns specified note.
        if ((Input.GetKeyDown(key)) && Time.time > nextNote)
        {
            Instantiate(note, transform.position, Quaternion.identity);
            nextNote = Time.time + noteRate;
        }

        // Spawns all 5 notes.
        if ((Input.GetKeyDown(KeyCode.N)) && Time.time > nextNote)
        {
            Instantiate(note, transform.position, Quaternion.identity);
            nextNote = Time.time + noteRate;
        }
    }
}
