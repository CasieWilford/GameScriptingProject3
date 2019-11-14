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
            Destroy(note);
        }

        if (Input.GetKeyDown(key))
        {
           // StartCoroutine(KeyPressed());
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

    /*IEnumerator KeyPressed()
    {
        mr.material = pressedMat;
        yield return new WaitForSeconds(0.1f);
        mr.material = initial;
    }*/
}
