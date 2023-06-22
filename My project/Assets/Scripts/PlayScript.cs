using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayScript : MonoBehaviour
{
    // Build scene number to start when start button is  pressed
    
    // Sample Scene for now
    public int gameStartScene;
    public void StartGame()
    {
        SceneManager.LoadScene(gameStartScene);
    }

    public void OpenOptions() {
        SceneManager.LoadScene(gameStartScene);
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape) && gameStartScene == 2) {
            gameStartScene = 0;
            SceneManager.LoadScene(gameStartScene);
        }
    }
}
