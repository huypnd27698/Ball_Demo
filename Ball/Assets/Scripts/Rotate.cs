using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Transform pivotPoint; // the point to rotate around
    public float rotationSpeed = 100.0f; // speed of rotation

    void Start()
    {
        
    }

    void Update()
    {
        // get difference between pivot point and the center of the square
        Vector3 diff = transform.position - pivotPoint.position;

        // calculate angle between the horizontal axis and the line connecting the pivot point and the center of the square
        float angle = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;

        // get user input for rotation direction
        float direction = Input.GetAxisRaw("Horizontal");

        // calculate new angle based on rotation speed and direction
        angle += direction * rotationSpeed * Time.deltaTime;

        // convert angle back to radians
        float radAngle = angle * Mathf.Deg2Rad;

        // calculate new position of the square based on the updated angle and distance from pivot point
        Vector3 newPos = pivotPoint.position + new Vector3(Mathf.Cos(radAngle), Mathf.Sin(radAngle), 0.0f) * diff.magnitude;

        // rotate the square around the pivot point
        transform.RotateAround(pivotPoint.position, Vector3.forward, direction * rotationSpeed * Time.deltaTime);

        // update the position of the square
        transform.position = newPos;
    }
}
