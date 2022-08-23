using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Generates a random number between 200 to 251 (inclusive)
public class DemoScript : MonoBehaviour
{
    public int myRandomNumber;

    public GameObject testObjectA;
    [SerializeField] private GameObject testObjectB;
    // Start is called before the first frame update
    void Start()
    {
        // In the Range 250 -> 251 (inclusive of both)
        myRandomNumber = Random.Range(250, 251);
        testObjectA.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
