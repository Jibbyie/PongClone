using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    Rigidbody2D enemyRB;
    Transform Ball;
    public float enemyMovementSpeed = 10f;
    public float bufferZone = 0.2f;
    Vector2 destination;

    void Start()
    {
        enemyRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Ball = GameObject.FindGameObjectWithTag("Ball").transform;

        if (Mathf.Abs(Ball.position.y - transform.position.y) > bufferZone)
        {
            if (Ball.position.y > transform.position.y)
            {
                destination = new Vector2(transform.position.x, transform.position.y + enemyMovementSpeed);
                transform.position = Vector2.Lerp(transform.position, destination, Time.deltaTime);
            }
            else
            {
                destination = new Vector2(transform.position.x, transform.position.y - enemyMovementSpeed);
                transform.position = Vector2.Lerp(transform.position, destination, Time.deltaTime);
            }
        }
    }
}
