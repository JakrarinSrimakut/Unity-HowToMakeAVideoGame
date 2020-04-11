using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // Proper way of Input would be 2 bool of key press. Set true if press. Set false if release. Check in fixedUpdate
    // Update is called once per frame
    void FixedUpdate () //For phsyics update use FixedUpdate
    {
        // Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);// deltaTime is the ammount of time the computer drew the frame. Higher Frame rate lower the #. ex: 10 will be .1, 20 will be .05

        if ( Input.GetKey("d") )
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        //falling off ledge endgame
        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
