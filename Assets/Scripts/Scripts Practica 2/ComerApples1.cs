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


    int VidaIni;

    [SerializeField]
    public TextMeshProUGUI txt_Vida;

    int v, x;
    // Start is called before the first frame update

    private void Awake()
    {
        GameObject obj = GameObject.Find("txt_Vida");
        txt_Vida = obj.GetComponent<TextMeshProUGUI>();
    }
    void Start()
    {
        VidaIni = 10;
        StopAllCoroutines();
        StartCoroutine("controlTiempo");
        txt_Vida.text = VidaIni.ToString();
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
            VidaIni = VidaIni + 5;
            txt_Vida.text = VidaIni.ToString();
        }
    }


    IEnumerator controlTiempo()
    {
        while (VidaIni >= 0)
        {
            txt_Vida.text = VidaIni.ToString();
            VidaIni--;
            yield return new WaitForSeconds(1f);
        }
    }


}
