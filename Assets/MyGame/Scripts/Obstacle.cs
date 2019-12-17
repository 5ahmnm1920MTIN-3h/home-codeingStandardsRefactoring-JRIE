using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
Rigidbody2D rb;
[SerializeField] private float MoveSpeed;
private const float offset = 15f;
//Gets the Rigidbody2D Component on Awake
private void Awake()
{
    rb = GetComponent<Rigidbody2D>();
}
void Update()
{
    //if obstacle's position x is < -15f it will be destroyed
    if(transform.position.x < -offset)
    {
        Destroy(gameObject);
}
        //if obstacle's position x is > 15f it will be destroyed
        if (transform.position.x > offset)
        {
            Destroy(gameObject);
        }

    }
private void FixedUpdate()
{

    rb.velocity = Vector2.left * MoveSpeed;

}
}
