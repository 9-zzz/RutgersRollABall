using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Fader : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Image some = GetComponent<Image>();
        some.color = Color.red;
        some.CrossFadeAlpha(0, 2, true);
    }

    // Update is called once per frame
    void Update()
    {

    }

}
