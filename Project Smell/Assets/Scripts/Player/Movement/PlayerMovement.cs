using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    private Inventory inventory;

    public float speed = 12f;
    public float gravity = -9.81f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGround;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        isGround = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isGround && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            inventory.SetSelectedIndex(0);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            inventory.SetSelectedIndex(1); 
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            inventory.SetSelectedIndex(2);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            inventory.SetSelectedIndex(3);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            inventory.SetSelectedIndex(4);
        }
    }
}
