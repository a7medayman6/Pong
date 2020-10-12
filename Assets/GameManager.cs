using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject ball;
    
    public GameObject player1;
    public GameObject player1Goal;
    public GameObject player1textScore;
    private Vector3 player1startPos;
    private Vector3 player2startPos;
    private Vector3 ballstartPos;
    public GameObject player2;
    public GameObject player2Goal;
    public GameObject player2textScore;

    int player1score = 0;
    int player2score = 0;

    void Start()
    {
        
        player1startPos = player1.transform.position;
        player2startPos = player2.transform.position;
        ballstartPos = ball.transform.position;
    }
    public void Player1Scored()
    {
        player1score++;
        player1textScore.GetComponent<Text>().text = player1score.ToString();
        Reset();
    }
    public void Player2Scored()
    {
        player2score++;
        player2textScore.GetComponent<Text>().text = player2score.ToString();
        Reset();
    }
    private void Reset()
    {
        player1.transform.position = player1startPos;
        player2.transform.position = player2startPos;
        ball.transform.position = ballstartPos;
        ball.GetComponent<Ball_Movement>().begin();
    }

}
