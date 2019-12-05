using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomNoteSpawner : MonoBehaviour
{
    public GameObject greenNote;
    public GameObject redNote;
    public GameObject yellowNote;
    public GameObject blueNote;
    public GameObject orangeNote;

    int randomNum;

    float spawnRate;
    float nextNote;
    float spawnSpeed = .5f;

    public Transform greenLocation;
    public Transform redLocation;
    public Transform yellowLocation;
    public Transform blueLocation;
    public Transform orangeLocation;
    
    
    bool numberGen = false;

    // Start is called before the first frame update
    void Start()
    {
        spawnRate = spawnSpeed;
        nextNote = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextNote)
        {
            numberGen = true;

            StartCoroutine(NumberGen());

            Debug.Log(randomNum);

            switch (randomNum)
            {
                case 1:
                    Instantiate(greenNote, greenLocation.position, Quaternion.identity);
                    break;
                case 2:
                    Instantiate(redNote, redLocation.position, Quaternion.identity);
                    break;
                case 3:
                    Instantiate(yellowNote, yellowLocation.position, Quaternion.identity);
                    break;
                case 4:
                    Instantiate(blueNote, blueLocation.position, Quaternion.identity);
                    break;
                case 5:
                    Instantiate(orangeNote, orangeLocation.position, Quaternion.identity);
                    break;
                // Spawns green and red notes.
                case 6:
                    Instantiate(greenNote, greenLocation.position, Quaternion.identity);
                    Instantiate(redNote, redLocation.position, Quaternion.identity);
                    break;
                // Spawns blue and orange notes.
                case 7:
                    Instantiate(blueNote, blueLocation.position, Quaternion.identity);
                    Instantiate(orangeNote, orangeLocation.position, Quaternion.identity);
                    break;
                // Spawns yellow and green notes.
                case 8:
                    Instantiate(greenNote, greenLocation.position, Quaternion.identity);
                    Instantiate(yellowNote, yellowLocation.position, Quaternion.identity);
                    break;
            }

            nextNote = Time.time + spawnRate;
        }
        else
            numberGen = false;
    }

    IEnumerator NumberGen()
    {
        while(numberGen)
        {
            randomNum = Random.Range(1, 9);
            yield return new WaitForSeconds(spawnSpeed);
        }
    }
}
