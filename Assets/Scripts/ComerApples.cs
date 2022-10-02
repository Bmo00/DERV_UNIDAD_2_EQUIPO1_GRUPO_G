using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using System;


public class ComerApples : MonoBehaviour
{
    Manager_Spawners spawn = new Manager_Spawners();
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

            Destroy(obj);
        }
    }
}
