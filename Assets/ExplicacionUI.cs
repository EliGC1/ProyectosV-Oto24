using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExplicacionUI : MonoBehaviour
{
    public Text miTexto;
    public Image miImagen;
    public Sprite miSprite;

    // Start is called before the first frame update
    void Start()
    {
        miTexto.text = "Hola, mundo";
        miImagen.sprite = miSprite;
    }

    public void BotonPresionado()
    {
        miTexto.text = "Adios mundo cruel";
        miImagen.color = Color.cyan;
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



    



}
