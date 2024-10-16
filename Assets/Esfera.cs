using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esfera : MonoBehaviour
{
    Vector3 esfera;
    Color esferaColor;
    SphereCollider miCollider;
    Rigidbody esferaGravedad;



    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(2f, 1f, 3f);

        esfera = new Vector3(20f, 16f, 46f);
        transform.eulerAngles = esfera;

        miCollider = GetComponent<SphereCollider>();
        
        esferaColor = new Color(5f, 3f, 1f, 1f);
        GetComponent<MeshRenderer>().material.color = esferaColor;

        esferaGravedad = GetComponent<Rigidbody>();
        esferaGravedad.useGravity = true;

    }

    void OnTriggerEnter(Collider other)
    {
        miCollider.radius += 17f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            esferaGravedad.useGravity = !esferaGravedad.useGravity;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            miCollider.radius += 0.1f;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            miCollider.radius -= 0.1f;
        }

    }
}
