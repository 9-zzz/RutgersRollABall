using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CamOffsetFollower : MonoBehaviour
{
    private Vector3 off;
    public GameObject player;

    void Start()
    {
        off = transform.position-player.transform.position;
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + off;
    }

}
