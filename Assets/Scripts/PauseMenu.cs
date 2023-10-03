using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour
{
    public KeyCode pauseKey = KeyCode.Escape;
    public bool isPaused = false;

    public GameObject pauseMenu;
    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Pause();
    }

    private void Pause()
    {
        if (Input.GetKeyDown(pauseKey))
        {
            isPaused = !isPaused;

            if (isPaused)
            {
                PauseGame();
            }
            else
            {
                ResumeGame();
            }
        }
       
    }

    private void PauseGame()
    {
        TimeManager.instance.SetTimeScale(0f); // Pause the game
        Cursor.visible = true;
        pauseMenu.SetActive(true);
    }

    private void ResumeGame()
    {
        TimeManager.instance.SetTimeScale(1f); // Unpause the game
        Cursor.visible = false;
        pauseMenu.SetActive(false);
        isPaused = false;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

   
}
