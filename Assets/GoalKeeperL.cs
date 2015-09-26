using UnityEngine;
using System.Collections;

public class GoalKeeperL : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("playball"))
        {
            Debug.Log("Left goal so blue wins.");
            this.GetComponent<GoalRainbow>().enabled = true;
        }
    }

}
