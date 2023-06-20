using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class BallController : MonoBehaviour
{
    public float speed = 10f;
    [SerializeField] private GameObject explosion;
    public TextManager text_manager;
    //private bool hasCollided = false;
    // Start is called before the first frame update
    
    void Start()
    {
        text_manager = FindObjectOfType<TextManager>();
        /*
        float degree = Random.Range(0f, 360f);
        Vector2 direction = new Vector2(Mathf.Cos(Mathf.Deg2Rad * degree), Mathf.Sin(Mathf.Deg2Rad * degree));

        gameObject.GetComponent<Rigidbody2D>().AddForce(direction * speed, ForceMode2D.Impulse);*/
        
    }

    // Update is called once per frame
    void Update()
    {
        //Termimnate();
    }
    
    /*private void Termimnate()
    {
        counter += Time.deltaTime;
        if(counter >= 5)
            Destroy(gameObject);
    }*/

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {
            Instantiate(explosion, transform.position, Quaternion.identity);
            

            text_manager.IncreaseScore();
            Destroy(gameObject);
            //gameObject.SetActive(false);
            //hasCollided=true;
        }
    }

    
}
