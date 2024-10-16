using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parte3 : MonoBehaviour
{
    private Rigidbody miRigibody;
    Vector3 miVector;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {

            miRigibody.AddForce(miVector,ForceMode.Impulse);

        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            miRigibody.AddForce(miVector, ForceMode.Impulse);
        }
    }

    //PREGUNTA EXTRAS
    //1. ¿Qué hay dentrro de nuestras escenas? Dentro de las escenas hay Game Objects
    //2. ¿Qué es Unity? Unity es un motor de videojuegos
    

}
