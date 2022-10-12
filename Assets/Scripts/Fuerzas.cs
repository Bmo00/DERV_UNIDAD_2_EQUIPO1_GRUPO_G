using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuerzas : MonoBehaviour
{
    [SerializeField]
    Rigidbody rb;

    [SerializeField]
    float velocidad;

    [SerializeField]
    Transform posicionInicial;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        

    }

    // Update is called once per frame
    void Update()
    {

        if(transform.position.y <= -10)
        {
            transform.position = posicionInicial.position;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(transform.forward * velocidad, ForceMode.Acceleration);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.AddForce(transform.right * -1 * velocidad, ForceMode.Acceleration);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            rb.AddForce(transform.forward * -1 * velocidad, ForceMode.Acceleration);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.AddForce(transform.right * velocidad, ForceMode.Acceleration);
        }
    }
}
