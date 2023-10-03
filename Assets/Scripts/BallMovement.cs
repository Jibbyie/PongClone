using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    Rigidbody2D ballRB;
    public float ballSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        ballRB = GetComponent<Rigidbody2D>();
        ballRB.velocity = new Vector2(ballSpeed, ballSpeed);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if (collision.gameObject.tag == "Floor")
        //{
        //    ballRB.velocity = transform.up * ballSpeed;
        //}
        //else if (collision.gameObject.tag == "Ceiling")
        //{
        //    ballRB.velocity = -transform.up * ballSpeed;
        //}
    }
}
