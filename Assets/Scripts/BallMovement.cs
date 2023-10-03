using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    Rigidbody2D ballRB;
    public float spawnSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
     float x = Random.Range(-5f, 5f);
     float y = Random.Range(-5f, 5f);
     ballRB = GetComponent<Rigidbody2D>();
     ballRB.velocity = new Vector2(x * spawnSpeed, y * spawnSpeed);
    }


}
