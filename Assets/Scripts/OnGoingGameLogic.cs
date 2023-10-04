using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnGoingGameLogic : MonoBehaviour
{

    public AudioSource gameStartSFX;
    public AudioSource backgroundMusic;
    // Start is called before the first frame update
    void Start()
    {
        gameStartSFX.Play();
        Invoke("PlayMainMenuMusic", 1.5f);
    }

    void PlayMainMenuMusic()
    {
        backgroundMusic.Play();
    }

    // Public method to return the backgroundMusic AudioSource
    public AudioSource GetBackgroundMusicAudioSource()
    {
        return backgroundMusic;
    }

}
