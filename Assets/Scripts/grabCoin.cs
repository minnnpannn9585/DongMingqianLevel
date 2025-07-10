using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class grabCoin : MonoBehaviour
{
    public int coinNumber = 0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            coinNumber++;
            print(coinNumber);
        }

    }
}
