using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Handler_UI : MonoBehaviour
{


    [SerializeField]
    TextMeshProUGUI txt_usuario;
    void Start()
    {
        string nom_usuario = PlayerPrefs.GetString("usuario", "");

        Scene scene = SceneManager.GetActiveScene();

        if (scene.buildIndex == 4) //final
        {
            txt_usuario.text = nom_usuario;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.C))
        {
            Scene scene;
            scene = SceneManager.GetActiveScene();
            if(scene.buildIndex == 5)
            {


                cargarEscena(4);
            }
            
        }
    }

    public void cargarEscena(int index)
    {
        Scene scene = SceneManager.GetActiveScene();
        if(scene.buildIndex == 3)
        {
            string nom_usuario = txt_usuario.text;
            PlayerPrefs.SetString("usuario", nom_usuario);
        }
        SceneManager.LoadScene(index);

    }
}
