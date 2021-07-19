using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    Animator animator;
    SpriteRenderer SR;
    
    int health = 3;
    bool immune = false;

    [SerializeField] float speed = 5f;
    [SerializeField] float jumpForce = 5f;

    bool isGrounded = false;
    bool disableInput = false;
    void Start()
    {
        AudioManager.PlayAudio("bgm");
        SR = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 3f;
        Debug.Log("PLAYER HP: "+health);
    }

    private void Update()
    {
        if (!disableInput)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                animator.SetFloat("Speed", speed);
                rb.velocity = new Vector2(-speed, rb.velocity.y);
                transform.localScale = new Vector2(-1, transform.localScale.y);
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                animator.SetFloat("Speed", speed);
                rb.velocity = new Vector2(speed, rb.velocity.y);
                transform.localScale = new Vector2(1, transform.localScale.y);
            }
            else
            {
                animator.SetFloat("Speed", 0f);
                rb.velocity = new Vector2(0f, rb.velocity.y);
            }

            if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
            {
                AudioManager.PlayAudio("playerJump");
                animator.SetBool("Grounded", false);
                rb.velocity = Vector2.up * jumpForce;
            }

            if (animator.GetBool("Shooting"))
            {
                rb.velocity = new Vector2(0f, rb.velocity.y);
            }
        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            isGrounded = true;
            animator.SetBool("Grounded", true);
        }
        if (collision.gameObject.CompareTag("Zombie") && !immune)
        {
            AudioManager.PlayAudio("playerHit");
            Physics2D.IgnoreLayerCollision(6, 7, true);
            immune = true;
            SR.color = Color.gray;
            StartCoroutine(takeDmgDelay());
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            isGrounded = false;
            animator.SetBool("Grounded", false);
        }
    }

    IEnumerator takeDmgDelay()
    {
        health = health - 1;
        healthScript.healthValue = health;
        if (health == 0)
        {
            Time.timeScale = 0f;
            disableInput = true;
        }
        yield return new WaitForSeconds(2f);
        SR.color = Color.white;
        immune = false;
        Physics2D.IgnoreLayerCollision(6, 7, false);
    }

}
