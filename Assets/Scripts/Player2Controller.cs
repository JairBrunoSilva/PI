using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour
{
    // p2 = exatas
    public float p2speed = 4.5f, forJump2 = 4.5f;

    private Rigidbody2D body;
    private float horizontal;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(horizontal * p2speed, body.velocity.y);

        if ((Input.GetKeyDown(KeyCode.W) || (Input.GetKeyDown(KeyCode.UpArrow)) && this.GetComponent<Rigidbody2D>().velocity.y == 0))
        {
            this.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, forJump2), ForceMode2D.Impulse);
        }
    }
}