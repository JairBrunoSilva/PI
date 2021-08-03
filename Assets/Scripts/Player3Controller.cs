using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player3Controller : MonoBehaviour
{
    // p3 = humanas
    public float p3speed = 4.5f, forJump3 = 4.5f;

    private Rigidbody2D body;
    private float horizontal;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(horizontal * p3speed, body.velocity.y);

        if ((Input.GetKeyDown(KeyCode.W) || (Input.GetKeyDown(KeyCode.UpArrow)) && this.GetComponent<Rigidbody2D>().velocity.y == 0))
        {
            this.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, forJump3), ForceMode2D.Impulse);
        }
    }
}