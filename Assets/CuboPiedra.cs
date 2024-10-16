using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboPiedra : MonoBehaviour
{
    public GameObject cuboPiedra;
    public GameObject cuboObsidiana;
    GameObject nuevoCubo;
    int cubosPiedra = 5;
    int cubosObsidiana = 5;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            transform.Translate(0, 0, 0.05f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, 0, -0.05f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0.05f, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-0.05f, 0, 0);
        }


        if (Input.GetKeyDown(KeyCode.P))
        {
            if (cubosPiedra > 5)
            {
                Vector3 posicionCuboPiedra = transform.position + new Vector3(0, 0, 1.5f);

                nuevoCubo = Instantiate(cuboPiedra,
                                                   posicionCuboPiedra,
                                                   cuboPiedra.transform.rotation);

                cubosPiedra = cubosPiedra - 1;
            }


        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            if (cubosObsidiana > 5)
            {
                Vector3 posicionCuboObsidiana = transform.position + new Vector3(0, 0, 1.5f);

                nuevoCubo = Instantiate(cuboObsidiana,
                                                   posicionCuboObsidiana,
                                                   cuboObsidiana.transform.rotation);
                cubosObsidiana = cubosObsidiana - 1;
            }

        }
    }
}
