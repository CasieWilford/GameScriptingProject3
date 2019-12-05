using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsScript : MonoBehaviour
{
    public GameObject greenBP;
    public GameObject redBP;
    public GameObject yellowBP;
    public GameObject blueBP;
    public GameObject orangeBP;

    //public GameObject greenButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Green button pressed.
        if (Input.GetKey(KeyCode.A))
        {
            greenBP.SetActive(true);
        }
        else
            greenBP.SetActive(false);

        // Red button pressed.
        if (Input.GetKey(KeyCode.S))
        {
            redBP.SetActive(true);
        }
        else
            redBP.SetActive(false);

        // Yellow button pressed.
        if (Input.GetKey(KeyCode.J))
        {
            yellowBP.SetActive(true);
        }
        else
            yellowBP.SetActive(false);

        // Blue button pressed.
        if (Input.GetKey(KeyCode.K))
        {
            blueBP.SetActive(true);
        }
        else
            blueBP.SetActive(false);

        // Orange button pressed.
        if (Input.GetKey(KeyCode.L))
        {
            orangeBP.SetActive(true);
        }
        else
            orangeBP.SetActive(false);
    }
}
