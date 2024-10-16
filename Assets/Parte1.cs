using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parte1 : MonoBehaviour
{

    public int numeroX;

    // Start is called before the first frame update
    void Start()
    {
        numeroX = 10;
        float numeroY;
        bool numeroZ = true;
        string nombre = "Elizabeth";
        MetodoA();
        int resultado = MetodoB(1, 1);
    }
    
  
    // Update is called once per frame
    void MetodoA()
    {

    }

    public int MetodoB(int param1, int param2)
    {
        return param1 + param2;
    }

    

}


