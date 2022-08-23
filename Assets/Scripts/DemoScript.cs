using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Generates a random number between 200 to 251 (inclusive)
public class DemoScript : MonoBehaviour
{
    public int myRandomNumber;

    // Start is called before the first frame update
    void Start()
    {
        // In the Range 250 -> 251 (inclusive of both)
        myRandomNumber = Random.Range(250, 251);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
