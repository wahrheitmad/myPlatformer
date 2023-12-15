using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
 
    [SerializeField] private float speed = 3f;
    [SerializeField] private int lives = 5;
    [SerializeField] private float jumpForce = 15f;

    private Rigidbody2D rb;
    private SpriteRenderer  sprite;
    private bool isGrounded;
    public Joystick joystick;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponentInChildren<SpriteRenderer>();
    }

    private void Run()
    {
        Vector3 dir = transform.right * joystick.Horizontal;
        transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, speed * Time.deltaTime);
        sprite.flipX = dir.x < 0.0f;
    }

    private void FixedUpdate()
    {      
        CheckGround();
    }
    private void Update()
    {
        if (joystick.Horizontal !=0 )  Run();  
        if (isGrounded && joystick.Vertical > 0.5f)  Jump();  
    }

    private void Jump()
    {
        //rb.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
        rb.velocity = Vector2.up * jumpForce;
    }

    private void CheckGround()
    {
        Collider2D[] collider = Physics2D.OverlapCircleAll(transform.position, 0.8f);
        isGrounded = collider.Length > 1;
    }
}
