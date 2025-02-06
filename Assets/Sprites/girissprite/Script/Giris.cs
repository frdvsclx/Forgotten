using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Giris : MonoBehaviour
{
    public float timeBetweenChars = 0.02f;

    public GameObject FirstScene, SecondScene;

    public TMP_Text Door, Who, Scientist, How, Machine, Machine2;
    void Start()
    {
        StartCoroutine(Sýralama());
        Time.timeScale = 1.0f;

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



    IEnumerator Sýralama()
    {
        FirstScene.gameObject.SetActive(true);
        yield return new WaitForSeconds(1);

        Door.gameObject.SetActive(true);
        yield return TypeSentence(Door, Door.text);
        yield return new WaitForSeconds(2);
        Door.gameObject.SetActive(false);

        audiomanager.instance._kapicalma();
        yield return new WaitForSeconds(3);

        audiomanager.instance._kapitiklama();
        yield return new WaitForSeconds(3);

        FirstScene.gameObject.SetActive(false);
        SecondScene.gameObject.SetActive(true);
        audiomanager.instance._somine();
        audiomanager.instance._giris();

        yield return new WaitForSeconds(2);

        Who.gameObject.SetActive(true);
        yield return TypeSentence(Who, Who.text);
        //birinci cümle
        yield return new WaitForSeconds(3);
        Who.gameObject.SetActive(false);
        Scientist.gameObject.SetActive(true);
        yield return TypeSentence(Scientist, Scientist.text);
        //2. cümle
        yield return new WaitForSeconds(3);
        Scientist.gameObject.SetActive(false);
        How.gameObject.SetActive(true);
        yield return TypeSentence(How, How.text);
        //3. cümle
        yield return new WaitForSeconds(3);
        How.gameObject.SetActive(false);
        Machine.gameObject.SetActive(true);
        yield return TypeSentence(Machine, Machine.text);
        //4. cümle
        yield return new WaitForSeconds(3);
        SecondScene.gameObject.SetActive(false);
        Machine.gameObject.SetActive(false);
        FirstScene.gameObject.SetActive(true);
        yield return new WaitForSeconds(1);
        Machine2.gameObject.SetActive(true);
        yield return TypeSentence(Machine2, Machine2.text);
        //5.cümle
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}