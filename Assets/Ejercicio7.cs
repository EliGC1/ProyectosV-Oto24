using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ejercicio7 : MonoBehaviour
{
    public GameObject cuboTierra;
    GameObject piso;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            transform.Translate(0, 0, 0.05f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, 0, -0.05f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0.05f, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-0.05f, 0, 0);
        }


        if (Input.GetKeyDown(KeyCode.P))
        {
            for (int i = 0; i < 10; i = i + 1)
            {
                Instantiate(cuboTierra,
                           new Vector3(0, i, 0),
                           cuboTierra.transform.rotation);
            }
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            for (int i = 0; i < 10; i = i + 1)
            {
                Instantiate(cuboTierra,
                           new Vector3(i, 0, 0),
                           cuboTierra.transform.rotation);
            }
        }

        if (Input.GetKey(KeyCode.Space))
        {
            if (cuboTierra != null)
            {
                Destroy(cuboTierra);
            }
        }



    }
}
