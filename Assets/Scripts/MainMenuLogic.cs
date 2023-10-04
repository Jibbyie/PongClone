using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuLogic : MonoBehaviour
{
    public AudioSource playSFX;
    public AudioSource mainMenuTheme;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void PlayGame()
    {
        playSFX.Play();
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
