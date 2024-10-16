using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Pregunta
{
    public string textoPregunta;//¿Quién es el coordinador de la carrera?
    public string respuesta1; //Manuel
    public string respuesta2; //Razo
    public string respuestaCorrecta; //Manuel 

    //Estructura para definir el constructor
    //public NombreDelStruct(PARAMETRO){Asignar valores}

    /// <summary>
    /// Constructor para crear una pregunta
    /// </summary>
    /// <param name="pregunta"></param>
    /// <param name="r1"></param>
    /// <param name="r2"></param>
    /// <param name="rCorrecta"></param>
    public Pregunta(string pregunta, string r1, string r2, string rCorrecta)
    {
        respuesta2 = r2;
        textoPregunta = pregunta;
        respuesta1 = r1;
        respuestaCorrecta = rCorrecta;
    }

    /// <summary>
    /// Constructor que toma la primera respuesta como correcta
    /// </summary>
    /// <param name="pregunta"></param>
    /// <param name="r1"></param>
    /// <param name="r2"></param>
    public Pregunta(string pregunta, string r1, string r2)
    {
        textoPregunta = pregunta;
        respuesta1 = r1;
        respuesta2 = r2;
        respuestaCorrecta = r1;
    }



}





//PREGUNTA 1
public struct Pregunta1
{
    public string textoPregunta;//Cual es el color favorito de Eli?
    public string respuesta1; //Rosa
    public string respuesta2; //Negro
    public string respuestaCorrecta; //Negro

    public Pregunta1(string pregunta, string r1, string r2, string rCorrecta)
    {
        respuesta2 = r2;
        textoPregunta = pregunta;
        respuesta1 = r1;
        respuestaCorrecta = rCorrecta;
    }


    public Pregunta1(string pregunta, string r1, string r2)
    {
        textoPregunta = pregunta;
        respuesta1 = r1;
        respuesta2 = r2;
        respuestaCorrecta = r2;
    }
}

//PREGUNTA 2
public struct Pregunta2
{
    public string textoPregunta;//Eli es de gatos o perros?
    public string respuesta1; //Gatos
    public string respuesta2; //Perros
    public string respuestaCorrecta; //Gatos

    public Pregunta2(string pregunta, string r1, string r2, string rCorrecta)
    {
        respuesta2 = r2;
        textoPregunta = pregunta;
        respuesta1 = r1;
        respuestaCorrecta = rCorrecta;
    }


    public Pregunta2(string pregunta, string r1, string r2)
    {
        textoPregunta = pregunta;
        respuesta1 = r1;
        respuesta2 = r2;
        respuestaCorrecta = r1;
    }
}


//PREGUNTA 3
public struct Pregunta3
{
    public string textoPregunta;//Cual es el videojuego favorito de Eli?
    public string respuesta1; //Residentl Evil
    public string respuesta2; //Fatal Frame
    public string respuestaCorrecta; //Fatal Frame

    public Pregunta3(string pregunta, string r1, string r2, string rCorrecta)
    {
        respuesta2 = r2;
        textoPregunta = pregunta;
        respuesta1 = r1;
        respuestaCorrecta = rCorrecta;
    }
    
    public Pregunta3(string pregunta, string r1, string r2)
    {
        textoPregunta = pregunta;
        respuesta1 = r1;
        respuesta2 = r2;
        respuestaCorrecta = r2;
    }


}

public struct Fondo1
{

}



