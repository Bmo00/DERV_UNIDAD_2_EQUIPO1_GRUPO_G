using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Manager_Spawners : MonoBehaviour
{
    [SerializeField]
    int rnd_ubi_manzana;

    [SerializeField]
    Transform[] spawners;


    [SerializeField]
    GameObject obj_manzana;

    int tot_spawners = 1;
    GameObject objTemp;
    public void Awake()
    {
        
        
        spawners = new Transform[tot_spawners];
        GameObject objTemp;
        for (int i = 0; i < tot_spawners; i++)
        {
            objTemp = GameObject.Find("Spawner_"+(i+1).ToString());
            spawners[i] = objTemp.transform;
        }
    }
    


    public void createManzana()
    {
        rnd_ubi_manzana = Random.Range(0, tot_spawners);

        Transform aux = spawners[rnd_ubi_manzana];

        objTemp = Instantiate(obj_manzana, aux.position, aux.rotation);
        objTemp.name = "manzana";
    }
    
    void Start()
    {
        createManzana();
    }
    // Update is called once per frame
    void Update()
    {
        if (objTemp.IsDestroyed())
        {
            createManzana();
        }
    }
}
