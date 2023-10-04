using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public AudioSource gameOverSFX;
    public AudioSource playAgain;
    public AudioSource gameOverTheme;
    // Start is called before the first frame update
    void Start()
    {
        gameOverSFX.Play();
        gameOverTheme.Play();
    }

    public void TryAgain()
    {
        playAgain.Play();
        StartCoroutine("LoadPong");
    }
    public void QuitGame()
    {
        SceneManager.LoadScene("QuitScreen");
    }

    IEnumerator LoadPong()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Pong");
    }
}
