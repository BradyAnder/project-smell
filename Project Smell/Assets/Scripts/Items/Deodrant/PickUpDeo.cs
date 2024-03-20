using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Unity.VisualScripting;
using UnityEngine;

public class PickUpDeo : MonoBehaviour, IInteractable
{
    private DeoCounter deoCounter;

    public bool isLove;
    public bool isNewSpice;
    public bool isForeign;
    public bool isJax;
    public bool isFahrenheit;
    public bool isRebreeze;
    public bool isJett;
    public bool isAnivia;

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

        if (isLove == true)
        {
            deoCounter.love = true;
        }
        else if (isNewSpice == true)
        {
            deoCounter.newSpice = true;
        }
        else if (isForeign == true) 
        {
            deoCounter.foreign = true;
        }
        else if (isJax == true) 
        {
            deoCounter.jax = true;
        }
        else if (isFahrenheit == true)
        {
            deoCounter.fahrenheit = true;
        }
        else if (isRebreeze == true)
        {
            deoCounter.rebreeze = true;
        }
        else if (isJett == true)
        {
            deoCounter.jett = true;
        }
        else if (isAnivia == true)
        {
            deoCounter.anivia = true;
        }

        print(deoCounter.DeoCollected);
        Destroy(gameObject);
    }
}
