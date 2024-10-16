using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bases4 : MonoBehaviour
{
    //Scope o Alcance de variable
    //Variable global es la que est� arriba y la podemos usar en cualquier parte
    //de nuestro script (en cualquier m�todo). 
    int vidas; //Esto es una varible global porque est� afuera de todos nuestros m�todos. 

    //Modificadores de acceso 
    //Los dos modificadores de acceso que usaremos m�s son public y private
    public string nombre;//Las variables p�blicas se pueden ver desde otros script
                         //y adicionalmente, nos permite asignarlas desde el editor. 

    private int balas; //Las variables privada, s�lo se pueden acceder desde este
    //mismo script

    public GameObject otroObjeto;

    void Start()
    {
        nombre = "Omar";
        print("El nombre es: " + nombre);

        //Las variables locales son las que declaramos dentro de nuestros m�todos
        //estas variable s�lo las podemos uar en el m�todo que las declaramos. 
        //float velocidad;

        gameObject.SetActive(true);
        gameObject.name = "Fernando Colunga";

        otroObjeto.GetComponent<Light>().color = new Color(1, 0, 0, 1);

    }

    // Update is called once per frame
    void Update()
    {
        otroObjeto.GetComponent<Light>().color = new Color(Random.Range(0f,1f),Random.Range(0f,1f),Random.Range(0f,1f));

    }

    /*Instrucciones
     * 1. Van a modificar la propiedad de intensity del componente light, de la
     *    variable otroObjeto. 
     * 2. Van a pedir una nueva variable global p�blica de tipo objeto llamada
     *    tercerObjeto. Desde el editor van a asignarle el objeto que tiene la c�mara.
     * 3. Van a modificar la propiedad fieldOfView del componente Camera del tercerObjeto
     *    y le asignar�n un nuevo color 
     * Extras: 
     * 4. Van a modificar la prropiedad background del componente Camera del tercerObjeto
     * 5. Van a modificar el tipo de luz del componente Light de la variable otroObjeto. 
     * 
     */


}