using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bases2 : MonoBehaviour
{
    //UN igual (=) es asignación
    //DOS iguales (==) es comparación/pregunta

    //Booleanos
    //miBooleana = false; //True o False

    // Start is called before the first frame update
    void Start()
    {
        //Condicional IF
        //if (puedeSaltar == true)
        //if(presionaTeclaEspaciadora == true)

        //Estructura IF
        //if ( CONDICION )
        //{ ¿Qué hago? }

        //if (TRUE O FALSE)

        string alumno = "Omar"; //Declaramos y asignamos la variable alumno
        if (alumno == "Omar") { //Preguntamos si el alumno es Omar
            print("Hola Omar"); //¿Qué voy a hacer?
        }

        else
        {
            print("El alumno no es Omar");
        }

        float dinero = 200f;
        if (dinero < 100f) //NO OLVIDEN QUE HAY <= Y HAY >=
        {
            print("Te alcanza para un bowl de pulled Pork");
        }

        else if (dinero > 100f)

        {
            print("Te alcanza para seis galletas");
        }

        else {

        }

        //NUNCA COMPAREN FLOTANTES CON ==
        //PORQUE NO ES LO MISMO NINGUNO DE LOS SIGUIENTES
        //100F, 100.0F, 100.001, 100.000000000001
        if (dinero == 100f) { }

        if (dinero < 100) {
        }
        if ((dinero > 100)) {
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            //Inovacion del metodo
            //Saludar();
            string persona = "Netza";
            //Saludar(persona);
            //Saludar("Netza");

            //Saludar()
        }

        if (Input.GetKeyDown(KeyCode.D)) {
            float pesoDolar = CuantosPersosPorDolar();
            if (pesoDolar < 20f) {
                print("Hijole esta bajo");
            }
            else
            {
                print("Esta alto el dolar");
            }
        }
    }


    //ESTRUCTURA DE UN METODO 
    //[Tipo de Retorno] [NombreDelMetodo] (Parametros) {Contenido del metodo}
    //Declaracion de un metodo
    void Saludar() {
        print("Hola");
    }

    //Cuando tengo dos m[etodos que se llaman igual pero reciben parametros diferentes
    //se les 
    void Saludar(string personaPorSaludar) {
        print("Hola" + personaPorSaludar);
    }


    void Saludar(string personaPorSaludar, string personaQueSaluda) {
        //Ojo aqu[i, los par[ametros,  se separan por coma y tenemos que volver a 
        //establecer el tipo de parametro para todos los parametros
        print("Hola" + personaPorSaludar + "te manda saludos" + personaQueSaluda);
    }

    float CuantosPersosPorDolar() {
        return 18.75f; //No olviden que si establecemos un tipo de etorno quue no sea
        //void. Tenemos que utilizar reutrn dentro del metodo.
    }
}

    /*Intrucciones
     * 1. Declarar una variable global llamada alumnos de entero
     * 2. Asignar en el Start el valor de alumnos
     * 3. Hacer un IF que dependiendo de cuantos alumnos hayan, hara lo siguiente:
     *- Si hay menos de 5 alumnos, diga que no se puede abrir el grupo
     *- Si hay mas de 6 alumnos y menos de 10, diga que no hay problema
     *- Si hay 10 o mas alumnos, diga que se tiene que abrir otro grupo extra.
     *4. Hacer un metodo llamado verificacion de grupos, que contendra
     *el IF anterior. Este metodo tiene que recibir el tama;o del grupo e imprimir
     *el mensaje correspondiente.
     *5. Van a declarar un metodo llamado Suma, que regrese la suma de dos numeros.*/

