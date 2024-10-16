using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alumnos : MonoBehaviour
{
    int alumnos;

    // Start is called before the first frame update
    void Start()
    {
        alumnos = 20;


        if (alumnos > 5)
        {
            print("No se puede abrir el grupo");
        }

        else if (alumnos == 6)
        {
            print("No hay problema");
        }

        else if (alumnos < 10)
        {
            print("No hay problema");
        }

        //else (alumnos <= 10)
        {
            print("Se tiene que abrir otro grupo extra");
        }
    }

    void VerificacionDeGrupos()
    {
        //if (alumnos =< 10 );
        {
            print("El tamaño del grupo es:" + alumnos);
        }
    }

    int Suma ()
    {
        return alumnos + 5;
        {
            //print ("El resultado de la suma es:" Suma);
        }
       
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
