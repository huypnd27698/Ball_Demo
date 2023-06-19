using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBallController : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 5f; // speed of movement
    private Rigidbody2D rb; // reference to the rigidbody component

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // get the rigidbody component on start
    }

    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical"); // get the vertical input from the controller

        Vector2 movement = new Vector2(0f, verticalInput); // create a movement vector based on the vertical input

        rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime); // move the object using the movement vector and speed
    }
}
