using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bases3 : MonoBehaviour
{
    /*
     * Variables primitivas:
     * 1. float (decimales) float floatnte = 5.5f;
     * 2. int (entero) int entero = 1;
     * 3. string (palabras) string nombre = "Samir";
     * 4. bool (booleano / cierto o falso); bool booleano = true; 
     */

    //Struct
    Vector3 miVector;
    Color miColor;

    // Start is called before the first frame update
    void Start()
    {
        //Asignacion de Vector3
        //Estructura de asignacion de Struct
        //[nombreDeLaVariable] = new [TipoDeDato] (Parametros, fx, fy, fz);
        miVector = new Vector3(5f, 5f, 5f);
        miColor = new Color(0f, 0f, 1f, 1f);
        transform.position = miVector;
        //Para obener un componente en el MISMO OBJECTO, podemos usar GetComponent
        //La estructura es GetComponent<TipoDeComponente>();
        SphereCollider elCollider = GetComponent<SphereCollider>();
        elCollider.isTrigger = true;
        GetComponent<SphereCollider>().isTrigger = true;
    }








    // Update is called once per frame
    void Update()
    {
        
    }
}
