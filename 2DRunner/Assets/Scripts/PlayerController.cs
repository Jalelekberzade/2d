using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour
{
   


    public float speed = 5f;
    public float jumpForce = 6f;
    private bool _isGround = true;



    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        //float moveHorizontal = Input.GetAxis("Horizontal");
        //float moveVertical = Input.GetAxis("Vertical");

        transform.position += new Vector3(moveHorizontal, moveVertical) * Time.deltaTime * speed;

        ///transform.Translate(new Vector2(1f, 0f) * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.Space) && _isGround == true)
        {

            _isGround = false;
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }




        //rb.velocity = movement * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            _isGround = true;
        }
    }




}
