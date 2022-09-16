using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;

public class NivelCompletado : MonoBehaviour
{
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Llegada"))
        {
            Thread.Sleep(200);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }
    }
}
