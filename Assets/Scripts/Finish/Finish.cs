using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public float timeBetweenChars = 0.02f;
    public TMP_Text Machine , Laugh, Scientist, Better, Who;
    public GameObject FirstScene,SecondScene,credit, tutorial;
    public 
    void Start()
    {
        StartCoroutine(FinishControl());
        FirstScene.SetActive(true);
    }
    public IEnumerator TypeSentence(TMP_Text text, string sentence)
    {
        var charCount = 0;
        text.text = "";
        while (charCount < sentence.Length)
        {
            text.text += sentence[charCount];
            charCount++;
            yield return new WaitForSeconds(timeBetweenChars);
        }
    }

    IEnumerator FinishControl()
    {
        Machine.gameObject.SetActive(true);
        yield return TypeSentence(Machine, Machine.text);
        yield return new WaitForSeconds(3);
        Machine.gameObject.SetActive(false);
        FirstScene.SetActive(false);
        SecondScene.SetActive(true);
        audiomanager.instance._somine();
        audiomanager.instance._final();
        Laugh.gameObject.SetActive(true);
        yield return TypeSentence(Laugh, Laugh.text);
        yield return new WaitForSeconds (3);
        Laugh.gameObject.SetActive (false);
        Scientist.gameObject.SetActive(true);
        yield return TypeSentence(Scientist, Scientist.text);
        yield return new WaitForSeconds (3);
        Scientist.gameObject.SetActive (false);
        Better.gameObject.SetActive(true);
        yield return TypeSentence(Better, Better.text);
        yield return new WaitForSeconds (3);
        Better.gameObject.SetActive (false);
        Who.gameObject.SetActive(true);
        yield return TypeSentence(Who, Who.text);
        yield return new WaitForSeconds (3);
        Who.gameObject.SetActive (false);
        SecondScene.SetActive (false);
        credit.SetActive(true);
        tutorial.SetActive(true);
        yield return new WaitForSeconds(15);
        Application.Quit();
    }
}
