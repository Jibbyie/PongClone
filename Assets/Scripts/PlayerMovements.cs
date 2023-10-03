using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    Rigidbody2D playerRB;
    public float movementSpeed = 15f;

    public KeyCode timeSlowDown = KeyCode.R;
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        playerRB.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * 0, Input.GetAxisRaw("Vertical") * movementSpeed);
        slowDownTime();
    }

    void slowDownTime()
    {
        if (Input.GetKey(timeSlowDown))
        {
            AudioSource backgroundMusicAudioSource = FindObjectOfType<OnGoingGameLogic>().GetBackgroundMusicAudioSource();
            AudioSource[] pongSFXArray = FindObjectOfType<BallCollisions>().GetAudioSources();
            AudioSource pongBlip = pongSFXArray[0];
            AudioSource pongBlipBarrier = pongSFXArray[1];
            AudioSource ballOutOfBounds = pongSFXArray[2];
            for(int i = 0; i < pongSFXArray.Length; i++)
            {
                pongSFXArray[i].pitch = Time.timeScale;
            }
            backgroundMusicAudioSource.pitch = Time.timeScale;
            Time.timeScale = 0.25f;
        }
        else
        {
            AudioSource backgroundMusicAudioSource = FindObjectOfType<OnGoingGameLogic>().GetBackgroundMusicAudioSource();
            backgroundMusicAudioSource.pitch = Time.timeScale;
            AudioSource[] pongSFXArray = FindObjectOfType<BallCollisions>().GetAudioSources();
            AudioSource pongBlip = pongSFXArray[0];
            AudioSource pongBlipBarrier = pongSFXArray[1];
            AudioSource ballOutOfBounds = pongSFXArray[2];
            for (int i = 0; i < pongSFXArray.Length; i++)
            {
                pongSFXArray[i].pitch = Time.timeScale;
            }
            backgroundMusicAudioSource.pitch = Time.timeScale;
            Time.timeScale = 1f;
        }
    }
}
