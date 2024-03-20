using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeoCounter: MonoBehaviour
{
    public int DeoCollected;
    public List<GameObject> deodorant = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        DeoCollected = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
