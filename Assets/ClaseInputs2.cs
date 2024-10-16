using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClaseInputs2 : MonoBehaviour
{
    private GameObject objetoSeleccionado;

    void Update()
    {
        Vector3 posicionDelMouseAlMundo = Camera.main.ScreenToWorldPoint(
                                            new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1000));
        if (Input.GetMouseButtonDown(0))
        {
            Debug.DrawRay(Camera.main.transform.position, posicionDelMouseAlMundo * 1000, Color.yellow);
            RaycastHit hitInfo;
            if (Physics.Raycast(Camera.main.transform.position, posicionDelMouseAlMundo, out hitInfo, 1000f))
            {
                hitInfo.collider.gameObject.GetComponent<MeshRenderer>().material.color = Color.yellow;
                objetoSeleccionado = hitInfo.collider.gameObject;

            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            objetoSeleccionado = null;
        }
        if (objetoSeleccionado != null)
        {
            objetoSeleccionado.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,
                Input.mousePosition.y, 10));
        }
        //transform.position = //El 5 es qu� tan lejos de la c�mara
    }



    //Instrucciones 02/10/24
    /*1. Van a descargar el siguiente pack de muebles y lo meter�n en su proyecto: https://assetstore.unity.com/packages/3d/props/furniture/furniture-free-pack-192628
     *2. Van a instanciar alguno de los muebles dando click izquierdo
     *3. Al momento que instanc�en el mueble, est� debe aparecer frente a la c�mara y siguiendo el mouse. 
     *4. Al momento de presionar S (de soltar) soltar�n este objeto. 
     *5. Todo debe de estarse colocando sobre una plataforma la cual no pueden mover. 
     *EXTRAS:
     *6. Si se presiona click izquierdo sobre alg�n objeto, podr�n moverlo a otra posici�n. 
     *7. Mientras est�n arrastrando alg�n objeto, pueden utilizar las flechas para cambiar el color 
     *8. Al presionar enter, reproducir�n  una animaci�n de la c�mara que estar� girando al rededor de la escena para que vean 
     *   c�mo quedaron sus muebles. 
     */
}
