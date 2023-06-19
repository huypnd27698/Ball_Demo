using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private AudioSource audioSource;
    private AudioClip clip;
    void Awake()
    {
        audioSource = gameObject.AddComponent<AudioSource>();// audio Source
        clip = Resources.Load<AudioClip>("Sound/bum");

    }
    public void Play()
    {
        audioSource.PlayOneShot(clip);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
