using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float bulletSpeed = 3f;

    SpriteRenderer SR;
    private void Start()
    {
        SR = GetComponent<SpriteRenderer>();
        if(transform.localScale.x > 0)
        {
            SR.flipX = false;
        }else if(transform.localScale.x < 0)
        {
            SR.flipX = true;
        }
    }
    void FixedUpdate()
    {
        transform.localPosition = new Vector2(transform.localPosition.x+bulletSpeed*Time.fixedDeltaTime*transform.localScale.x, transform.localPosition.y);
    }


}
