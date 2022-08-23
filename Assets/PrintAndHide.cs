using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public class ConsolePrint : MonoBehaviour
public class PrintAndHide : MonoBehaviour
{
    public GameObject redObj;
    [SerializeField] private GameObject blueObj;
    private int i = 3;

    public Renderer rend;
    public int myRandomNumber;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        i = i + 1;
        Debug.Log(gameObject.name + ":" + i);
        
        if (i > 101)
        {
            redObj.SetActive(false);
        }
        //myRandomNumber = Random.Range(250, 251);

        //if (i = myRandomNumber)
        //{
        //    rend.enabled = false;
        //}
    }
}
