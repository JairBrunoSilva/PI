using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Controller : MonoBehaviour
{
    // p1 = biologicas
    public float p1speed = 4.5f, forJump1 = 4.5f;

    private Rigidbody2D body;
    private float horizontal;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(horizontal * p1speed, body.velocity.y);

            if ((Input.GetKeyDown(KeyCode.W) || (Input.GetKeyDown(KeyCode.UpArrow)) && this.GetComponent<Rigidbody2D>().velocity.y == 0))
            {
                this.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, forJump1), ForceMode2D.Impulse);
            }
    }
}