using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Guncontroller : MonoBehaviour
{
    [SerializeField]
    GameObject circlePrefap;
    GameObject gun;
    // Start is called before the first frame update
    void Start()
    {
        gun = GameObject.FindGameObjectWithTag("gun");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //GameObject bullet = Instantiate<GameObject>(circlePrefap, gun.transform.position, gun.transform.rotation);
            GameObject bullet = ObjectPool.instance.GetPooledObject();
            if (bullet != null)
            {
                bullet.transform.position = gun.transform.position;
                bullet.SetActive(true);
            }
            bullet.tag = "bullet";
            Rigidbody2D bullet_body = bullet.GetComponent<Rigidbody2D>();
            
            Bullet bullet_script = bullet.GetComponent<Bullet>();
            bullet_body.AddForce(getVector2DByDegree(-transform.eulerAngles.z) * bullet_script.Impulse, ForceMode2D.Impulse);
            GameObject audio = GameObject.FindGameObjectWithTag("audio");
            AudioManager audio_manager = audio.GetComponent<AudioManager>();
            audio_manager.Play();
        }
    }
    public static Vector2 getVector2DByDegree(float degree)
    {
        float radian = degree * Mathf.Deg2Rad;
        float sinD = Mathf.Sin(radian);
        float cosD = Mathf.Cos(radian);
        //print(sinD + "   " + cosD);
        float x = sinD;
        float y = cosD;
        return new Vector2(x, y);
    }
}
