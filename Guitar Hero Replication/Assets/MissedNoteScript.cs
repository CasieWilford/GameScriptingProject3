using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissedNoteScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag.Equals("GNote") || other.gameObject.tag.Equals("RNote") ||
            other.gameObject.tag.Equals("YNote") || other.gameObject.tag.Equals("BNote") || other.gameObject.tag.Equals("ONote"))
        {
            NoteCounter.noteValue = 0;
        }
    }
}
