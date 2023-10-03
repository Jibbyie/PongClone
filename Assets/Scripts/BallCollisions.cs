using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollisions : MonoBehaviour
{
    Rigidbody2D ballRB;
    public GameObject respawnPoint;
    public float respawnDelay = 0.1f;
    public float ballSpeed = 5f;

    public AudioSource pongBlip;
    public AudioSource pongBlipBarrier;
    public AudioSource ballOutOfBounds;
    // Start is called before the first frame update
    void Start()
    {
        ballRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("SDL") || collision.gameObject.CompareTag("SDR"))
        {
            ballOutOfBounds.Play();
            BallOutOfBounds();
        }

        if (collision.gameObject.CompareTag("Floor") || collision.gameObject.CompareTag("Ceiling"))
        {
            pongBlipBarrier.Play();
        }


        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Enemy"))
        {
            pongBlip.Play();
        }
    }

    private void BallOutOfBounds()
    {
        StartCoroutine(RespawnBall());
    }

    IEnumerator RespawnBall()
    {
        ballRB.velocity = Vector2.zero;
        yield return new WaitForSeconds(respawnDelay);
        ballRB.transform.position = respawnPoint.transform.position;

        float minAngle = -60f * Mathf.Deg2Rad; // Convert degrees to radians
        float maxAngle = 60f * Mathf.Deg2Rad;

        float ballAngle = Random.Range(minAngle, maxAngle);
        ballRB = GetComponent<Rigidbody2D>();
        Vector2 randomDir = new Vector2(Mathf.Cos(ballAngle), Mathf.Sin(ballAngle));
        ballRB.velocity = randomDir * ballSpeed;
    }
}
