using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EndGameOver : MonoBehaviour
{
    public ParticleSystem bps;
    public ParticleSystem rps;
    Text thisText;

    void Awake()
    {
        thisText = GetComponent<Text>();
    }

    // Use this for initialization
    void Start()
    {
        if (GameController.S.redScoredGoal)
        {
            rps.Play();
        }
        else
        {
            bps.Play();
        }

        thisText.text = "NUMBER OF DRAWS: " + GameController.S.draws +
            "\nNUMBER OF TIMES RED FELL OFF: " + GameController.S.player1FallDeaths +
            "\nNUMBER OF TIMES BLUE FELL OFF: " + GameController.S.player2FallDeaths +
            "\n\nTHE WINNER IS LIT A FLAME IN VICTORY!!!"; 

        thisText.CrossFadeAlpha(0, 0, true);
        thisText.CrossFadeAlpha(1, 2, true);

    }

    // Update is called once per frame
    void Update()
    {

    }

}
