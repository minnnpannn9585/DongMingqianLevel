using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public PlayerGrab playerGrab;

    private bool ePressed;
    
    // Update is called once per frame
    void Update()
    {
        if (playerGrab.batteryNum == 2 && Input.GetKeyDown(KeyCode.E) && playerGrab.insideCarArea)
        {
            print(11111111111);
            ePressed = true;
        }
        if (ePressed)
        {
            transform.position += new Vector3(-0.01f, 0, 0);
        }
    }
}
