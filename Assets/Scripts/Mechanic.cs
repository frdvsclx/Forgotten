using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mechanic : MonoBehaviour
{
    Rigidbody2D rgb;
    public float JumpAmaount, yatay;
    public GameObject Panel1;
    Transform player;
    public GameObject beyaz, kýrmýzý, mavi, green,black;
    public bool k;
    public Collider2D col;
    public GameObject Main, Main2,panel2;
    public Vector2 CheckPointPos;
    void Start()
    {
        rgb = GetComponent<Rigidbody2D>();
        player = GetComponent<Transform>();
        beyaz.SetActive(true);
        Time.timeScale = 1.0f;
        
    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal") * yatay;
        rgb.velocity = new Vector2(horizontal * yatay, rgb.velocity.y);



    }
    void Update()
    {

        if (Input.GetButton("Jump") && Mathf.Approximately(rgb.velocity.y, 0))
        {
            rgb.AddForce(Vector3.up * JumpAmaount, ForceMode2D.Impulse);

        }
        if (player.position.y < -9)
        {
            Time.timeScale = 0f;
            Panel1.SetActive(true);
           
        }
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            panel2.SetActive(true);
            Time.timeScale = 0f;

        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("K"))
        {
            Destroy(collision.gameObject);
            kýrmýzý.SetActive(true);
            k = true;
            col.isTrigger = true;

        }
        if (collision.gameObject.CompareTag("M"))
        {
            Destroy(collision.gameObject);
            mavi.SetActive(true);

        }
        if (collision.gameObject.CompareTag("G"))
        {
            Destroy(collision.gameObject);
            green.SetActive(true);
            mavi.SetActive(false);
            kýrmýzý.SetActive(false);
        }

        if (collision.gameObject.CompareTag("Laser1") || collision.gameObject.CompareTag("Laser2"))
        {
            player.transform.position = CheckPointPos;
        }
        if(collision.gameObject.CompareTag("S"))
        {
            beyaz.SetActive(false);
            green.SetActive(false);
            mavi.SetActive(false) ;
            kýrmýzý.SetActive(false );
            black.SetActive(true);
            StartCoroutine(next());
        }
        if(collision.gameObject.CompareTag("CameraControl"))
        {

            Main.SetActive(false);
            Main2.SetActive(true);
            Destroy(collision.collider);
            yatay = 2f;
            JumpAmaount = 4;
        }
    }


    IEnumerator next()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(3);
    }

    public void  pause()
    {
        panel2.SetActive(false);
        Time.timeScale = 1;
    }


     public void tekrar()
    {
        SceneManager.LoadScene(2);
    }

}

