using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Bullet : MonoBehaviour
{
    //private void OnCollisionEnter(Collision collision)
    //{
    //    Transform hitTransform = collision.transform;
    //    if (hitTransform.CompareTag("Player"))
    //    {
    //        Debug.Log("Hit");
    //        hitTransform.GetComponent<PlayerHealth>().TakeDamage(5);
    //    }
    //    Destroy(gameObject);
    //}

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //Debug.Log("Hit");
            other.GetComponent<PlayerHealth>().TakeDamage(5);
        }
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        print(collision.transform.tag);
        Destroy(gameObject);
    }
}
