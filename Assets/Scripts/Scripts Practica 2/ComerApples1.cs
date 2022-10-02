using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using System;


public class ComerApples1 : MonoBehaviour
{
    Manager_Spawners1 spawn = new Manager_Spawners1();

    [SerializeField]
    TextMeshProUGUI t_tiempo;

    int tiempoInicio;

    [SerializeField]
    public TextMeshProUGUI txt_Vida;

    int v, x;
    // Start is called before the first frame update

    private void Awake()
    {
        GameObject obj = GameObject.Find("txt_Tiempo");
        t_tiempo = obj.GetComponent<TextMeshProUGUI>();
    }
    void Start()
    {
        tiempoInicio = 10;
        StopAllCoroutines();
        StartCoroutine("controlTiempo");
        InvokeRepeating("disminuir", 1f, 1f);
        v = SingletonUsuario.instancia.vida;

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

            Destroy(obj);

            masvida(v);

            v = v+5;
            txt_Vida.text = v.ToString();
        }
    }

    void masvida(int vida)
    {
        vida += 5;
        tiempoInicio = tiempoInicio + 5;
    }

    IEnumerator controlTiempo()
    {
        while (tiempoInicio >= 0)
        {
            t_tiempo.text = tiempoInicio.ToString();
            tiempoInicio--;
            yield return new WaitForSeconds(1f);


        }
    }

    void disminuir()
    {
        if (v > 0)
        {
            v--;
            txt_Vida.text= v.ToString();
        }
    }
}
