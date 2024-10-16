using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bases8 : MonoBehaviour
{
    public GameObject bala;
    public GameObject[] cubitos;
    //Estructura de declaración de arreglo 
    //tipoDeVariable[] nombreDeArreglo; 
    int[] numeros;

    void Start()
    {
        //Estructura de asignación de un arreglo 
        //nombreDelArreglo = new int[numeroDePosiciones]
        numeros = new int[2];
        numeros[0] = 5;
        numeros[1] = 10;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (numeros[0] > 0)
            {
                GameObject copia = Instantiate(bala, transform.position, Quaternion.identity);
                copia.GetComponent<MeshRenderer>().material.color = Color.red;
                numeros[0] = numeros[0] - 1;
            }
        }
        if (Input.GetMouseButtonDown(1))
        {
            if (numeros[1] > 0)
            {
                GameObject copia = Instantiate(bala, transform.position, Quaternion.identity);
                copia.GetComponent<MeshRenderer>().material.color = Color.blue;
                numeros[1] = numeros[1] - 1;
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < cubitos.Length; i++)
            {
                Instantiate(cubitos[i],
                            transform.position + new Vector3(0, 0, 2f + i),
                            Quaternion.identity);
            }
        }


    }
}