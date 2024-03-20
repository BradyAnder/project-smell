using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PickUpDeo : MonoBehaviour, IInteractable
{
    private DeoCounter deoCounter;

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
        deoCounter.DeoCollected++;
        print(deoCounter.DeoCollected);
        Destroy(gameObject);
    }
}
