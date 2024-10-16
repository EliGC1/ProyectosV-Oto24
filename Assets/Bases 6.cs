using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bases6 : MonoBehaviour
{
    public GameObject cubitoTierra;
    GameObject nuevoCubo;
    // Start is called before the first frame update
    void Start()
    {

    }

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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 posicionCuboTierra = transform.position + new Vector3(0, 0, 1.5f);

            nuevoCubo = Instantiate(cubitoTierra,
                                               posicionCuboTierra,
                                               cubitoTierra.transform.rotation);
        }

        if (nuevoCubo != null)
        {
            nuevoCubo.transform.Rotate(0, 0.025f, 0);
        }

    }
}
