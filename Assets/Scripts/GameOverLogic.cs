using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverLogic : MonoBehaviour
{
    public ScoreKeeper scoreReferenceLWall;
    public ScoreKeeper scoreReferenceRWall;
    public int gameOverScore;

    // Update is called once per frame
    void Update()
    {
        if (scoreReferenceLWall.playerScore >= gameOverScore || scoreReferenceRWall.playerScore >= gameOverScore)
        {
            scoreReferenceRWall.playerScoreText.text = scoreReferenceRWall.playerScore.ToString();
            StartCoroutine("LoadGameOver");
        }
        else if(scoreReferenceLWall.enemyScore >= gameOverScore || scoreReferenceRWall.enemyScore >= gameOverScore)
        {
            scoreReferenceLWall.enemyScoreText.text = scoreReferenceLWall.enemyScore.ToString();
            StartCoroutine("LoadGameOver");
        }
    }

    IEnumerator LoadGameOver()
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene("GameOver");
    }
}
