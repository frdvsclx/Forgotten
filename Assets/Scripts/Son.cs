using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Son : MonoBehaviour
{

    SpriteRenderer sr;
    public GameObject beyaz;
    public AudioSource musicSource;
    public GameObject platformses;


    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            sr.color = Color.white;
            beyaz.SetActive(true);
            musicSource.Play();

            platformses.SetActive(false);
            

        }
    }
}
