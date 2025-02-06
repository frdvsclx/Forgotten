
using UnityEngine;
using UnityEngine.SceneManagement;

public class PowerControler : MonoBehaviour
{

    public GameObject platform1, platform2, laser1, laser2;
    bool power1;



    private void Start()
    {
        platform1.SetActive(true);
        platform2.SetActive(false);
        laser1.SetActive(true);
        laser2.SetActive(false);
        Time.timeScale = 1.0f;



    }

    private void Update()
    {
        if (power1 == true)
        {
            platform1.SetActive(true);
            platform2.SetActive(false);
            laser1.SetActive(true);
            laser2.SetActive(false);
        }
        if (power1 == false)
        {
            platform1.SetActive(false);
            platform2.SetActive(true);
            laser1.SetActive(false);
            laser2.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            power1 = !power1;
        }



    }


    public void RestartButton()
    {
        SceneManager.LoadScene(2);

        Time.timeScale = 1f;

    }

    public void QuitButton()
    {
        Application.Quit();
    }

    public void menubutton()
    {
        SceneManager.LoadScene(0);

    }


}
