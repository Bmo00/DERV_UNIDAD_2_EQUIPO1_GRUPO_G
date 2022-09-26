using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MovBasico : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    public TextMeshProUGUI txt_vida;
    [SerializeField]
    public TextMeshProUGUI txt_ataque;
    void Start()
    {
        int v = SingletonUsuario.instancia.vida;
        int a = SingletonUsuario.instancia.ataque;

        txt_vida.text = v.ToString();
        txt_ataque.text = a.ToString(); 
    }
    float valX;
    float valZ;
    public float velocidad = 20;
    // Update is called once per frame
    void Update()
    {
        valX = Input.GetAxis("Horizontal");
        valZ = Input.GetAxis("Vertical");

        valX = valX * velocidad * Time.deltaTime;
        valZ = valZ * velocidad * Time.deltaTime;

        Vector3 v = new Vector3(valX, 0, valZ);

        transform.Translate(v);
    }
}
