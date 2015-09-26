using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Fader1 : MonoBehaviour
{
    public static Fader1 S;
    public Image some;

    void Awake()
    {
        S = this;
        some = GetComponent<Image>();
    }

    // Use this for initialization
    void Start()
    {
        some.color = Color.white;
        some.CrossFadeAlpha(0, 0, true);
    }

    // Update is called once per frame
    void Update()
    {

    }

}
