using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedItem: MonoBehaviour, IItems
{
    public PlayerMovement player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Use()
    {
        player.speed += 10;
    }
}
