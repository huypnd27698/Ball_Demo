using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RandomBallController : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 20f;
    public Vector2 randomTargetPoint;


    void Start()
    {
        // Set the initial target to a random position within the camera's view
        GenerateRandomTargetPoint();
    }

    void Update()
    {
        // Move towards the random target
        transform.position = Vector2.MoveTowards(transform.position, randomTargetPoint, moveSpeed * Time.deltaTime);

        // If we are close enough to the target, set a new random target
        if (Vector2.Distance(transform.position, randomTargetPoint) < 0.1f)
        {
            GenerateRandomTargetPoint();
        }
    }

    
    private void GenerateRandomTargetPoint()
    {
        
        float screenWidth = Screen.width ;
        float screenHeight = Screen.height ;

        Vector2 screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(screenWidth, screenHeight, 0f));

        float randomX = Random.Range(-screenBounds.x, screenBounds.x);
        float randomY = Random.Range(-screenBounds.y, screenBounds.y);

        randomTargetPoint = new Vector2(randomX, randomY);
    }
}
