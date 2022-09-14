using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void playGame1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void exitGame1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void showHistoria()
    {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
    public void hideHistoria()
    {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
    public void playGame2()
    {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }
    public void exitGame2()
    {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }
}
