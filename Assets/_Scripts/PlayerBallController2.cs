using UnityEngine;
using System.Collections;

public class PlayerBallController2 : MonoBehaviour
{
    public static PlayerBallController2 S;

    public int p2score = 0;

    public float speed;
    public float jumpForce;

    public bool canJump = false;

    private Rigidbody rb;

    void Awake()
    {
        S = this;
    }

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Jump()
    {
        rb.AddForce(0, jumpForce, 0, ForceMode.Impulse);
        canJump = false;
    }

    // PLAYER 2 #################################################
    void Update()
    {
        if (transform.position.y < -10.0f)
        {
            GameController.S.player2FallDeaths++;
            Application.LoadLevel(Application.loadedLevel);
        }
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal2");
        float moveVertical = Input.GetAxis("Vertical2");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);

        if (Input.GetKeyDown("space") && canJump)
        {
            Jump();
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("p1"))
        {
            if (transform.position.y > col.gameObject.transform.position.y)
            {
                PlayerBallController1.S.p1score--;
            }
        }
    }

    void OnCollisionStay(Collision collisionInfo)
    {
        canJump = true;
    }

}
