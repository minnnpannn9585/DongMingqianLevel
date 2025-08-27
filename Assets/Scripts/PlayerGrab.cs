using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class PlayerGrab : MonoBehaviour
{
    private Camera cam;
    [SerializeField]
    private float distance = 3f;
    
    
    public bool getBattery = false;
    public bool insideCarArea = false;
    public int batteryNum = 0;
   
    public GameObject diaryBox;

    private void Start()
    {
        cam = GetComponent<PlayerInput>().camera;
    }
    void Update()
    {
        Ray ray = new Ray(cam.transform.position, cam.transform.forward);
        Debug.DrawRay(ray.origin,ray.direction *  distance);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Battery")
        {
            Destroy(other.gameObject);
            getBattery = true;
            batteryNum++;
            print(batteryNum);
        }

        if (other.tag == "Diary")
        {
            diaryBox.SetActive(true);
            
            //diaryBox.transform.GetChild(0).GetComponent<Text>().text = other.GetComponent<Diary>().diaryText;
            
            Destroy(other.transform.gameObject);
        }


        if (other.tag == "Car")
        {
            print(222222222222222222);
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
