using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.XR;

public class PlayerMovement : MonoBehaviour

{
    private Rigidbody2D rigidbody2D;
    public int speed = 4;
    private SpriteRenderer sr1;
    // Start is called before the first frame update
    void Start()

    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        sr1 = GetComponentInChildren<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        if (xInput > -1)
        {
            sr1.flipX = true;

        }
        else if (xInput < 1 )
        {
            sr1.flipY = true;
        }
        {
            sr1 .flipY = true;
        }
        rigidbody2D.velocity = new Vector2(xInput * speed, rigidbody2D.velocity.y);
    }
}
