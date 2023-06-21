using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Timer bullet_timer;
    public float Impulse = 10f;
    TextManager text_manager;
    void Start()
    {
        bullet_timer = gameObject.AddComponent<Timer>();
        bullet_timer.Duration = 6;
        bullet_timer.Run();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //stroy(gameObject);
        gameObject.SetActive(false);

    }
    private void OnBecameInvisible()
    {
        //gameObject);
        gameObject.SetActive(false);
    }
}
