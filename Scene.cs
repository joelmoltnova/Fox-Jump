using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ShowInstructions()
    {
        SceneManager.LoadScene("Instructies");
    }

    public void HideInstructions()
    {
        SceneManager.LoadScene("Beginscherm"); 
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("Beginscherm");
    }

    public void BackToGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}