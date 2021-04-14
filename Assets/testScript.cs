using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testScript : MonoBehaviour
{
    //intellisense
    private GameObject testObject;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Started");
        testObject = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mosue click");
            //y value +=5;
            //testObject.transform.Rotate(0, 100 * Time.deltaTime, 0);

            // testObject.transform.position.Set(x, y, z);
            testObject.transform.position += Vector3.up * 10.0f;

        }






    }
}
