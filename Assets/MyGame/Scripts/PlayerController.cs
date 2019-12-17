using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    Animator anim, anim2, anim3, anim4, anim5;
    [SerializeField] float jumpForce;
    
    private const string jumpString = "Jump";
    private const string ground = "Ground";
    private const string obstacle = "Obstacle";
    private const string santaDeath = "SantaDeath";

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // If MousebuttonOne is Pressed, the player jumps
    //Player must be in touch with Ground to jump
    void Update()
    {
        if (Input.GetMouseButton(0) )
        {
            if (grounded == true)
            {
                jump();
            }
        }
    }

    bool grounded;
    bool gameOver = false;
    //Defines the players jump action
    void jump()
    {
        grounded = false;

        rb.velocity = Vector2.up * jumpForce;

        anim.SetTrigger(jumpString);

        GameManager.instance.IncrementScore();
    }
    //Sets the bool SetGameOverTrue to true
    private bool SetGameOverTrue()
    {
        return true;
    }
    //If Player in touch with ground, grounded bool is true
    private void OnCollisionEnter2D(Collision2D collision)   {
        if(collision.gameObject.tag == ground)
        {
            grounded = true;}
    }
    //If player hits Obstacle, Gameover is called, Obstacle is destroyed, deathanimation is played and GameOver screen/overlay is loaded
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == obstacle){
            GameManager.instance.GameOver();
            Destroy(collision.gameObject);
            anim.Play(santaDeath);
            gameOver = SetGameOverTrue();
        }
    }
}
