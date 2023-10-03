using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreKeeper : MonoBehaviour
{
    public TMP_Text playerScoreText;
    public TMP_Text enemyScoreText;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            if (collision.gameObject.transform.position.x < 0)
            {
                int enemyScore = int.Parse(enemyScoreText.text);
                enemyScore++;
                enemyScoreText.text = enemyScore.ToString();
            }
            else
            {
                int playerScore = int.Parse(playerScoreText.text);
                playerScore++;
                playerScoreText.text = playerScore.ToString();
            }
        }
    }
}
