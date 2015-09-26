using UnityEngine;
using System.Collections;

public class GameStart : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")) Application.LoadLevel(1);
    }
}
