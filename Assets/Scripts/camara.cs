using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.WSA;

public class camara : MonoBehaviour
{
    // Start is called before the first frame update
    public float turnSpeed = 4.0f;
    public GameObject player;

    private Transform playerTransform;
    private Vector3 offset;

    void Start()
    {
        playerTransform = player.transform;
        offset = new Vector3(0, 1, -5);
    }

    void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * turnSpeed, Vector3.up) * offset;
            transform.position = playerTransform.position + offset;
            transform.LookAt(playerTransform.position);
        }
    }
}
