using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuHandler : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene("MainGame");
    }


    public void QuitGame()
    {
        Application.Quit();
    }
}
