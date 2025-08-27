using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Diary : MonoBehaviour
{
    //public PlayerGrab playerGrab;s
    //public Text diaryBoxText;

    public GameObject diaryPanel;
    public GameObject diaryText;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            diaryPanel.SetActive(true);
            diaryText.SetActive(true);

        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            
            diaryPanel.SetActive(false);
            diaryText.SetActive(false);
        }
    }






}
