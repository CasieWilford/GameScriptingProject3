using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarSpawner : MonoBehaviour
{
    public GameObject horizontalBar;

    float spawnRate;
    float nextBar;

    // Start is called before the first frame update
    void Start()
    {
        spawnRate = .5f;
        nextBar = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextBar)
        {
            Instantiate(horizontalBar, transform.position, Quaternion.identity);
            nextBar = Time.time + spawnRate;
        }
    }
}
