using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteDeleter : MonoBehaviour
{ 
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Note"))
        {
            Destroy(other.gameObject);
        }
    }
}
