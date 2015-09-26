using UnityEngine;
using System.Collections;

public class GoalKeeperR : MonoBehaviour
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
            Debug.Log("Rightt goal so red wins.");
            this.GetComponent<GoalRainbow>().enabled = true;
        }
    }

}
