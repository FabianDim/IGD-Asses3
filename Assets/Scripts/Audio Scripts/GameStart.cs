using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    public AudioClip introMusic;
    // Start is called before the first frame update
    void Start()
    {
        AudioSource audioSource = GetComponent<AudioSource>();

        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
