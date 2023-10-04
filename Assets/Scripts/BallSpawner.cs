using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject ballPrefab;
    public int numberOfBalls = 1; // Number of balls in multi-ball mode
    public float spawnInterval = 10f; // Time between spawning new balls

    private void Start()
    {
        // Start spawning balls periodically
        Invoke("SpawnBall", spawnInterval);
    }

    void SpawnBall()
    {

     // Instantiate a new ball with different color or behavior
     GameObject ball = Instantiate(ballPrefab);

    }

}