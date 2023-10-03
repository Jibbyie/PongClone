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
                Time.timeScale = 0;
                Cursor.visible = true;
                pauseMenu.SetActive(true);
            }
            else
            {
                Time.timeScale = 1;
                Cursor.visible = false;
                pauseMenu.SetActive(false);
            }
        }
       
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
