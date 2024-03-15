using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LandmarkGen : MonoBehaviour
{

    public List<GameObject> structure = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        //print(structure.Count);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Generate(Vector3 targetPosition, Vector3 targetRotation)
    {
        int randomLandmark = Random.Range(0, structure.Count);
        Instantiate(structure[randomLandmark], targetPosition, Quaternion.Euler(targetRotation));
        structure.RemoveAt(randomLandmark);
    }
}
