using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreKeeper : MonoBehaviour
{
    public TMP_Text playerScoreText;
    public TMP_Text enemyScoreText;

    public int playerScore = 0;
    public int enemyScore = 0;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            if (collision.gameObject.transform.position.x < 0)
            {
                enemyScore += 1;
                enemyScoreText.text = enemyScore.ToString();
            }
            else
            {
                playerScore += 1;
                playerScoreText.text = playerScore.ToString();
            }
        }
    }
}