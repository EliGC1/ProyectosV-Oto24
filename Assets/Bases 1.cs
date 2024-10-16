using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bases1 : MonoBehaviour
{
    //Cuando declaran variables hasta arriba se denominan VARIABLES GLOBALES

    //VARIABLE PRIMITIVA
    //Estructura para declarar variable
    // [Tipo de Variable] [nombre de la variable]
    int numero; //Nùmeros enteros -5, 1, 10, 0
    float numeroFlotante; //Nùmeros decimales 2.8, -2.8
    string texto; //Sòlo puede contener texto "Samir", "Sabina"

    char CARACTER = 'c';

    void Start()
    {
        //Estructura para asignar variables
        //[nombre de la variable] = [valor nuevo de la variable]
        numero = 10;
        numero = 5;

        numeroFlotante = 10.0f; //Al momento de asignar flotantes, hay que ponerle la f al final

        texto = "Samir";

        //Las variables que se declaran dentro de los metodos se denominan VARIABLES LOCALES
        //Declaracion y asignaci[on
        string nombreAlumno = "Emiliano";
        print("Mi alumno es: " + nombreAlumno);

        //Operaciones aritmeticas
        //+, -, *, /
        numero = 10 / 5;
        numero = numero + 1; //numero++;
       
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Light>().intensity = numeroFlotante; //La luz recibe un valor flotante
        }
    }

    //Para que funcione este script, tienen que anadirlo al GameObject directional light
    /*1. Van a declarar una variable global de tipo entero llamada intensidadDeLuz
     *2. Al presionar la flecha derecha, van a incrementar el valor de intensidadDeLuz
     *3. Al presionar la flecha izquierda, van a disminuir el valor de la intensidadDeLuz
     *4. Cuando presionen la tecla Escape, van a asignar a la luz, el valor de intensidadDeLuz
    Extra: Declaren otra variable llamada tamanoLuz que va a mmodificar la propiedad size de la luz 
    asegurense de hacer las operaciones de intensidadDeLuz pero ahora con A y D. 
     */


}

