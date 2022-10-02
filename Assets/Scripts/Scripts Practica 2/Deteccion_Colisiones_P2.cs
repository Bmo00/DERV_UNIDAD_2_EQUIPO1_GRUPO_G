using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Deteccion_Colisiones_P2 : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI txt_Vida;
    int v = 0;
    // Start is called before the first frame update
    void Start()
    {
        

        txt_Vida.text = v.ToString();
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

            Destroy(obj, 0);
            v = v + 10;
            txt_Vida.text = v.ToString();
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
