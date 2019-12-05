using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteDeleter : MonoBehaviour
{ 
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("GNote") || other.gameObject.tag.Equals("RNote") ||
            other.gameObject.tag.Equals("YNote") || other.gameObject.tag.Equals("BNote") || other.gameObject.tag.Equals("ONote"))
        {
            Destroy(other.gameObject);
        }
    }
}
