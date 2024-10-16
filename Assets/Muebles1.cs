using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Muebles1 : MonoBehaviour
{
    public List<GameObject> mueblesPrefabs;
    public List<Sprite> mueblesSprites;
    public GameObject prefabMueble;

    private GameObject instanciarMueble;
    private bool muebleSeleccionado;

    private bool giro;

    public Text textoMueble;

    public List<GameObject> listaDeMuebles;
    private int indiceMuebleActual = 0;

    public List<Color> colores;
    private int indiceColorActual = 0;


    public GameObject mueble;
    private GameObject objetoSeleccionado;

    public Material materialTransparente;
    private GameObject objetoPreview;

    public Image imagenMueble;
    private int indiceImagen = 0;



    // Start is called before the first frame update
    void Start()
    {
        objetoPreview = Instantiate(mueblesPrefabs[0]);
        objetoPreview.GetComponent<MeshRenderer>().material = materialTransparente;
        objetoPreview.GetComponent<Collider>().enabled = false;

        textoMueble.text = mueblesPrefabs[indiceMuebleActual].name;
        imagenMueble.sprite = mueblesSprites[indiceMuebleActual];
    }

    // Update is called once per frame
    void Update()
    {

        //COLOR
        if (Input.GetKey(KeyCode.C))
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (instanciarMueble != null)
                {
                    instanciarMueble.GetComponent<MeshRenderer>().material.color = colores[indiceColorActual];
                    indiceColorActual++;

                    if (indiceColorActual == colores.Count)
                    {
                        indiceColorActual = 0;
                    }
                }
            }
        }




        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            CambioMueble(0);
            indiceMuebleActual++;
            if (indiceMuebleActual >= mueblesPrefabs.Count)
                indiceMuebleActual = 0;
            objetoPreview.GetComponent<MeshFilter>().mesh = mueblesPrefabs[indiceMuebleActual].GetComponent<MeshFilter>().sharedMesh;
            //Debug.Log("Mueble actual: " + mueblesPrefabs[indiceMuebleActual].name);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            CambioMueble(0);
            indiceMuebleActual--;
            if (indiceMuebleActual < 0)
                indiceMuebleActual = mueblesPrefabs.Count - 1;
            objetoPreview.GetComponent<MeshFilter>().mesh = mueblesPrefabs[indiceMuebleActual].GetComponent<MeshFilter>().sharedMesh;

            //Debug.Log("Mueble actual: " + mueblesPrefabs[indiceMuebleActual].name);
        }







       



        Vector3 posicionMouseEnMundo = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 40f));
        if (Input.GetMouseButtonDown(0) && !muebleSeleccionado)
        {
            instanciarMueble = Instantiate(mueblesPrefabs[indiceMuebleActual], Camera.main.transform.position + Camera.main.transform.forward * 2f,
                Quaternion.Euler(0, 180, 0));

            muebleSeleccionado = true;
            objetoPreview.SetActive(false);
        }
        else
        {
            objetoPreview.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 40f));
            objetoPreview.transform.rotation = Quaternion.Euler(0, 180, 0);
        }

        if (muebleSeleccionado && instanciarMueble != null)
        {
            instanciarMueble.transform.position = new Vector3(posicionMouseEnMundo.x, posicionMouseEnMundo.y, posicionMouseEnMundo.z);
        }





        if (Input.GetKey(KeyCode.G))
        {
            giro = true;

            if (Input.GetKey(KeyCode.RightArrow))
            {
                instanciarMueble.transform.Rotate(Vector3.right, 1f);
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                instanciarMueble.transform.Rotate(Vector3.right, -1f);
            }
        }





        if (muebleSeleccionado && Input.GetKeyDown(KeyCode.S))
        {
            muebleSeleccionado = false;
            objetoPreview.SetActive(true);
        }


        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Rotate(0f, 45f, 0f);
        }

        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Rotate(0f, -45f, 0f);
        }
    }




    //CAMBIO DE MUEBLES
    void CambioMueble(int cambio)
    {
        indiceMuebleActual += cambio;

        if (indiceMuebleActual >= mueblesPrefabs.Count)
            indiceMuebleActual = 0;

        else if (indiceMuebleActual < 0)
            indiceMuebleActual = mueblesPrefabs.Count - 0;

        textoMueble.text = mueblesPrefabs[indiceMuebleActual].name;
        imagenMueble.sprite = mueblesSprites[indiceMuebleActual];
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

