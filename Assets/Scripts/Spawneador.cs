using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawneador : MonoBehaviour
{
    [SerializeField]
    GameObject prefab_A_Clonar;

    [SerializeField]
    long conPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            GameObject nuevo = Instantiate(prefab_A_Clonar,
            gameObject.transform.position,
                gameObject.transform.rotation);
            nuevo.name = "prefab_No_" + conPrefabs.ToString();
        }
    }
}
