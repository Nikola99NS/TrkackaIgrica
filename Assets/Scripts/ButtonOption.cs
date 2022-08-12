using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonOption : MonoBehaviour
{
    


    public void PlayGame()
    {
        SceneManager.LoadScene("TrackSelect");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main menu");
    }

    public void Track01()
    {
        SceneManager.LoadScene("Staza1");
    }

    public void Track02()
    {
        SceneManager.LoadScene("Staza2");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
