using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed;
    private bool upD;
    private bool downD;
    private bool leftD;
    private bool rightD;
    private bool upR;
    private bool downR;
    private bool leftR;
    private bool rightR;
    private float cos45 = (Mathf.Sqrt(2)/2);
    //private Rigidbody2D rb;

    // Update is called once per frame
    void Update ()
    {
       
    }

    private void FixedUpdate()
    {
        //rb = GetComponent<Rigidbody2D>();

        upD = Input.GetKey(KeyCode.W);
        downD = Input.GetKey(KeyCode.S);
        leftD = Input.GetKey(KeyCode.A);
        rightD = Input.GetKey(KeyCode.D);

        if (upD && !rightD && !leftD)
        {
            transform.Translate(Vector2.up * speed);
            //rb.AddForce(Vector2.up * speed);
        }
        if (downD && !rightD && !leftD)
        {
            transform.Translate(Vector2.down * speed);
            //rb.AddForce(Vector2.down * speed);
        }
        if (leftD && !upD && !downD)
        {
            transform.Translate(Vector2.left * speed);
            //rb.AddForce(Vector2.left * speed);
        }
        if (rightD && !upD && !downD)
        {
            transform.Translate(Vector2.right * speed);
            //rb.AddForce(Vector2.right * speed);
        }
        if (upD && leftD)
        {
            transform.Translate(Vector2.up * speed * cos45);
            //rb.AddForce(Vector2.up * speed * cos45);
            transform.Translate(Vector2.left * speed * cos45);
            //rb.AddForce(Vector2.left * speed * cos45);
        }
        if (upD && rightD)
        {
            transform.Translate(Vector2.up * speed * cos45);
            //rb.AddForce(Vector2.up * speed * cos45);
            transform.Translate(Vector2.right * speed * cos45);
            //rb.AddForce(Vector2.right * speed * cos45);
        }
        if (downD && leftD)
        {
            transform.Translate(Vector2.down * speed * cos45);
            //rb.AddForce(Vector2.down * speed * cos45);
            transform.Translate(Vector2.left * speed * cos45);
            //rb.AddForce(Vector2.left * speed * cos45);
        }
        if (downD && rightD)
        {
            transform.Translate(Vector2.down * speed * cos45);
            //rb.AddForce(Vector2.down * speed * cos45);
            transform.Translate(Vector2.right * speed * cos45);
            //rb.AddForce(Vector2.right * speed * cos45);
        }
        /*if (!upD && !downD && !leftD && !rightD)
        {
            rb.velocity = Vector2.up * 0;
            rb.velocity = Vector2.down * 0;
            rb.velocity = Vector2.left * 0;
            rb.velocity = Vector2.right * 0;
        }*/
    }
}   
