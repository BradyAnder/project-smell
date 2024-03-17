using Palmmedia.ReportGenerator.Core;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private LandmarkGen landmarkGenScript;

    [Header("Direction")]
    [Space(2)]
    public bool isNorth = false;
    public bool isEast = false;
    public bool isSouth = false;
    public bool isWest = false;
    [Space(2)]

    [Header("Destroy on Spawn")]
    [Space(2)]
    [Tooltip("Will destroy spawner on game start")]
    public bool destroy = false;

    private void Awake()
    {
        //Finds the generate Landmark object within a scene and references the generator script off of it 
        GameObject landmarkGeneratorObject = GameObject.Find("LandmarkGenerator");
        landmarkGenScript = landmarkGeneratorObject.GetComponent<LandmarkGen>();

    }

    // Start is called before the first frame update
    void Start()
    {
        //Determines the direction the generated Landmark should face 
        if (isNorth == true)
        {
            landmarkGenScript.Generate(transform.position, new Vector3(0,180,0));

            if(destroy == true)
            {
                Destroy(gameObject);
            }
        }
        if (isSouth == true)
        {
            landmarkGenScript.Generate(transform.position, new Vector3(0, 0, 0));

            if (destroy == true)
            {
                Destroy(gameObject);
            }
        }
        if (isEast == true)
        {
            landmarkGenScript.Generate(transform.position, new Vector3(0, -90, 0));

            if (destroy == true)
            {
                Destroy(gameObject);
            }
        }
        if (isWest == true)
        {
            landmarkGenScript.Generate(transform.position, new Vector3(0, 90, 0));

            if (destroy == true)
            {
                Destroy(gameObject);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
