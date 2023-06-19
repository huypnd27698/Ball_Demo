using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSquareController : MonoBehaviour
{
    // Start is called before the first frame update
    public float rotationSpeed = 10f;
    void Start()
    {

    }

    // Update is called once per frame



    private void Update()
    {
        // Rotate left when left arrow key is pressed
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            RotateObject(-1);
        }

        // Rotate right when right arrow key is pressed
        if (Input.GetKey(KeyCode.RightArrow))
        {
            RotateObject(1);
        }
    }

    private void RotateObject(int direction)
    {
        // Calculate the rotation amount based on the direction and rotation speed
        float rotationAmount = direction * rotationSpeed * Time.deltaTime;

        // Rotate the object around its Z-axis
        transform.Rotate(Vector3.forward, rotationAmount);
    }
}
