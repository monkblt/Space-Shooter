using System.Collections;
using UnityEngine;

public class WinAudio : MonoBehaviour
{
    public AudioClip MusicClip;
    public AudioSource MusicSource;

    private int score;

    void Start()
    {
        MusicSource.clip = MusicClip;
    }

    void Update()
    {
        if (score>=100)
            MusicSource.Play();
    }
}
