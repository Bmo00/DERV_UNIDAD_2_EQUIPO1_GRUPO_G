using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Deteccion_Colisiones_v2 : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI txt_vida_enemigo;
    [SerializeField]
    public TextMeshProUGUI txt_ataque_enemigo;
    // Start is called before the first frame update
    void Start()
    {
        int v = SingletonUsuario.instancia.vida;
        int a = SingletonUsuario.instancia.ataque;

        txt_vida_enemigo.text = v.ToString();
        txt_ataque_enemigo.text = a.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        string name;
        string tag;

        name = collision.gameObject.name;
        tag = collision.gameObject.tag;
        Debug.Log("Nombre: " + name + " Tag: " + tag);
        if (!tag.Equals("Escenario"))
        {
            GameObject obj = GameObject.Find(name);

            Destroy(obj, 5);
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        string name;
        string tag;

        name = collision.gameObject.name;
        tag = collision.gameObject.tag;

        Debug.Log("Nombre: " + name + " Tag: " + tag);

        
    }

    private void OnCollisionExit(Collision collision)
    {
        string name;
        string tag;

        name = collision.gameObject.name;
        tag = collision.gameObject.tag;

        Debug.Log("Nombre: " + name + " Tag: " + tag);
    }
}
