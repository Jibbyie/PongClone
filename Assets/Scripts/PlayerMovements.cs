using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    Rigidbody2D playerRB;

    bool isPressed = false;

    public float movementSpeed = 15f;
    public float slowDownTimeAmount = 0.25f;

    public float timeToSlowDown_slow = 0.5f;
    public float timeToSpeedUp_slow = 1f;


    private float originalTimeScaleSpeed = 1f;


    public KeyCode timeSlowDown = KeyCode.R;
    public AudioSource timeSlowDownSFX;
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        Time.timeScale = originalTimeScaleSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        playerRB.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * 0, Input.GetAxisRaw("Vertical") * movementSpeed + Time.deltaTime);
        slowDownTime();
    }

    void slowDownTime()
    {
        if (Input.GetKey(timeSlowDown))
        {
            isPressed = !isPressed;
            StartCoroutine(LerpTime(slowDownTimeAmount, timeToSlowDown_slow));
        }
        if(Input.GetKey(timeSlowDown) && isPressed)
        {
            if (Time.timeScale <= slowDownTimeAmount)
            {
                StartCoroutine(LerpTime(originalTimeScaleSpeed, timeToSpeedUp_slow));
            }
        }
    }

    void ApplyPitchToSFX(float pitch)
    {
        AudioSource backgroundMusicAudioSource = FindObjectOfType<OnGoingGameLogic>().GetBackgroundMusicAudioSource();
        backgroundMusicAudioSource.pitch = pitch;

        AudioSource[] pongSFXArray = FindObjectOfType<BallCollisions>().GetAudioSources();
        foreach (var sfx in pongSFXArray)
        {
            sfx.pitch = pitch;
        }
    }

    IEnumerator LerpTime(float lerpTimeTo, float timeToTake)
    {
        float endTime = Time.time + timeToTake;
        float startTimeScale = Time.timeScale;
        float i = 0f;
        while (Time.time < endTime)
        {
            i += (1 / timeToTake) * Time.deltaTime;
            Time.timeScale = Mathf.Lerp(startTimeScale, lerpTimeTo, i);
            ApplyPitchToSFX(Time.timeScale);
            yield return null;
        }
        Time.timeScale = lerpTimeTo;
    }
}
