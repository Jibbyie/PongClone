using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BallMovement : MonoBehaviour
{
    Rigidbody2D ballRB;
    public float spawnSpeed = 10f;
    float randomNum;
    float ballAngle;
    float xSpeed;
    float ySpeed;
    // Start is called before the first frame update
    void Start()
    {
        float ballAngle = Random.Range(0f, 2f * Mathf.PI);
        ballRB = GetComponent<Rigidbody2D>();
        Vector2 randomDir = new Vector2(Mathf.Cos(ballAngle), Mathf.Sin(ballAngle));
        ballRB.velocity = randomDir * spawnSpeed;

    }


}
