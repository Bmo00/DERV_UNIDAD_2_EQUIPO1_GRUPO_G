using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Force_Velocity : MonoBehaviour
{
    [SerializeField]
    public Rigidbody rb;

    [SerializeField]
    float velocidad;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.right * velocidad, ForceMode.VelocityChange);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
