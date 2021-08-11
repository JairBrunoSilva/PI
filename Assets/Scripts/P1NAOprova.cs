using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P1NAOprova : MonoBehaviour
{
    private Rigidbody2D body;
    private float horizontal;
    static public float speeed1 = 1.0f;
    static public bool provaconfirm1;
    static public int sanityBio = 100;
    public Text sanityBar1;
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(horizontal * speeed1, body.velocity.y);

        sanityBar1.text = "Sanidade: "+sanityBio;
    }
    void OnTriggerStay2D(Collider2D collision)
    {
        if ((collision.gameObject.CompareTag("porta")) && (Input.GetKey(KeyCode.Z)) && !provaconfirm1)
        {
            provaconfirm1 = true;
        }
        else
        {
            provaconfirm1 = false;
        }
    }
}