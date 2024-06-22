using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public float JumpForce;
    public Rigidbody2D Rb2D;

    void Jump()
    {
        Rb2D.velocity = Vector2.zero;
        Rb2D.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World!");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            Jump();
        }
    }
}