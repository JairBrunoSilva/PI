using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P2NAOprova : MonoBehaviour
{
    private Rigidbody2D body;
    private float horizontal;
    static public float speeed2 = 1.0f;
    static public bool provaconfirm2;
    static public int sanityExa = 100;
    public Text sanityBar2;
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(horizontal * speeed2, body.velocity.y);

        sanityBar2.text = "Sanidade: " + sanityExa;
    }
    void OnTriggerStay2D(Collider2D collision)
    {
        if ((collision.gameObject.CompareTag("porta")) && (Input.GetKey(KeyCode.Z)) && !provaconfirm2)
        {
            provaconfirm2 = true;
        }
        else
        {
            provaconfirm2 = false;
        }
    }
}