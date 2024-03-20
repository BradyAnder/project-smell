using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;


public class LandmarkGen : MonoBehaviour
{
   
    //List of all structures that can be generated 
    public List<GameObject> structure = new List<GameObject>();
    public List<GameObject> deodorant = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        //print(structure.Count);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Generates a random landmark from a list and generates that landmark at a Target position and Target rotation 
    public void Generate(Vector3 targetPosition, Vector3 targetRotation)
    {
        int randomLandmark = Random.Range(0, structure.Count);
        Instantiate(structure[randomLandmark], targetPosition, Quaternion.Euler(targetRotation));
        structure.RemoveAt(randomLandmark);
    }

    public void DeoGenerate(Vector3 targetPosition)
    {
        int randomDeo = Random.Range(0, deodorant.Count);
        Instantiate(deodorant[randomDeo], targetPosition, Quaternion.identity);
        deodorant.RemoveAt(randomDeo);
    }
}
