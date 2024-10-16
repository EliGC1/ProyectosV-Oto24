using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bases9 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 miVector = new Vector3(0, 0, 0);
        print("Magnitud: " + miVector.magnitude);
        if (Input.GetMouseButtonDown(0))
        {
            print("Presioné un botón:");
        }
        print("Mouse position: " + Input.mousePosition);
    }
}
