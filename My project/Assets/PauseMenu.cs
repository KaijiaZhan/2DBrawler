using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool isPaused = false;

    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            if (isPaused) {
                Resume();
            }
            else {
                Pause();
            }
        }
        if (Input.GetKeyDown(KeyCode.Escape) && SceneManager.GetActiveScene().buildIndex == 2) {
            SceneManager.LoadScene(1);
        }
    }

    public void Resume() {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;

    }

    void Pause() {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void LoadMenu() {
        Debug.Log("Loading menu...");
        SceneManager.LoadScene(2);
    }

    public void QuitGame() {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}
