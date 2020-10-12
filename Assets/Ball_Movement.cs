using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Movement : MonoBehaviour
{
    public Rigidbody2D ball;
    public float speed;
    void Start()
    {
        begin();
    }
    // Update is called once per frame
    public void begin()
    {
        speed = 10;
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        ball.velocity = new Vector2(speed * x, speed * y);
    }
}
