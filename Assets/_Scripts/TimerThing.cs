using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimerThing : MonoBehaviour
{
    public Text timerText;
    public float timer = 60.0f;
    private int p1score;
    private int p2score;
    public bool timeRanOut = false;

    public bool tenSecondsLeft = false;
    public bool startedTimeFlash = false;

    // Use this for initialization
    void Start()
    {

    }

    IEnumerator FlashTimeRunningOut()
    {
        while (true)
        {
            Fader.S.some.CrossFadeAlpha(0.25f, 1.0f, true);
            yield return new WaitForSeconds(1.0f);
            Fader.S.some.CrossFadeAlpha(0.0f, 1.0f, true);
            yield return new WaitForSeconds(1.0f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        p1score = PlayerBallController1.S.p1score;

        // Uggghhhh quick fix just because of the 1 player mode... maybe get rid of the one player mode...
        if (PlayerBallController2.S != null)
            p2score = PlayerBallController2.S.p2score;

        if (timer < 10.0f && !startedTimeFlash)
        {
            tenSecondsLeft = true;
            StartCoroutine(FlashTimeRunningOut());
            startedTimeFlash = true;
        }

        if (timer > 0.0f)
            timer -= Time.deltaTime;

        if (timer <= 0.0f && (timeRanOut == false))
        {
            StartCoroutine(CheckWhoWonWait());
            timeRanOut = true;
        }

        timerText.text = "SECONDS REMAINING: " + Mathf.Round(timer);
    }

    IEnumerator CheckWhoWonWait()
    {
        if (p1score > p2score)
        {
            Debug.Log("Player 1 wins");
        }
        else if (p2score > p1score)
        {
            Debug.Log("Player 2 wins");
        }
        else
        {
            Debug.Log("DRAW");
            GameController.S.draws++;
        }

        Debug.Log("Game over Time ran out, restarting in 3 seconds.");
        yield return new WaitForSeconds(3.0f);
        Application.LoadLevel(Application.loadedLevel);
    }

}
