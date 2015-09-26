using UnityEngine;
using System.Collections;

public class PlayerBallController1 : MonoBehaviour
{
    public static PlayerBallController1 S;

    public int p1score = 0;

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

    void Update()
    {
        if (transform.position.y < -10.0f)
        {
            if (GameController.S != null)
                GameController.S.player1FallDeaths++;

            Application.LoadLevel(Application.loadedLevel);
        }
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);

        if (Input.GetKeyDown(KeyCode.RightControl) && canJump)
        {
            Jump();
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("p2"))
        {
            if (transform.position.y > col.gameObject.transform.position.y)
            {
                PlayerBallController2.S.p2score--;
            }
        }
    }

    void OnCollisionStay(Collision collisionInfo)
    {
        canJump = true;
    }

}
