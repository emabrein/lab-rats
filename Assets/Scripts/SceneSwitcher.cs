using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void exitGame()
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
}
