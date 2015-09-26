using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{
    public static GameController S;

    public int player1FallDeaths = 0;
    public int player2FallDeaths = 0;

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

    // Update is called once per frame
    void Update()
    {
        p1fall = player1FallDeaths;

        if (Input.GetKey(KeyCode.R))
            Application.LoadLevel(Application.loadedLevel);

        if (Input.GetKey(KeyCode.T))
            Application.LoadLevel(2);
    }

}
