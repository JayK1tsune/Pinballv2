using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void back()
    {
        SceneManager.LoadScene(0);
    }
    public void settings()
    {
        SceneManager.LoadScene("Settings");
    }
    public void hardmode()
    {
        SceneManager.LoadScene(3);
    }

}
