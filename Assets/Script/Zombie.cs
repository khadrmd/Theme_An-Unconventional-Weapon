using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    float moveSpeed;

    GameObject player;

    Rigidbody2D rb;

    Animator animator;

    int health = 5;

    string[] str = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"};
    string alphabet;
    int alphabetIndex;
    GameObject headInfoClone;

    public Transform headInfo;
    public GameObject[] alphabetPrefab;

    void Start()
    {
        alphabetIndex = Random.Range(0, 25);
        alphabet = str[alphabetIndex];
        animator = GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player");
        rb = GetComponent<Rigidbody2D>();
        moveSpeed = Random.Range(0.01f, 0.025f);
        headInfoClone = showHeadInfo();
    }

    void FixedUpdate()
    {
        if(player.transform.position.x < transform.position.x)
        {
            transform.localScale = new Vector2(1, transform.localScale.y);
        }
        if (player.transform.position.x > transform.position.x)
        {
            transform.localScale = new Vector2(-1, transform.localScale.y);
        }

        if (rb.gravityScale == 0f)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y+moveSpeed);
        }
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(player.transform.position.x, transform.position.y), moveSpeed);

        if(health <= 0)
        {
            scoreScript.scoreValue += 1;
            Destroy(gameObject);
            Destroy(headInfoClone);
        }
        else
        {
            headInfoClone.transform.position = headInfo.position;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            animator.SetBool("Climbing", true);
            rb.gravityScale = 0f;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            animator.SetBool("Climbing", false);
            StartCoroutine(gravityDelay());
        }
    }
    IEnumerator gravityDelay()
    {
        yield return new WaitForSeconds(0.1f);
        rb.gravityScale = 1f;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == alphabet+"(Clone)" && collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(collision.gameObject);
            AudioManager.PlayAudio("zombieHit");
            health--;
            Debug.Log("ZOMBIE HP: " + health);
        }
        else if(collision.gameObject.name != alphabet+"(Clone)" && collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(collision.gameObject);
            AudioManager.PlayAudio("zombieSpawn");
            health++;
            Debug.Log("ZOMBIE HP: " + health);
        }
    }

    GameObject showHeadInfo()
    {
        var clone = Instantiate(alphabetPrefab[alphabetIndex], headInfo.position, Quaternion.identity);
        Destroy(clone.GetComponent<CircleCollider2D>());
        Destroy(clone.GetComponent<Bullet>());
        return clone;
    }
}
