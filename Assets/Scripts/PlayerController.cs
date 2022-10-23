using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float moveSpeed;
    Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Jump") && (rb.velocity.y < 0.01f && rb.velocity.y > -0.01f))
        {
            rb.gravityScale = -rb.gravityScale;
        }
        float velocityX = moveSpeed * Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(velocityX, rb.velocity.y);


    }
}
