using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerGrab : MonoBehaviour
{
    //public diary diary;
    public bool getBattery = false;
    public bool insideCarArea = false;
    public int batteryNum = 0;
    //public bool isPlayerInDiary = false;
    public GameObject diaryBox;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Battery")
        {
            Destroy(other.transform.parent.gameObject);
            getBattery = true;
            batteryNum++;
        }

        if (other.tag == "Diary")
        {
            diaryBox.SetActive(true);
            
            diaryBox.transform.GetChild(0).GetComponent<Text>().text = other.GetComponent<diary>().diaryText;
            
            Destroy(other.transform.gameObject);
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
