using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerPointController : MonoBehaviour
{
    [SerializeField]
    GameObject prefabBall;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    float counter = 0;
    //float creepcount = 0;
    List<GameObject> balls = new List<GameObject>();
    // Update is called once per frame
    void Update()
    {
        counter += Time.deltaTime;
        if (counter >= 0.5 ) {
            GameObject ball = Instantiate(prefabBall,gameObject.transform.position,Quaternion.identity);
            balls.Add(ball);
            counter = 0;
            //creepcount++;
        }
        
    }
}
