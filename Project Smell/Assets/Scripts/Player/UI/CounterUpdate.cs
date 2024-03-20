using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CounterUpdate : MonoBehaviour
{
    public TextMeshProUGUI meshPro;
    private DeoCounter deoCounter;

    // Start is called before the first frame update
    void Start()
    {
        deoCounter = GameObject.FindGameObjectWithTag("Player").GetComponent<DeoCounter>();
    }

    // Update is called once per frame
    void Update()
    {
        meshPro.text = deoCounter.DeoCollected.ToString();
    }
}
