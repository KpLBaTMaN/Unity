using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testScript : MonoBehaviour
{
    //intellisense
    public Light myLight;
    private Light myOtherLight;
    private GameObject playerObject;
    private GameObject testObject;

    int numberTest = 5;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Started");
        Debug.Log("This is my first number output: " + numberTest);




    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {


        }


    }
}
