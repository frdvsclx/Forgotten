using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yazı : MonoBehaviour
{

    public GameObject panel1, panel2;


    private void Start()
    {
        StartCoroutine(lsls());
    }


    IEnumerator lsls()
    {
        yield return new WaitForSeconds(5);
        panel1.SetActive(false);
        panel2.SetActive(false);
    }


}
