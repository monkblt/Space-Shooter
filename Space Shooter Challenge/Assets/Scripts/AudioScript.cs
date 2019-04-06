using System.Collections;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    public AudioClip MusicClip;

    public AudioSource WeaponPlayer;

    void Start()
    {
        WeaponPlayer.clip = MusicClip;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            WeaponPlayer.Play();
    }
}
