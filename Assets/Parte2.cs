using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parte2 : MonoBehaviour
{
    Vector3 unVector;
    Color unColor;
    int contador;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(5f, 10f, 15f);
        unColor = new Color(1f, 0f, 0f, 1f);
    }

   
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            contador++;
            print(contador);
        }

           if (contador >= 1 && contador <= 10)
            {
                GetComponent<MeshRenderer>().material.color = Color.red;
            }

            else if (contador >= 11 && contador <=20)
            {
                GetComponent<MeshRenderer>().material.color = Color.blue;
            }

            else if (contador >= 21)
            {
                GetComponent<MeshRenderer>().material.color = Color.green;
            }
        }
    }


//Errores del código
// No tiene los paréntesis después de declarar la variable Examen
//No es declarada como public o private
//No es necesario declarar la varible Vector3
