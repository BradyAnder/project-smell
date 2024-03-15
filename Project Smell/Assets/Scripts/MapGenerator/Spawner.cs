using Palmmedia.ReportGenerator.Core;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private LandmarkGen landmarkGenScript;
    public bool isNorth = false;
    public bool isEast = false;
    public bool isSouth = false;
    public bool isWest = false;

    private void Awake()
    {
        GameObject landmarkGeneratorObject = GameObject.Find("LandmarkGenerator");
        landmarkGenScript = landmarkGeneratorObject.GetComponent<LandmarkGen>();

    }

    // Start is called before the first frame update
    void Start()
    {
        if(isNorth == true)
        {
            landmarkGenScript.Generate(transform.position, new Vector3(0,180,0));
        }
        if (isSouth == true)
        {
            landmarkGenScript.Generate(transform.position, new Vector3(0, 0, 0));
        }
        if (isEast == true)
        {
            landmarkGenScript.Generate(transform.position, new Vector3(0, -90, 0));
        }
        if (isWest == true)
        {
            landmarkGenScript.Generate(transform.position, new Vector3(0, 90, 0));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
