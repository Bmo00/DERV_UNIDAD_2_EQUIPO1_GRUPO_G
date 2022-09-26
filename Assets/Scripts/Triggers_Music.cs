using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Triggers_Music : MonoBehaviour
{
    [SerializeField]
    public AudioSource audio;

    private void OnTriggerEnter(Collider other)
    {
        audio.Play();
        
    }
    private void OnTriggerExit(Collider other)
    {
        audio.Stop();
    }
}
