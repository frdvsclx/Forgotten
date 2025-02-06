
using System;
using UnityEngine;

[Serializable]
public class audiomanager : MonoBehaviour
{
    [HideInInspector]
    public static audiomanager instance;

    public AudioSource musicSource;

    public AudioClip kapicalma;
    public AudioClip kapiacma;
    public AudioClip somine;
    public AudioClip giris;
    public AudioClip final;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }

    public void _kapicalma()
    {
        musicSource.clip = kapicalma;
        musicSource.Play();
    }
 
    public void _kapitiklama()
    {
        musicSource.clip = kapiacma;
        musicSource.Play();
    }

    public void _somine()
    {
        musicSource.clip = somine;
        musicSource.Play();
    }
    public void _giris()
    {
        musicSource.clip = giris;
        musicSource.Play();
    }

    public void _final()
    {
        musicSource.clip = final;
        musicSource.Play();
    }


}

