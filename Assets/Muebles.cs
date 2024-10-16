using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Muebles : MonoBehaviour
{

    public GameObject muebleUno;
    private GameObject objetoMove;
    private GameObject objetoSeleccionado;
    public float rotarObjeto = 45f;

    public List<Color> colores;
    private int indiceColorActual = 0;

    public List<GameObject> muebleLista;
    private int indiceObjetoActual = 0;

    public Material materialTransparente;
    private GameObject objetoPreview;

    private void Start ()
    {
        objetoPreview = Instantiate(muebleLista[0]);
        objetoPreview.GetComponent<MeshRenderer>().material = materialTransparente;
    }




    //Start is called before the first frame update
    


    // Update is called once per frame
    void Update()
    {
       
        //COLOR
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
            objetoSeleccionado = Instantiate(muebleLista[indiceObjetoActual]);
        }


        //ROTAR
        if (Input.GetKeyDown (KeyCode.LeftArrow) ^ Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (Input.GetKeyDown(KeyCode.G))
            {
                if (Input.GetKey(KeyCode.RightArrow))
                {
                    objetoSeleccionado.transform.Rotate(45f, 0f, 0f);
                }
                if (Input.GetKey(KeyCode.LeftArrow))
                {
                    objetoSeleccionado.transform.Rotate(-45f, 0f, 0f);
                }
            }

            else
            {
                if (Input.GetKey(KeyCode.RightArrow))
                {
                    objetoSeleccionado.transform.Rotate(0f, 45f, 0f);
                }
                if (Input.GetKey(KeyCode.LeftArrow))
                {
                    objetoSeleccionado.transform.Rotate(0f, -45f, 0f);
                }
            }
        }



        if (Input.GetKeyDown(KeyCode.S))
        {
            if (objetoSeleccionado.GetComponent<Rigidbody>() == null)
            { //IF anidado
                objetoSeleccionado.AddComponent<Rigidbody>();
            }
            objetoSeleccionado = null;
        }
        if (objetoSeleccionado != null)
        {
            objetoSeleccionado.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,
                Input.mousePosition.y, 10));
        }



        //CAMBIO DE MUEBLE
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            indiceObjetoActual++;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            indiceObjetoActual--;
        }

        if (indiceObjetoActual == muebleLista.Count)
        {
            indiceObjetoActual = 0;

        }

        else if (indiceObjetoActual == -1)
        {
            indiceObjetoActual = muebleLista.Count;
        }


    }

    
}
