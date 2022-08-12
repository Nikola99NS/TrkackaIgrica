using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMeni : MonoBehaviour
{
  
    public GameObject mainMenu;

    public static int p=0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            p++;
            if ((p % 2)==0)
            {
                
                mainMenu.SetActive(false);
                Time.timeScale = 1f;
            }
            else
            {
                
                mainMenu.SetActive(true);
                Time.timeScale = 0f;
            }
        }
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main menu");
    }
}


