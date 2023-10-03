using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BallMovement : MonoBehaviour
{
    Rigidbody2D ballRB;
    public float spawnSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        float minAngle = -60f * Mathf.Deg2Rad; // Convert degrees to radians
        float maxAngle = 60f * Mathf.Deg2Rad;

        float ballAngle = Random.Range(minAngle, maxAngle);
        ballRB = GetComponent<Rigidbody2D>();
        Vector2 randomDir = new Vector2(Mathf.Cos(ballAngle), Mathf.Sin(ballAngle));
        ballRB.velocity = randomDir * spawnSpeed;

    }


}
