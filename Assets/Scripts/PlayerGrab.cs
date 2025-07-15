using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGrab : MonoBehaviour
{
    public bool getBattery = false;
    public bool insideCarArea = false;
    public int batteryNum = 0;
   
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Battery")
        {
            Destroy(other.transform.parent.gameObject);
            getBattery = true;
            batteryNum++;
        }

        if (other.tag == "Car")
        {
            insideCarArea = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Car")
        {
            insideCarArea = false;
        }
    }

}
