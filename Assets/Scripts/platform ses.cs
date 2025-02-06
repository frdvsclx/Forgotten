using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformses : MonoBehaviour
{
    public AudioSource arkaplanses;
    public AudioSource musicSource;
   
    public AudioClip arkases;

    void Start()
    {
        musicSource.clip = arkases;
        musicSource.Play();
    }

}