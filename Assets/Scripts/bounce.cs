using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounce : MonoBehaviour
{
    public float bounceF = 6f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Rigidbody playerRb = other.GetComponent<Rigidbody>();
            if (playerRb != null)
            {
                Vector3 velocity = playerRb.velocity;
                velocity.y = 0;
                playerRb.velocity = velocity;

                playerRb.AddForce(Vector3.up *  bounceF, ForceMode.Impulse);
            }

        }
    }


    

}
