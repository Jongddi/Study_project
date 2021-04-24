using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    private bool isDead = false;

    private Rigidbody2D rigidbody2D;
    private Animator animator;

    public float upForce = 200f;

    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if(isDead==false)
		{
            if(Input.GetMouseButtonDown(0))
			{
                rigidbody2D.velocity = Vector2.zero;
                rigidbody2D.AddForce(new Vector2(0, upForce));
                animator.SetTrigger("Fly");
            }
		}
    }

	void OnCollisionEnter2D(Collision2D collision)
	{
        isDead = true;
        animator.SetTrigger("Dead");
        GameControl.instance.BirdDead();
    }
}
