using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeoSpawner : MonoBehaviour
{
    private LandmarkGen landmarkGenScript;

    private void Awake()
    {
        GameObject landmarkGeneratorObject = GameObject.Find("LandmarkGenerator");
        landmarkGenScript = landmarkGeneratorObject.GetComponent<LandmarkGen>();
    }
    // Start is called before the first frame update
    void Start()
    {
        landmarkGenScript.DeoGenerate(transform.position);
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
