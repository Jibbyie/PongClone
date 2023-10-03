using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollisions : MonoBehaviour
{
    Rigidbody2D ballRB;
    public GameObject respawnPoint;
    public float respawnDelay = 0.1f;
    public float ballSpeed = 5f;
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
        if (collision.gameObject.tag == "SDL")
        {
            BallOutOfBounds();
            Debug.Log("Left Wall");
        }
        else if (collision.gameObject.tag == "SDR")
        {
            BallOutOfBounds();
            Debug.Log("Right Wall");
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

        float ballAngle = Random.Range(0f, 2f * Mathf.PI);
        ballRB = GetComponent<Rigidbody2D>();
        Vector2 randomDir = new Vector2(Mathf.Cos(ballAngle), Mathf.Sin(ballAngle));
        ballRB.velocity = randomDir * ballSpeed;
    }
}
