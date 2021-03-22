using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIButton : MonoBehaviour
{
    public void play()
    {
        SceneManager.LoadScene("Level1");
    }

    public void Controls()
    {
        SceneManager.LoadScene("Controls");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }


}
