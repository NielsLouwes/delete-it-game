using System.Collections;
using System.Collections.Generic;
using UnityEditor.MPE;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerSpeed = 8f;
    private Rigidbody2D rigidBody;
    private Vector2 movement;
    private bool isSneaking = false;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Get input from the player
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown(KeyCode.LeftControl)) {
           isSneaking = !isSneaking;
           playerSpeed = isSneaking ? 4f : 8f;
        } 
    }

    void FixedUpdate()
    {
        // Move the player
        rigidBody.MovePosition(rigidBody.position + movement * playerSpeed * Time.fixedDeltaTime);
    }
}
