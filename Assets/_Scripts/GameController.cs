using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{
    public static GameController S;

    public int player1FallDeaths = 0;
    public int player2FallDeaths = 0;
    public int draws = 0;

    public bool redScoredGoal = false;
    public bool blueScoredGoal = false;

    public bool startEndGameSequence = false;

    public static int p1fall;

    // Use this for initialization
    void Start()
    {

    }

    void Awake()
    {
        S = this;
        DontDestroyOnLoad(this);
    }

    IEnumerator EndSeuqence()
    {
        // Disable both player movement. Game is OVER
        PlayerBallController1.S.GetComponent<PlayerBallController1>().enabled = false;
        PlayerBallController2.S.GetComponent<PlayerBallController2>().enabled = false;

        Fader1.S.some.CrossFadeAlpha(0.9f, 2.0f, true); // Fade nicely to white then load LAST SCENE...

        yield return new WaitForSeconds(2.0f);

        Application.LoadLevel(3); // Final scene.
    }

    // Update is called once per frame
    void Update()
    {
        p1fall = player1FallDeaths;

        if (Input.GetKey(KeyCode.R))
            Application.LoadLevel(Application.loadedLevel);

        if (Input.GetKey(KeyCode.T))
            Application.LoadLevel(2);

        if ((redScoredGoal || blueScoredGoal) && !startEndGameSequence)
        {
            StartCoroutine(EndSeuqence());
            startEndGameSequence = true;
        }
    }

}
