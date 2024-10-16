using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class RE1 : MonoBehaviour
{
    public GameObject cuboRE;
    public GameObject[] listaCamaras;

    // Start is called before the first frame update
    void Start()
    {
        listaCamaras[0].gameObject.SetActive(true);
        listaCamaras[1].gameObject.SetActive(false);
    }

    // Update is called once per frame

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "C1")
        {
            ; 
        }
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            transform.Translate(0, 0, 0.8f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, 0, -0.8f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 10f, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, -10f, 0);
        }
    }
}


