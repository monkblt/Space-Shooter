using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotAudio : MonoBehaviour

{
    public AudioClip soundClip;
    public AudioSource soundSource;

    void Start()
    {
        soundSource.clip = soundClip;
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            soundSource.Play();
        }
    }
}
