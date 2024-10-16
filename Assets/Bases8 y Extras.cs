using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bases8yExtras : MonoBehaviour
{
    public GameObject bala;
    public GameObject[] cubitos;
    //Estructura de declaración de arreglo 
    //tipoDeVariable[] nombreDeArreglo; 
    int[] numeros;

    public GameObject[] inventario;

    public GameObject objetoChocado;

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

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, 0, 0.025f, Space.World);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, 0, -0.025f, Space.World);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-0.025f, 0, 0, Space.World);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0.025f, 0, 0, Space.World);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            if (objetoChocado != null)
            {
                if (inventario[0] == null)
                {
                    inventario[0] = objetoChocado;
                    objetoChocado.SetActive(false);
                    objetoChocado = null;
                }
                if (inventario[1] == null)
                {
                    inventario[1] = objetoChocado;
                    objetoChocado.SetActive(false);
                    objetoChocado = null;
                }
                if (inventario[2] == null)
                {
                    inventario[2] = objetoChocado;
                    objetoChocado.SetActive(false);
                    objetoChocado = null;
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (inventario[2] != null)
            {
                inventario[2].SetActive(true);
                inventario[2].transform.position = transform.position + new Vector3(0, 0, 2f);
                inventario[2] = null;
            }
            else if (inventario[1] != null)
            {
                inventario[1].SetActive(true);
                inventario[1].transform.position = transform.position + new Vector3(0, 0, 2f);
                inventario[1] = null;
            }
            else if (inventario[0] != null)
            {
                inventario[0].SetActive(true);
                inventario[0].transform.position = transform.position + new Vector3(0, 0, 2f);
                inventario[0] = null;
            }


        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Cubito")
        {
            objetoChocado = collision.gameObject;
        }
    }
}


/*Instrucciones 09/09/24
 * 1. Tienen que implementar los famosos "controles de tanque" del primer Resident Evil 
 *    su funcionamiento consta en que las flechas izquierda y derecha, giran al personaje
 *    en su propio eje. Mientras que las flechas adelante y atrás, lo mueven hacia adelante 
 *    o hacia atrás respectivamente. 
 * 2. Tienen que implementar un sistema de cámara, donde dependiendo hacia donde me mueva, 
 *    me va a cambiar la cámara. Esto lo pueden hacer con colisiones de tipo trigger. 
 * Extra: 
 * 3. Quiero  que haya dos items en el mundo, que serían dos GameObjects. Con la tecla R de 
 *    recoger, quiero que el objeto con el que estén chocando, desaparezca y lo guarden en su 
 *    inventario que es un arreglo de GameObjects. 
 * 4. Quiero que al presionar la tecla C de colocar, vuelvan a poner el objeto que tienen en su
 *    inventario, en el piso. 
 * 
 * 
 */