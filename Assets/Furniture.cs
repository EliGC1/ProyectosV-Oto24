using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Furniture : MonoBehaviour
{
    public string textoMueble;
    
    public List<GameObject> listaDeMuebles;
    private int indiceMuebleActual = 0;

    public List<Color> colores;
    private int indiceColorActual = 0;

    
    public GameObject mueble;
    private GameObject objetoSeleccionado;
   
    public Material materialTransparente;
    private GameObject objetoPreview;

    public Sprite imagenMueble;
    private int indiceImagen = 0;
    
    private void Start()
    {
        
        objetoPreview = Instantiate(listaDeMuebles[0]);
        objetoPreview.GetComponent<MeshRenderer>().material = materialTransparente;
        objetoPreview.GetComponent<Collider>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.C))
        {//Dejó presionada la tecla C
            if (Input.GetMouseButtonDown(0))
            {
                if (objetoSeleccionado != null)
                {
                    objetoSeleccionado.GetComponent<MeshRenderer>().material.color = colores[indiceColorActual];
                    indiceColorActual = indiceColorActual + 1;
                    if (indiceColorActual == colores.Count)
                    {
                        indiceColorActual = 0;
                    }
                }
            }
        }





        if (Input.GetMouseButtonDown(0) && objetoSeleccionado == null)
        {
            objetoPreview.SetActive(false);
            objetoSeleccionado = Instantiate(listaDeMuebles[indiceMuebleActual]);
        }



        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            indiceMuebleActual = indiceMuebleActual - 1;
            if (indiceMuebleActual < 0)
            {
                indiceMuebleActual = 0;
            }
            objetoPreview.GetComponent<MeshFilter>().mesh = listaDeMuebles[indiceMuebleActual].GetComponent<MeshFilter>().sharedMesh;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            indiceMuebleActual = indiceMuebleActual + 1;
            if (indiceMuebleActual == listaDeMuebles.Count)
            {
                indiceMuebleActual = 0;
            }
            objetoPreview.GetComponent<MeshFilter>().mesh = listaDeMuebles[indiceMuebleActual].GetComponent<MeshFilter>().sharedMesh;

        }


        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            indiceMuebleActual = indiceMuebleActual - 1;
            if (indiceMuebleActual < 0)
            {
                indiceMuebleActual = 0;
            }
            //objetoPreview.GetComponent<Image>().mesh = listaDeMuebles[indiceMuebleActual].GetComponent<MeshFilter>().sharedMesh;

        }







        if (Input.GetKeyDown(KeyCode.S))
        {
            if (objetoSeleccionado.GetComponent<Rigidbody>() == null)
            { //IF anidado
                objetoSeleccionado.AddComponent<Rigidbody>();
            }
            objetoSeleccionado = null;
            objetoPreview.SetActive(true);
        }
        if (objetoSeleccionado != null)
        {
            objetoSeleccionado.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,
                Input.mousePosition.y, 10));
        }
        else
        {
            objetoPreview.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,
                    Input.mousePosition.y, 10));
        }


        //¿Cómo puedo hacer que al dar click izquierdo, cambie el color, siempre y cuando, esté presionado la tecla C de Color

    }
}

/*Instrucciones 09/10/24
 * 1. Cuando cambie de mueble con las flechas, van a colocar el nombre del mueble en un Text de la UI (haganlo con el de Legacy -> Text).
 *    Tienen libertad de ponerle el nombre que quieran al mueble. 
 * 2. Cuando cambien de mueble las flechas, van a colocar la imagen del mueble, en un Image de la UI. Tienen que sacar sus screenshots. 
 * Extras: 
 * 3. Van a tener tres imagenes en vez de sólo una y van a mostrar las fotos de los muebles y de alguna forma van a comunicar  cuál 
 *    está seleccionado actualmente. 
 * 
 * 
 */

/*Instrucciones 07/10/24
 * 1. Quiero que al presionar las flechas izquierda y derecha, ustedes puedan ir cambiando la rotación del objeto en el eje y,
 * 45° por cada presión 
 * 2. Con las flechas de arriba y abajo, van a ir cambiando el mueble que van a poner (no es necesario que se muestre un preview). 
 * 3. Si dejan presionada la tecla G de giro, van a poder girar en el eje X el objeto con las mismas flechas de izquierda y derecha. 
 * 4. Si se presiona click izquierdo sobre algún objeto, podrán moverlo a otra posición y también girarlo y cambiarle el color. 
 * EXTRAS: 
 * 5. Al presionar la barra espaciadora, van a mover la cámara para que esté viendo de frente su plataforma y tengan otra perspectiva
 *    de cómo acomodaron todo. 
 * 6. En este nuevo modo de vista, YA NO PUEDEN MOVER LOS MUEBLES NI PONER NUEVOS 
 * 7. Si presionan las flechas, van a poder moverse hacia adelante, izquierda y derecha para visualizar su escena. 
 */



