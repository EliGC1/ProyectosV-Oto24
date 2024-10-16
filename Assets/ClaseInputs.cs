using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClaseInputs : MonoBehaviour
{
    Collider miCollider;
    public TextMesh pregunta;
    public TextMesh r1;
    public TextMesh r2;
    Pregunta miPregunta;
    Pregunta miPregunta2;
    Pregunta miPregunta3;
    public GameObject img;
    


    int indicePregunta = 0;
    int correctas = 0;

    void Start()
    {
        miCollider = GetComponent<Collider>();

        Vector3 miVector = new Vector3(0, 0, 0);

        miPregunta = new Pregunta("¿Quién es el coordinador\n de la carrera?",
                                            "Manuel", "Razo", "Manuel");
       

        miPregunta2 = new Pregunta("¿Cómo se llama el profesor?", "Chang", "Samir", "Samir");
        miPregunta3 = new Pregunta("¿Qué ejercicio hace el profesor?", "Yoga", "Futbol", "Yoga");

        print("Mi pregunta dice: " + miPregunta.textoPregunta);

        pregunta.text = miPregunta.textoPregunta;
        r1.text = miPregunta.respuesta1;
        r2.text = miPregunta.respuesta2;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Pregunta preguntaActual;
            if (indicePregunta == 0)
            {
                preguntaActual = miPregunta;
            }
            else if (indicePregunta == 1)
            {
                preguntaActual = miPregunta2;
            }
            else
            {
                preguntaActual = miPregunta3;
            }
            if (Input.mousePosition.x < Screen.width / 2)
            {//Seleccionó la de la izquierda
                if (preguntaActual.respuesta1 == preguntaActual.respuestaCorrecta)
                {
                    pregunta.text = "¡CORRECTO!";
                    r1.text = "";
                    r2.text = "";
                    correctas++;
                }
                else
                {
                    pregunta.text = "¡INCORRECTO!";
                    r1.text = "";
                    r2.text = "";
                }
            }
            if (Input.mousePosition.x >= Screen.width / 2)
            {//Seleccionó la de la derecha
                if (preguntaActual.respuesta1 == preguntaActual.respuestaCorrecta)
                {
                    pregunta.text = "¡INCORRECTO!";
                    r1.text = "";
                    r2.text = "";
                }
                else
                {
                    pregunta.text = "¡CORRECTO!";
                    r1.text = "";
                    r2.text = "";
                    correctas++;
                }
            }
            indicePregunta = indicePregunta + 1;
            Invoke("PonmeNuevaPregunta", 2f);
        }
    }

    void PonmeNuevaPregunta()
    {
        Pregunta preguntaActual;
        if (indicePregunta == 0)
        {
            preguntaActual = miPregunta;
            //img[0].SetActive(true);
            ////img[1].SetActive(false);
            //img[2].SetActive(false);
        }
        else if (indicePregunta == 1)
        {
            preguntaActual = miPregunta2;
            //img[0].SetActive(false);
            //img[1].SetActive(true);
            //img[2].SetActive(false);
        }
        else
        {
            preguntaActual = miPregunta3;
            //img[0].SetActive(false);
            //img[1].SetActive(false);
            //img[2].SetActive(true);
        }


        pregunta.text = preguntaActual.textoPregunta;
        r1.text = preguntaActual.respuesta1;
        r2.text = preguntaActual.respuesta2;

        if (indicePregunta > 2)
        {
            pregunta.text = "Terminaste, tuviste: " + correctas + " correctas";
            r1.text = "";
            r2.text = "";
        }
    }
}



/*
 * Instrucciones 25/09/24 
 * 1. Creen tres preguntas diferentes dentro de su trivia
 * 2. Van a modificar su código para que ahora funcione con preguntas. 
 * Extras: 
 * 3. Añadan un nuevo enumerador llamado CategoriaDePregunta 
 * 4. Modifiquen su pregunta para que tenga otra propiedad de tipo CategoriaDePregunta 
 * 5. Extiendan sus constructores para que se asigne la CategoriaDePregunta
 */