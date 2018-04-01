using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;
public class move : MonoBehaviour {

	// Use this for initialization
	public float speed= 5f;
    public float jumpForce = 600f;
	
	public static int health;
	float directionX;
	float directionY;
	SpriteRenderer sprite;
	//Animator animator;

    Rigidbody2D rb;
    void Start () {
		
		sprite = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
		//animator = GetComponent<Animator>();
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		directionX = CrossPlatformInputManager.GetAxis("Horizontal");
		//directionY = CrossPlatformInputManager.GetAxis("Vertical");
        //transform.Translate (0, directionY * speed * Time.deltaTime, 0); //mueve en el eje de Y
		transform.Translate (directionX * speed * Time.deltaTime,0, 0);	//mueve en el eje de X

        if (CrossPlatformInputManager.GetButtonDown("Jump"))
        {

            Jump();

        }


        //if(directionX == 0)
        //animator.SetFloat("run",-1);
        //else
        //animator.SetFloat("run",1);


        //flip();
    }
	void flip()
	{
		if(directionX < 0)
		{
			sprite.flipX = true;
		}
		else if(directionX > 0)
		{
			sprite.flipX = false;
		}
		
	}
    void Jump()
    {
        //animator.SetTrigger("jump");
        if (rb.velocity.y == 0)
            rb.AddForce(Vector2.up * jumpForce);
    }





}
