using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ClaseBases4 : MonoBehaviour
{
    public GameObject otroObjeto;
    public GameObject tercerObjeto;

    // Start is called before the first frame update
    void Start()
    {
        otroObjeto.GetComponent<Light>().intensity = 9f;
        tercerObjeto.GetComponent <Camera>().fieldOfView = 83f;

        tercerObjeto.GetComponent<Camera>().backgroundColor = new Color(17, 8, 14);
        otroObjeto.GetComponent<Light>().type = LightType.Spot;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
