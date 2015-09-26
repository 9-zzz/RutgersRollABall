using UnityEngine;
using System.Collections;

public class OctaPickup : MonoBehaviour
{

    public Vector3 spin;
    public GameObject destFX;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(spin);
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("p1"))
        {
            PlayerBallController1.S.p1score++;
            //
            Destroy(gameObject);
        }

        if (col.CompareTag("p2"))
        {
            PlayerBallController2.S.p2score++;
            //
            Destroy(gameObject);
        }
    }

}
