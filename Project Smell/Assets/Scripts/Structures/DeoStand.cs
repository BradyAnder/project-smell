using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeoStand : MonoBehaviour, IInteractable
{
    private DeoCounter deoCounter;
    public List<GameObject> deos = new List<GameObject>();
    public GameObject spawnRef;

    public bool isLoveStand;
    public bool isNewSpiceStand;
    public bool isForeignStand;
    public bool isJaxStand;
    public bool isFahrenheitStand;
    public bool isRebreezeStand;
    public bool isJettStand;
    public bool isAniviaStand;

    // Start is called before the first frame update
    void Start()
    {
        deoCounter = GameObject.FindGameObjectWithTag("Player").GetComponent<DeoCounter>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void Interact()
    {
        PlaceDeoOnStand();
    }

    void PlaceDeoOnStand()
    {
        if (isLoveStand == true && deoCounter.love == true)
        {
            Instantiate(deos[0], spawnRef.transform.position, Quaternion.identity);
        }
        if (isNewSpiceStand == true && deoCounter.newSpice == true)
        {
            Instantiate(deos[1], spawnRef.transform.position, Quaternion.identity);
        }
        if (isForeignStand== true && deoCounter.foreign == true)
        {
            Instantiate(deos[2], spawnRef.transform.position, Quaternion.identity);
        }
        if (isJaxStand == true && deoCounter.jax == true)
        {
            Instantiate(deos[3], spawnRef.transform.position, Quaternion.identity);
        }
        if (isFahrenheitStand == true && deoCounter.fahrenheit == true)
        {
            Instantiate(deos[4], spawnRef.transform.position, Quaternion.identity);
        }
        if (isRebreezeStand == true && deoCounter.rebreeze == true)
        {
            Instantiate(deos[5], spawnRef.transform.position, Quaternion.identity);
        }
        if (isJettStand == true && deoCounter.jett == true)
        {
            Instantiate(deos[6], spawnRef.transform.position, Quaternion.identity);
        }
        if (isAniviaStand == true && deoCounter.anivia == true)
        {
            Instantiate(deos[7], spawnRef.transform.position, Quaternion.identity);
        }
    }
}
