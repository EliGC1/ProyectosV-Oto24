using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bases7 : MonoBehaviour
{
    public GameObject cuboTierra;
    GameObject mePego;//Variable que sabr� qui�n fue el �ltimo objeto que me peg�. 

    void Start()
    {
        //Ciclo For 
        //for(variableDeIteracion;condicionDeRepeticion;incremento) {}
        //Nuestra variable de iteraci�n se llama i (por �ndice) y comienza en 0 
        //Nuestra condici�n de repetici�n es que i sea menor a 10
        //Cada vuelta, va a ir incrementando i en 1
        for (int i = 0; i < 10; i = i + 1)
        {
            Instantiate(cuboTierra,
                        new Vector3(i, 0, 0),
                        cuboTierra.transform.rotation);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        print("Me dieron un llegue de tipo collision");
        if (collision.rigidbody != null)
        {
            collision.rigidbody.AddForce(0, 10f, 0, ForceMode.Impulse);
        }
        mePego = collision.gameObject;
    }

    //El Collider llamado other, es la caja de colisi�n (la caja verde) del otro objeto con el que choqu�
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
        print("Me dieron un llegue de tipo Trigger");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            transform.Translate(0, 0, 0.025f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, 0, -0.025f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0.025f, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-0.025f, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (mePego != null)
            {
                Destroy(mePego);
            }
        }

    }
}
