using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameMode1Text : MonoBehaviour
{

    Text scoreText;
    int localScore;
    public bool wonGameMode1 = false;

    // Use this for initialization
    void Start()
    {
        scoreText = this.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (wonGameMode1 && Input.GetKey(KeyCode.T))
        {
            GameController.S.GetComponent<GameController>().enabled = true;
            Application.LoadLevel(2);
        }

        localScore = PlayerBallController1.S.p1score;

        if ((localScore <= 7) && (wonGameMode1 == false))
        {
            scoreText.text = "SCORE: " + localScore;
        }
        else
        {
            scoreText.text = "YOU WIN Game Mode 1\npress 'T' to go to 2 Player mode.";
            wonGameMode1 = true; // Stop looping
        }
    }

}
