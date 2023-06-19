using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameIntializer : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        ScreenUtils.Initialize();
        GameObject gun = GameObject.FindGameObjectWithTag("gun");
        GameObject circle = GameObject.FindGameObjectWithTag("circle");
        gun.transform.parent = circle.transform;
    }

    // Update is called once per frame
}
