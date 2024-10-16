using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceCounter : MonoBehaviour
{
    public float thrust = 20f;
    public float torque;
    public Rigidbody cubo;
    public Light luz;
    int numeroDeSaltos;
    Color piso;
    

    // Start is called before the first frame update
    void Start()
    {
        cubo = GetComponent<Rigidbody>();
        luz = GetComponent<Light>();
        numeroDeSaltos++;
        Debug.Log(numeroDeSaltos);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            cubo.AddForce(0, thrust*5, 0, ForceMode.Impulse);
            cubo.AddTorque(transform.up * torque * 1);
        }

        if (numeroDeSaltos == 10)
        {
            GetComponent<Rigidbody>().AddTorque(4f, 14f, 18f);
        }

        else if (numeroDeSaltos == 15)
        {
            piso = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
            GetComponent<MeshRenderer>().material.color = piso;
        }

        else if (numeroDeSaltos == 20)
        {
            //luz = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
            GetComponent<MeshRenderer>().material.color = piso;
        }
    }

   
}
