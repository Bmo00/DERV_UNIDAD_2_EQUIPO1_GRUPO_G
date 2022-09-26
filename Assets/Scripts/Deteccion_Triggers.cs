using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Deteccion_Triggers : MonoBehaviour
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

    private void OnTriggerEnter(Collider other)
    {
        string name;
        string tag;

        name = other.gameObject.name;
        tag = other.gameObject.tag;

        Debug.Log("trigger enter - sNombre: " + name + " Tag: " + tag);
    }
    private void OnTriggerStay(Collider other)
    {
        string name;
        string tag;

        name = other.gameObject.name;
        tag = other.gameObject.tag;

        Debug.Log("trigger stay - Nombre: " + name + " Tag: " + tag);
    }
    private void OnTriggerExit(Collider other)
    {
        string name;
        string tag;

        name = other.gameObject.name;
        tag = other.gameObject.tag;

        Debug.Log("trigger exit - Nombre: " + name + " Tag: " + tag);
    }
}
