using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P3NAOprova : MonoBehaviour
{
    private Rigidbody2D body;
    private float horizontal;
    static public float speeed3 = 1.0f;
    static public bool provaconfirm3;
    static public int sanityHum = 100;
    public Text sanityBar3;
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(horizontal * speeed3, body.velocity.y);

        sanityBar3.text = "Sanidade: " + sanityHum;
    }
    void OnTriggerStay2D(Collider2D collision)
    {
        if ((collision.gameObject.CompareTag("porta")) && (Input.GetKey(KeyCode.Z)) && !provaconfirm3)
        {
            provaconfirm3 = true;
        }
        else
        {
            provaconfirm3 = false;
        }
    }
}