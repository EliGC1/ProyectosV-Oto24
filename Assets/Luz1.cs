using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luz1 : MonoBehaviour
{
    float intensidadDeLuz;
    float tamanoLuz;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                intensidadDeLuz++;
            }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            intensidadDeLuz--;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            tamanoLuz++;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            tamanoLuz--;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            intensidadDeLuz++;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GetComponent<Light>().intensity = intensidadDeLuz;
            GetComponent<Light>().cookieSize = tamanoLuz;
        }

        if (intensidadDeLuz > 20)
        {
            intensidadDeLuz = 0;
        }

    }
}
