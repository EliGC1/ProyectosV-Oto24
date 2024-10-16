using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject cuboTierra;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject)
        {
            Destroy(other.gameObject);
        }
        
    }
    // Update is called once per frame
    void Update()
    {
       
    }
}
