using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public PlayerGrab playerGrab;

    private bool ePressed;
    public GameObject DialoguePanel;
    public GameObject CarNotification;
    private float counter = 1.5f;

    
    // Update is called once per frame
    void Update()
    {
        if (playerGrab.batteryNum == 2 && Input.GetKeyDown(KeyCode.E) && playerGrab.insideCarArea)
        {
            print(11111111111);
            ePressed = true;
        }
        if (playerGrab.batteryNum == 1 || playerGrab.batteryNum == 0 && Input.GetKeyDown(KeyCode.E) && playerGrab.insideCarArea)
        {
            DialoguePanel.SetActive(true);
            CarNotification.SetActive(true);
            counter -= Time .deltaTime;
            if (counter < 0) {DialoguePanel.SetActive(false);CarNotification.SetActive(false);}
        }
        if (ePressed)
        {
            transform.position += new Vector3(-0.01f, 0, 0);
        }
    }
}
