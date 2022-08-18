using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactersAudio : MonoBehaviour
{
    AudioSource _AudioSourse;
    
    public AudioClip reloadSound;
    public AudioClip shootSound;
    
    void Start()
    {
        _AudioSourse = GetComponent<AudioSource>();
    }

    public void ReloadSound()
    {
        _AudioSourse.clip = reloadSound;
        _AudioSourse.Play();
    }

    public void ShootSound()
    {
        _AudioSourse.clip = shootSound;
        _AudioSourse.Play();
    }
}
