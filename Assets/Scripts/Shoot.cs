using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    public float bulletSpeed;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bul = Instantiate(bullet, transform.position, Quaternion.Euler(Camera.main.transform.forward));
            bul.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward * bulletSpeed);
            GetComponent<AudioSource>().Play();
        }
    }
}
