using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoadere : MonoBehaviour


{
    public void LoadNextScene()
    {
        int CurrentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene("Level1");
    }

    public void LoadFirstScene()
    {
        SceneManager.LoadScene(0);
    }
     public void QuitGame()
    {
        Application.Quit();
       
            
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        SceneManager.LoadScene("Game Over");

    }
}
