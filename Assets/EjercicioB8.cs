using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioB8 : MonoBehaviour
{
    Rigidbody esfera;
    int puntos;
    bool puntajeFinal;
    // Start is called before the first frame update
    void Start()
    {
        esfera = GetComponent<Rigidbody>();
        puntajeFinal = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            
            esfera.AddForce(Vector3.back);

        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (GetComponent<Rigidbody>().velocity.z == 0 && puntajeFinal == true)
        {
            if(other.tag == "P1")
            {
                puntos = puntos + 10;
                print("Tu puntuación es " + puntos);
                puntajeFinal = false;
            }
        }

        if (GetComponent<Rigidbody>().velocity.z == 0)
        {
            if (other.tag == "P2")
            {
                puntos = puntos + 20;
                print("Tu puntuación es " + puntos);
                puntajeFinal = false;
            }
        }

        if (GetComponent<Rigidbody>().velocity.z == 0)
        {
            if (other.tag == "P3")
            {
                puntos = puntos + 40;
                print("Tu puntuación es " + puntos);
                puntajeFinal = false;
            }
        }
    }
}

/*Instrucciones 11/09/23
* 1. Al presionar la barra espaciadora (GetKey), van a aplicar una fuerza mediante el método 
*    AddForce para atraer la esfera hacia atrás. 
* 2. Dependiendo de qué zona alcancee la pelota, van a sumar puntos a una variable. Si llega al
*    punto más lejano son 10 puntos, el punto intermedio son 20 puntos y si llegan al borde, 
*    ganarán 40 puntos. 
* 3. Los puntos los darán hasta que la bola se detenga por completo. Esto lo pueden hacer con la
*    propiedad velocity del Rigidbody. 
* Extras: 
* 4. Tienen que haber varias pelotas en el escenario. Yo puedo elegir, cuál voy a mover, con 
*    las flechas
* 5. Pongan algún obstáculo que se esté moviendo constantemente en el escenario para que no sea
*    tan fácil. 
*/