using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameMode2Text : MonoBehaviour
{

    Text scoreText;
    int localScore;
    int localScore2;
    public bool wonGameMode1 = false;

    // Use this for initialization
    void Start()
    {
        scoreText = this.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        localScore = PlayerBallController1.S.p1score;
        localScore2 = PlayerBallController2.S.p2score;

        // THINK!!!
        if ((localScore <= 7) && (wonGameMode1 == false))
        {
            scoreText.text = "RED: " + localScore + "\nBLUE: " + localScore2;
        }
        else
        {
            scoreText.text = "YOU WIN Game Mode 1";
            wonGameMode1 = true; // Stop looping
        }
    }

}
