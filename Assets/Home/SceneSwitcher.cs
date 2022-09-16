using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void showHistoria()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void hideHistoria()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void playGame1()
    {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
    public void exitGame1()
    {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
    public void tryAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void backToMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }
}