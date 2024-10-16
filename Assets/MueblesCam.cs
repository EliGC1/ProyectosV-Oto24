using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MueblesCam : MonoBehaviour
{

    public GameObject mueblesControl;
    public GameObject camPos;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Camera.main.transform.position = camPos.transform.position;
            Camera.main.transform.rotation = camPos.transform.rotation;

            Destroy(mueblesControl);
        }
    }
}
