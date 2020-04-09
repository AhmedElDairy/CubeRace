using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float forwadForce = 2000f;
    public float sidewaysForce = 500f;

    bool moveLeft = false;
    bool moveRight = false;

      void Update()
    {
        if (Input.GetKey("d"))
        {
            moveRight = true;
        }

        if (Input.GetKey("a"))
        {
            moveLeft = true;
        }

    }
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwadForce * Time.deltaTime);

        if (moveRight) {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
            moveRight = false; 
        }

        if (moveLeft) {
            rb.AddForce(- sidewaysForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
            moveLeft = false;
        }

        if(rb.position.y<-1f)
        {
            FindObjectOfType<GameManager>().GameOver();

        }

    } 
}
