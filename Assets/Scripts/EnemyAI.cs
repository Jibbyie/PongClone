using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    Rigidbody2D enemyRB;
    Transform Ball;
    public float enemyMovementSpeed = 10f;

    void Start()
    {
        enemyRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Ball = GameObject.FindGameObjectWithTag("Ball").transform;

        if (Ball.position.y > transform.position.y)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + enemyMovementSpeed * Time.deltaTime);
        }
        else
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - enemyMovementSpeed * Time.deltaTime);
        }
    }
}
