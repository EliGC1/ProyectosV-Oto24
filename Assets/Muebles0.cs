using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Muebles0 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void cambia1()
    {
        SceneManager.LoadScene(1);

    }

    public void cambia0()
    {
        SceneManager.LoadScene(0);
    }


    public void stop()
    {
        CancelInvoke();
    }

}
