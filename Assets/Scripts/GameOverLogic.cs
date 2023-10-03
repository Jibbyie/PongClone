using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverLogic : MonoBehaviour
{

    public ScoreKeeper scoreReference;
    public int playerScore;
    public int enemyScore;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        int playerScore = int.Parse(scoreReference.playerScoreText.text);
        int enemyScore = int.Parse(scoreReference.enemyScoreText.text);

        if (playerScore == 2)
        {
            Debug.Log("Player Wins!");
        }
        else if(enemyScore == 2)
        {
            Debug.Log("Enemy Wins!");
        }
    }
}
