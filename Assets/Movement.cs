using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    public Rigidbody2D ball; 
    public bool isAI;
    public bool isPlayerOne;
    public float speed; 
   
    // Update is called once per frame
    void Update()
    {
        if(isAI)
        {
            Vector2 ball_position = new Vector2(rb.position.x, ball.position.y);
            rb.MovePosition(ball_position);
            
        }
        else if(isPlayerOne)
        {
            float movement = Input.GetAxis ("Vertical");
            rb.velocity = new Vector2(rb.velocity.x, movement * speed);
        }
        else
        {
            float movement = Input.GetAxis ("Vertical2");
            rb.velocity = new Vector2(rb.velocity.x, movement * speed);
        }    
    }
}
