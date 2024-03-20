using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{

    public int itemSpawnChance;

    public List<GameObject> items = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        int ranNumber = Random.Range(0, 100);
        if(ranNumber <= itemSpawnChance)
        {
            int ranItem = Random.Range(0, items.Count);
            Instantiate(items[ranItem], transform.position, Quaternion.identity);

        }
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
